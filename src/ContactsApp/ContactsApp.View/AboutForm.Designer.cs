namespace ContactsApp.View
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.AppLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.GithubLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.EmailAuthorLabel = new System.Windows.Forms.Label();
            this.LicenseTextBox = new System.Windows.Forms.TextBox();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.OkButton = new System.Windows.Forms.Button();
            this.AllUsedLabel = new System.Windows.Forms.Label();
            this.GithubAuthorLabel = new System.Windows.Forms.LinkLabel();
            this.IconLabel = new System.Windows.Forms.LinkLabel();
            this.ButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AppLabel
            // 
            this.AppLabel.AutoSize = true;
            this.AppLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AppLabel.Location = new System.Drawing.Point(12, 28);
            this.AppLabel.Margin = new System.Windows.Forms.Padding(3, 16, 3, 0);
            this.AppLabel.Name = "AppLabel";
            this.AppLabel.Size = new System.Drawing.Size(147, 30);
            this.AppLabel.TabIndex = 0;
            this.AppLabel.Text = "ContactsApp";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(17, 58);
            this.VersionLabel.Margin = new System.Windows.Forms.Padding(8, 0, 3, 0);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(31, 15);
            this.VersionLabel.TabIndex = 1;
            this.VersionLabel.Text = "v 1.0";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Location = new System.Drawing.Point(17, 93);
            this.AuthorLabel.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(47, 15);
            this.AuthorLabel.TabIndex = 2;
            this.AuthorLabel.Text = "Author:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(17, 118);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(44, 15);
            this.EmailLabel.TabIndex = 3;
            this.EmailLabel.Text = "E-mail:";
            // 
            // GithubLabel
            // 
            this.GithubLabel.AutoSize = true;
            this.GithubLabel.Location = new System.Drawing.Point(17, 143);
            this.GithubLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.GithubLabel.Name = "GithubLabel";
            this.GithubLabel.Size = new System.Drawing.Size(46, 15);
            this.GithubLabel.TabIndex = 4;
            this.GithubLabel.Text = "Github:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(108, 93);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(50, 0, 3, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(82, 15);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "Victor Kovalev";
            // 
            // EmailAuthorLabel
            // 
            this.EmailAuthorLabel.AutoSize = true;
            this.EmailAuthorLabel.Location = new System.Drawing.Point(108, 118);
            this.EmailAuthorLabel.Name = "EmailAuthorLabel";
            this.EmailAuthorLabel.Size = new System.Drawing.Size(145, 15);
            this.EmailAuthorLabel.TabIndex = 6;
            this.EmailAuthorLabel.Text = "kovalev85291@gmail.com";
            // 
            // LicenseTextBox
            // 
            this.LicenseTextBox.Location = new System.Drawing.Point(12, 172);
            this.LicenseTextBox.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.LicenseTextBox.Multiline = true;
            this.LicenseTextBox.Name = "LicenseTextBox";
            this.LicenseTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LicenseTextBox.Size = new System.Drawing.Size(495, 156);
            this.LicenseTextBox.TabIndex = 9;
            this.LicenseTextBox.Text = resources.GetString("LicenseTextBox.Text");
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonPanel.Controls.Add(this.OkButton);
            this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonPanel.Location = new System.Drawing.Point(0, 360);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(524, 46);
            this.ButtonPanel.TabIndex = 15;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(436, 11);
            this.OkButton.Margin = new System.Windows.Forms.Padding(3, 12, 8, 12);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 0;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // AllUsedLabel
            // 
            this.AllUsedLabel.AutoSize = true;
            this.AllUsedLabel.Location = new System.Drawing.Point(17, 331);
            this.AllUsedLabel.Name = "AllUsedLabel";
            this.AllUsedLabel.Size = new System.Drawing.Size(207, 15);
            this.AllUsedLabel.TabIndex = 16;
            this.AllUsedLabel.Text = "All used images are downloaded from";
            // 
            // GithubAuthorLabel
            // 
            this.GithubAuthorLabel.AutoSize = true;
            this.GithubAuthorLabel.Location = new System.Drawing.Point(108, 143);
            this.GithubAuthorLabel.Name = "GithubAuthorLabel";
            this.GithubAuthorLabel.Size = new System.Drawing.Size(166, 15);
            this.GithubAuthorLabel.TabIndex = 18;
            this.GithubAuthorLabel.TabStop = true;
            this.GithubAuthorLabel.Text = "https://github.com/kovalev70";
            this.GithubAuthorLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GithubAuthorLabel_LinkClicked);
            // 
            // IconLabel
            // 
            this.IconLabel.AutoSize = true;
            this.IconLabel.Location = new System.Drawing.Point(219, 331);
            this.IconLabel.Name = "IconLabel";
            this.IconLabel.Size = new System.Drawing.Size(68, 15);
            this.IconLabel.TabIndex = 19;
            this.IconLabel.TabStop = true;
            this.IconLabel.Text = "icons8.com";
            this.IconLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.IconLabel_LinkClicked);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(524, 406);
            this.Controls.Add(this.IconLabel);
            this.Controls.Add(this.GithubAuthorLabel);
            this.Controls.Add(this.AllUsedLabel);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.LicenseTextBox);
            this.Controls.Add(this.EmailAuthorLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.GithubLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.AppLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.ButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label AppLabel;
        private Label VersionLabel;
        private Label AuthorLabel;
        private Label EmailLabel;
        private Label GithubLabel;
        private Label NameLabel;
        private Label EmailAuthorLabel;
        private TextBox LicenseTextBox;
        private Panel ButtonPanel;
        private Button OkButton;
        private Label AllUsedLabel;
        private LinkLabel GithubAuthorLabel;
        private LinkLabel IconLabel;
    }
}