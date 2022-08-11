namespace ClassLibraryinClass5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpbNewUser = new System.Windows.Forms.GroupBox();
            this.rtxtbInfo = new System.Windows.Forms.RichTextBox();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.lblDateCreated = new System.Windows.Forms.Label();
            this.btnGetNewId = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtbPassword = new System.Windows.Forms.TextBox();
            this.txtbUsername = new System.Windows.Forms.TextBox();
            this.txtbId = new System.Windows.Forms.TextBox();
            this.gpbOtherStuff = new System.Windows.Forms.GroupBox();
            this.rtxtbPhrases = new System.Windows.Forms.RichTextBox();
            this.btnShowAllPhrases = new System.Windows.Forms.Button();
            this.btnSavePhrase = new System.Windows.Forms.Button();
            this.lblPhrase = new System.Windows.Forms.Label();
            this.txtbPhrase = new System.Windows.Forms.TextBox();
            this.gpbNewUser.SuspendLayout();
            this.gpbOtherStuff.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbNewUser
            // 
            this.gpbNewUser.Controls.Add(this.rtxtbInfo);
            this.gpbNewUser.Controls.Add(this.btnAddNewUser);
            this.gpbNewUser.Controls.Add(this.lblDateCreated);
            this.gpbNewUser.Controls.Add(this.btnGetNewId);
            this.gpbNewUser.Controls.Add(this.dateTimePicker);
            this.gpbNewUser.Controls.Add(this.lblPassword);
            this.gpbNewUser.Controls.Add(this.lblUsername);
            this.gpbNewUser.Controls.Add(this.lblId);
            this.gpbNewUser.Controls.Add(this.txtbPassword);
            this.gpbNewUser.Controls.Add(this.txtbUsername);
            this.gpbNewUser.Controls.Add(this.txtbId);
            this.gpbNewUser.Location = new System.Drawing.Point(21, 21);
            this.gpbNewUser.Name = "gpbNewUser";
            this.gpbNewUser.Size = new System.Drawing.Size(391, 323);
            this.gpbNewUser.TabIndex = 0;
            this.gpbNewUser.TabStop = false;
            this.gpbNewUser.Text = "New User";
            // 
            // rtxtbInfo
            // 
            this.rtxtbInfo.Location = new System.Drawing.Point(12, 221);
            this.rtxtbInfo.Name = "rtxtbInfo";
            this.rtxtbInfo.Size = new System.Drawing.Size(357, 92);
            this.rtxtbInfo.TabIndex = 10;
            this.rtxtbInfo.Text = "";
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.Location = new System.Drawing.Point(12, 171);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(142, 23);
            this.btnAddNewUser.TabIndex = 9;
            this.btnAddNewUser.Text = "Add New User";
            this.btnAddNewUser.UseVisualStyleBackColor = true;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // lblDateCreated
            // 
            this.lblDateCreated.AutoSize = true;
            this.lblDateCreated.Location = new System.Drawing.Point(12, 127);
            this.lblDateCreated.Name = "lblDateCreated";
            this.lblDateCreated.Size = new System.Drawing.Size(78, 15);
            this.lblDateCreated.TabIndex = 8;
            this.lblDateCreated.Text = "Date Created:";
            // 
            // btnGetNewId
            // 
            this.btnGetNewId.Location = new System.Drawing.Point(280, 36);
            this.btnGetNewId.Name = "btnGetNewId";
            this.btnGetNewId.Size = new System.Drawing.Size(89, 23);
            this.btnGetNewId.TabIndex = 7;
            this.btnGetNewId.Text = "Get new ID";
            this.btnGetNewId.UseVisualStyleBackColor = true;
            this.btnGetNewId.Click += new System.EventHandler(this.btnGetNewId_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(135, 121);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(234, 23);
            this.dateTimePicker.TabIndex = 6;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(12, 97);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(60, 15);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(12, 68);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(63, 15);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 39);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 15);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "ID:";
            // 
            // txtbPassword
            // 
            this.txtbPassword.Location = new System.Drawing.Point(135, 94);
            this.txtbPassword.Name = "txtbPassword";
            this.txtbPassword.Size = new System.Drawing.Size(234, 23);
            this.txtbPassword.TabIndex = 2;
            // 
            // txtbUsername
            // 
            this.txtbUsername.Location = new System.Drawing.Point(135, 65);
            this.txtbUsername.Name = "txtbUsername";
            this.txtbUsername.Size = new System.Drawing.Size(234, 23);
            this.txtbUsername.TabIndex = 1;
            // 
            // txtbId
            // 
            this.txtbId.Location = new System.Drawing.Point(135, 36);
            this.txtbId.Name = "txtbId";
            this.txtbId.Size = new System.Drawing.Size(110, 23);
            this.txtbId.TabIndex = 0;
            // 
            // gpbOtherStuff
            // 
            this.gpbOtherStuff.Controls.Add(this.rtxtbPhrases);
            this.gpbOtherStuff.Controls.Add(this.btnShowAllPhrases);
            this.gpbOtherStuff.Controls.Add(this.btnSavePhrase);
            this.gpbOtherStuff.Controls.Add(this.lblPhrase);
            this.gpbOtherStuff.Controls.Add(this.txtbPhrase);
            this.gpbOtherStuff.Location = new System.Drawing.Point(433, 21);
            this.gpbOtherStuff.Name = "gpbOtherStuff";
            this.gpbOtherStuff.Size = new System.Drawing.Size(371, 209);
            this.gpbOtherStuff.TabIndex = 1;
            this.gpbOtherStuff.TabStop = false;
            this.gpbOtherStuff.Text = "Other Stuff";
            // 
            // rtxtbPhrases
            // 
            this.rtxtbPhrases.Location = new System.Drawing.Point(15, 102);
            this.rtxtbPhrases.Name = "rtxtbPhrases";
            this.rtxtbPhrases.Size = new System.Drawing.Size(340, 99);
            this.rtxtbPhrases.TabIndex = 4;
            this.rtxtbPhrases.Text = "";
            // 
            // btnShowAllPhrases
            // 
            this.btnShowAllPhrases.Location = new System.Drawing.Point(185, 68);
            this.btnShowAllPhrases.Name = "btnShowAllPhrases";
            this.btnShowAllPhrases.Size = new System.Drawing.Size(170, 25);
            this.btnShowAllPhrases.TabIndex = 3;
            this.btnShowAllPhrases.Text = "Show All Phrases";
            this.btnShowAllPhrases.UseVisualStyleBackColor = true;
            this.btnShowAllPhrases.Click += new System.EventHandler(this.btnShowAllPhrases_Click);
            // 
            // btnSavePhrase
            // 
            this.btnSavePhrase.Location = new System.Drawing.Point(15, 68);
            this.btnSavePhrase.Name = "btnSavePhrase";
            this.btnSavePhrase.Size = new System.Drawing.Size(125, 25);
            this.btnSavePhrase.TabIndex = 2;
            this.btnSavePhrase.Text = "Save Phrase";
            this.btnSavePhrase.UseVisualStyleBackColor = true;
            this.btnSavePhrase.Click += new System.EventHandler(this.btnSavePhrase_Click);
            // 
            // lblPhrase
            // 
            this.lblPhrase.AutoSize = true;
            this.lblPhrase.Location = new System.Drawing.Point(15, 40);
            this.lblPhrase.Name = "lblPhrase";
            this.lblPhrase.Size = new System.Drawing.Size(45, 15);
            this.lblPhrase.TabIndex = 1;
            this.lblPhrase.Text = "Phrase:";
            // 
            // txtbPhrase
            // 
            this.txtbPhrase.Location = new System.Drawing.Point(66, 36);
            this.txtbPhrase.Name = "txtbPhrase";
            this.txtbPhrase.Size = new System.Drawing.Size(289, 23);
            this.txtbPhrase.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 352);
            this.Controls.Add(this.gpbOtherStuff);
            this.Controls.Add(this.gpbNewUser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpbNewUser.ResumeLayout(false);
            this.gpbNewUser.PerformLayout();
            this.gpbOtherStuff.ResumeLayout(false);
            this.gpbOtherStuff.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gpbNewUser;
        private Button btnAddNewUser;
        private Label lblDateCreated;
        private Button btnGetNewId;
        private DateTimePicker dateTimePicker;
        private Label lblPassword;
        private Label lblUsername;
        private Label lblId;
        private TextBox txtbPassword;
        private TextBox txtbUsername;
        private TextBox txtbId;
        private GroupBox gpbOtherStuff;
        private RichTextBox rtxtbPhrases;
        private Button btnShowAllPhrases;
        private Button btnSavePhrase;
        private Label lblPhrase;
        private TextBox txtbPhrase;
        private RichTextBox rtxtbInfo;
    }
}