using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace IdentifiAPISampleApplication {
    public partial class OLEForm : Form {
        private OLEClient oleClient;
        private ApplicationClient applicationClient;
        private string recipientEmailAddress;

        public OLEForm() {
            InitializeComponent();

            // Setup the base URL to Identifi, changing the server name to point to your Identifi server.
            const string baseUrl = "http://localhost/identifi.net";

            // Setup the API key for authorization. The API key for your user account can be obtained by logging on to Identifi, opening the user settings from the user icon in the header bar, and clicking on the Integration tab.
            SampleClientBase.apiKey = "*** INSERT API KEY HERE ***";

            // Setup an email address to be used for the recipient of the OLE package
            recipientEmailAddress = "*** INSERT RECIPIENT EMAIL ADDRESS HERE ***";

            // Create a client proxy for calling the OLE APIs and setup the base URL for the server
            oleClient = new OLEClient();
            oleClient.BaseUrl = baseUrl;

            // Create a client proxy for calling the Identifi application APIs and setup the base URL for the server
            applicationClient = new ApplicationClient();
            applicationClient.BaseUrl = baseUrl;
        }

        #region Event Handlers

        private void loadProfilesButton_Click(object sender, EventArgs e) {
            LoadProfiles();
        }

        private void profileComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            var selectedProfile = (OLEProfileInfoModel)profileComboBox.SelectedValue;

            int profileId = selectedProfile.Id.Value;
            int applicationId = selectedProfile.ApplicationId.Value;

            LoadSenders(profileId);
            LoadDocumentTypes(applicationId);
        }

        private void createPackageButton_Click(object sender, EventArgs e) {
            Guid uploadFileId;

            // Before creating the OLE package, we need to upload the PDF file to the server and get an upload id (GUID) back. Multiple PDF files can be uploaded individually, each getting a unique GUID.
            using (var sampleFileStream = new FileStream(Path.Combine(Application.StartupPath, "sample.pdf"), FileMode.Open, FileAccess.Read)) {
                FileParameter file = new FileParameter(sampleFileStream, "sample.pdf");
                uploadFileId = new Guid(oleClient.UploadFileAsync(file).Result);
            }

            // Create a new package model containing all the relevant detail
            var model = new OLEPackageModel {
                ProfileId = ((OLEProfileInfoModel)profileComboBox.SelectedValue).Id.Value,
                Name = "Sample Package",
                Description = "This is a sample package",
                Expiration = DateTime.UtcNow.AddDays(7),
                UserId = (int)senderComboBox.SelectedValue,
                SetSigningOrder = false,
                ReviewBeforeCompletion = false,
                EmailMessage = "This is a sample email message sent to all recipients",
                Recipients = new List<OLEPackageRecipientModel> {
                    // Add the recipients to the model. Each recipient should be given a unique id.
                    new OLEPackageRecipientModel {
                        Id = 1,
                        FirstName = "Test",
                        LastName = "User",
                        Email = recipientEmailAddress,
                        AuthMethod = OLEPackageRecipientModelAuthMethod._1, // Email authentication
                        EnableKba = false
                    }
                },
                Documents = new List<OLEPackageDocumentModel> {
                    // This sample adds only one document to the package, but multiple documents are allowed
                    new OLEPackageDocumentModel {
                        DocumentTypeId = (int)documentTypeComboBox.SelectedValue,
                        Name = "Sample Document",
                        FileType = "pdf",
                        FileId = uploadFileId,  // This is the file id that was uploaded eariler
                        Signatures = new List<OLEPackageDocumentSignatureModel> {
                            // Add the signature to the document. Each signature should reference a recipient id that has been added to the recipients collection. Signature coordinates and size are expressed in pixels (96 DPI).
                            new OLEPackageDocumentSignatureModel {
                                RecipientId = 1,
                                PageNumber = 1,
                                XPosition = 100,
                                YPosition = 100,
                                Width = 200,
                                Height = 30
                            }
                        }
                    }
                }
            };

            // Create the package on the server and get the package id in the response
            int packageId = oleClient.AddPackageAsync(model).Result;
            packageIdTextBox.Text = packageId.ToString();
        }

        private void sendPackageButton_Click(object sender, EventArgs e) {
            // Call the server to send the package out for signing
            oleClient.SendPackageAsync(Convert.ToInt32(packageIdTextBox.Text)).Wait();

            packageSentLabel.Text = "Package Sent Successfully";
            packageSentLabel.Enabled = true;
        }

        #endregion

        #region Private methods

        private void LoadProfiles() {
            var profiles = oleClient.GetProfilesAsync().Result;

            profileComboBox.DisplayMember = "name";
            profileComboBox.DataSource = profiles;

            createPackageButton.Enabled = true;
        }

        private void LoadSenders(int profileId) {
            var users = oleClient.GetReassignUsersAsync(profileId).Result;

            senderComboBox.DisplayMember = "description";
            senderComboBox.ValueMember = "id";
            senderComboBox.DataSource = users;
        }

        private void LoadDocumentTypes(int applicationId) {
            var documentTypes = applicationClient.ListApplicationDocumentTypesAsync(applicationId).Result;

            documentTypeComboBox.DisplayMember = "name";
            documentTypeComboBox.ValueMember = "id";
            documentTypeComboBox.DataSource = documentTypes;
        }

        #endregion

    }
}
