
namespace IdentifiAPISampleApplication {
    partial class OLEForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.button1 = new System.Windows.Forms.Button();
            this.profileComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.senderComboBox = new System.Windows.Forms.ComboBox();
            this.createPackageButton = new System.Windows.Forms.Button();
            this.documentTypeLabel = new System.Windows.Forms.Label();
            this.documentTypeComboBox = new System.Windows.Forms.ComboBox();
            this.packageIdLabel = new System.Windows.Forms.Label();
            this.packageIdTextBox = new System.Windows.Forms.TextBox();
            this.sendPackageButton = new System.Windows.Forms.Button();
            this.packageSentLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(195, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load Profiles";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.loadProfilesButton_Click);
            // 
            // profileComboBox
            // 
            this.profileComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.profileComboBox.FormattingEnabled = true;
            this.profileComboBox.Location = new System.Drawing.Point(106, 24);
            this.profileComboBox.Name = "profileComboBox";
            this.profileComboBox.Size = new System.Drawing.Size(308, 21);
            this.profileComboBox.TabIndex = 1;
            this.profileComboBox.SelectedIndexChanged += new System.EventHandler(this.profileComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "OLE Profile:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sender:";
            // 
            // senderComboBox
            // 
            this.senderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.senderComboBox.FormattingEnabled = true;
            this.senderComboBox.Location = new System.Drawing.Point(106, 115);
            this.senderComboBox.Name = "senderComboBox";
            this.senderComboBox.Size = new System.Drawing.Size(308, 21);
            this.senderComboBox.TabIndex = 4;
            // 
            // createPackageButton
            // 
            this.createPackageButton.Enabled = false;
            this.createPackageButton.Location = new System.Drawing.Point(186, 208);
            this.createPackageButton.Name = "createPackageButton";
            this.createPackageButton.Size = new System.Drawing.Size(113, 23);
            this.createPackageButton.TabIndex = 5;
            this.createPackageButton.Text = "Create Package";
            this.createPackageButton.UseVisualStyleBackColor = true;
            this.createPackageButton.Click += new System.EventHandler(this.createPackageButton_Click);
            // 
            // documentTypeLabel
            // 
            this.documentTypeLabel.AutoSize = true;
            this.documentTypeLabel.Location = new System.Drawing.Point(14, 161);
            this.documentTypeLabel.Name = "documentTypeLabel";
            this.documentTypeLabel.Size = new System.Drawing.Size(86, 13);
            this.documentTypeLabel.TabIndex = 7;
            this.documentTypeLabel.Text = "Document Type:";
            // 
            // documentTypeComboBox
            // 
            this.documentTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.documentTypeComboBox.FormattingEnabled = true;
            this.documentTypeComboBox.Location = new System.Drawing.Point(106, 158);
            this.documentTypeComboBox.Name = "documentTypeComboBox";
            this.documentTypeComboBox.Size = new System.Drawing.Size(308, 21);
            this.documentTypeComboBox.TabIndex = 8;
            // 
            // packageIdLabel
            // 
            this.packageIdLabel.AutoSize = true;
            this.packageIdLabel.Location = new System.Drawing.Point(14, 270);
            this.packageIdLabel.Name = "packageIdLabel";
            this.packageIdLabel.Size = new System.Drawing.Size(67, 13);
            this.packageIdLabel.TabIndex = 9;
            this.packageIdLabel.Text = "Package ID:";
            // 
            // packageIdTextBox
            // 
            this.packageIdTextBox.Location = new System.Drawing.Point(106, 267);
            this.packageIdTextBox.Name = "packageIdTextBox";
            this.packageIdTextBox.Size = new System.Drawing.Size(308, 20);
            this.packageIdTextBox.TabIndex = 10;
            // 
            // sendPackageButton
            // 
            this.sendPackageButton.Location = new System.Drawing.Point(186, 312);
            this.sendPackageButton.Name = "sendPackageButton";
            this.sendPackageButton.Size = new System.Drawing.Size(113, 23);
            this.sendPackageButton.TabIndex = 11;
            this.sendPackageButton.Text = "Send Package";
            this.sendPackageButton.UseVisualStyleBackColor = true;
            this.sendPackageButton.Click += new System.EventHandler(this.sendPackageButton_Click);
            // 
            // packageSentLabel
            // 
            this.packageSentLabel.AutoSize = true;
            this.packageSentLabel.Enabled = false;
            this.packageSentLabel.Location = new System.Drawing.Point(172, 359);
            this.packageSentLabel.Name = "packageSentLabel";
            this.packageSentLabel.Size = new System.Drawing.Size(136, 13);
            this.packageSentLabel.TabIndex = 12;
            this.packageSentLabel.Text = "No package has been sent";
            // 
            // OLEForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 399);
            this.Controls.Add(this.packageSentLabel);
            this.Controls.Add(this.sendPackageButton);
            this.Controls.Add(this.packageIdTextBox);
            this.Controls.Add(this.packageIdLabel);
            this.Controls.Add(this.documentTypeComboBox);
            this.Controls.Add(this.documentTypeLabel);
            this.Controls.Add(this.createPackageButton);
            this.Controls.Add(this.senderComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.profileComboBox);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "OLEForm";
            this.Text = "OLE Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox profileComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox senderComboBox;
        private System.Windows.Forms.Button createPackageButton;
        private System.Windows.Forms.Label documentTypeLabel;
        private System.Windows.Forms.ComboBox documentTypeComboBox;
        private System.Windows.Forms.Label packageIdLabel;
        private System.Windows.Forms.TextBox packageIdTextBox;
        private System.Windows.Forms.Button sendPackageButton;
        private System.Windows.Forms.Label packageSentLabel;
    }
}

