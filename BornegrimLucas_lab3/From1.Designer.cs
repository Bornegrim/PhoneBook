namespace BornegrimLucas_Lab3
{
    partial class From1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNewContact = new System.Windows.Forms.TextBox();
            this.btnSaveContact = new System.Windows.Forms.Button();
            this.lstContacts = new System.Windows.Forms.ListBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.btnDeleteContact = new System.Windows.Forms.Button();
            this.chkIsSecret = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtNewContact
            // 
            this.txtNewContact.Location = new System.Drawing.Point(39, 12);
            this.txtNewContact.Name = "txtNewContact";
            this.txtNewContact.Size = new System.Drawing.Size(457, 20);
            this.txtNewContact.TabIndex = 0;
            // 
            // btnSaveContact
            // 
            this.btnSaveContact.Location = new System.Drawing.Point(39, 50);
            this.btnSaveContact.Name = "btnSaveContact";
            this.btnSaveContact.Size = new System.Drawing.Size(338, 23);
            this.btnSaveContact.TabIndex = 1;
            this.btnSaveContact.Text = "Save";
            this.btnSaveContact.UseVisualStyleBackColor = true;
            this.btnSaveContact.Click += new System.EventHandler(this.btnSaveContact_Click);
            // 
            // lstContacts
            // 
            this.lstContacts.FormattingEnabled = true;
            this.lstContacts.Location = new System.Drawing.Point(12, 105);
            this.lstContacts.Name = "lstContacts";
            this.lstContacts.Size = new System.Drawing.Size(506, 446);
            this.lstContacts.TabIndex = 2;
            this.lstContacts.SelectedIndexChanged += new System.EventHandler(this.lstContacts_SelectedIndexChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(386, 565);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(132, 20);
            this.txtFirstName.TabIndex = 3;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(386, 617);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.ReadOnly = true;
            this.txtPhoneNumber.Size = new System.Drawing.Size(132, 20);
            this.txtPhoneNumber.TabIndex = 4;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(386, 591);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(132, 20);
            this.txtLastName.TabIndex = 5;
            // 
            // btnDeleteContact
            // 
            this.btnDeleteContact.Location = new System.Drawing.Point(12, 565);
            this.btnDeleteContact.Name = "btnDeleteContact";
            this.btnDeleteContact.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteContact.TabIndex = 6;
            this.btnDeleteContact.Text = "Delete";
            this.btnDeleteContact.UseVisualStyleBackColor = true;
            this.btnDeleteContact.Click += new System.EventHandler(this.btnDeleteContact_Click);
            // 
            // chkIsSecret
            // 
            this.chkIsSecret.AutoSize = true;
            this.chkIsSecret.Location = new System.Drawing.Point(399, 54);
            this.chkIsSecret.Name = "chkIsSecret";
            this.chkIsSecret.Size = new System.Drawing.Size(96, 17);
            this.chkIsSecret.TabIndex = 7;
            this.chkIsSecret.Text = "Secret contact";
            this.chkIsSecret.UseVisualStyleBackColor = true;
            // 
            // From1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 649);
            this.Controls.Add(this.chkIsSecret);
            this.Controls.Add(this.btnDeleteContact);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lstContacts);
            this.Controls.Add(this.btnSaveContact);
            this.Controls.Add(this.txtNewContact);
            this.Name = "From1";
            this.Text = "PhoneBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewContact;
        private System.Windows.Forms.Button btnSaveContact;
        private System.Windows.Forms.ListBox lstContacts;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button btnDeleteContact;
        private System.Windows.Forms.CheckBox chkIsSecret;
    }
}

