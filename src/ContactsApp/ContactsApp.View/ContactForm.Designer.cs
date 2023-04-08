namespace ContactsApp.View
{
    partial class ContactForm
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
            this.RightPanel = new System.Windows.Forms.Panel();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.PhotoButton = new System.Windows.Forms.PictureBox();
            this.BirthdayPanel = new System.Windows.Forms.Panel();
            this.BirthdayPanelCloseButton = new System.Windows.Forms.Button();
            this.BirthdaySurnamesLabel = new System.Windows.Forms.Label();
            this.BirthdayLabel = new System.Windows.Forms.Label();
            this.BirthdayPanelPictureBox = new System.Windows.Forms.PictureBox();
            this.VKTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.VKLable = new System.Windows.Forms.Label();
            this.DateOfBirthLabel = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.PhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.RightPanel.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoButton)).BeginInit();
            this.BirthdayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BirthdayPanelPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // RightPanel
            // 
            this.RightPanel.Controls.Add(this.ButtonPanel);
            this.RightPanel.Controls.Add(this.dateTimePicker1);
            this.RightPanel.Controls.Add(this.PhotoButton);
            this.RightPanel.Controls.Add(this.BirthdayPanel);
            this.RightPanel.Controls.Add(this.VKTextBox);
            this.RightPanel.Controls.Add(this.PhoneNumberTextBox);
            this.RightPanel.Controls.Add(this.EmailTextBox);
            this.RightPanel.Controls.Add(this.FullNameTextBox);
            this.RightPanel.Controls.Add(this.VKLable);
            this.RightPanel.Controls.Add(this.DateOfBirthLabel);
            this.RightPanel.Controls.Add(this.PhoneNumberLabel);
            this.RightPanel.Controls.Add(this.EmailLabel);
            this.RightPanel.Controls.Add(this.FullNameLabel);
            this.RightPanel.Controls.Add(this.PhotoPictureBox);
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightPanel.Location = new System.Drawing.Point(0, 0);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(524, 351);
            this.RightPanel.TabIndex = 2;
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonPanel.Controls.Add(this.CancelButton);
            this.ButtonPanel.Controls.Add(this.OkButton);
            this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonPanel.Location = new System.Drawing.Point(0, 305);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(524, 46);
            this.ButtonPanel.TabIndex = 14;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(436, 11);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(3, 3, 13, 3);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(355, 11);
            this.OkButton.Margin = new System.Windows.Forms.Padding(3, 12, 8, 12);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 0;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(118, 194);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(175, 23);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.Value = new System.DateTime(1994, 7, 6, 0, 0, 0, 0);
            // 
            // PhotoButton
            // 
            this.PhotoButton.Image = global::ContactsApp.View.Properties.Resources.add_photo_32x32_gray;
            this.PhotoButton.Location = new System.Drawing.Point(12, 112);
            this.PhotoButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.PhotoButton.Name = "PhotoButton";
            this.PhotoButton.Size = new System.Drawing.Size(100, 32);
            this.PhotoButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PhotoButton.TabIndex = 12;
            this.PhotoButton.TabStop = false;
            this.PhotoButton.MouseEnter += new System.EventHandler(this.PhotoButton_MouseEnter);
            this.PhotoButton.MouseLeave += new System.EventHandler(this.PhotoButton_MouseLeave);
            // 
            // BirthdayPanel
            // 
            this.BirthdayPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BirthdayPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.BirthdayPanel.Controls.Add(this.BirthdayPanelCloseButton);
            this.BirthdayPanel.Controls.Add(this.BirthdaySurnamesLabel);
            this.BirthdayPanel.Controls.Add(this.BirthdayLabel);
            this.BirthdayPanel.Controls.Add(this.BirthdayPanelPictureBox);
            this.BirthdayPanel.Location = new System.Drawing.Point(3, 617);
            this.BirthdayPanel.Name = "BirthdayPanel";
            this.BirthdayPanel.Size = new System.Drawing.Size(862, 75);
            this.BirthdayPanel.TabIndex = 11;
            // 
            // BirthdayPanelCloseButton
            // 
            this.BirthdayPanelCloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BirthdayPanelCloseButton.FlatAppearance.BorderSize = 0;
            this.BirthdayPanelCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BirthdayPanelCloseButton.Image = global::ContactsApp.View.Properties.Resources.close_32x32;
            this.BirthdayPanelCloseButton.Location = new System.Drawing.Point(1165, 3);
            this.BirthdayPanelCloseButton.Name = "BirthdayPanelCloseButton";
            this.BirthdayPanelCloseButton.Size = new System.Drawing.Size(32, 32);
            this.BirthdayPanelCloseButton.TabIndex = 3;
            this.BirthdayPanelCloseButton.UseVisualStyleBackColor = true;
            // 
            // BirthdaySurnamesLabel
            // 
            this.BirthdaySurnamesLabel.AutoSize = true;
            this.BirthdaySurnamesLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BirthdaySurnamesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.BirthdaySurnamesLabel.Location = new System.Drawing.Point(81, 36);
            this.BirthdaySurnamesLabel.Name = "BirthdaySurnamesLabel";
            this.BirthdaySurnamesLabel.Size = new System.Drawing.Size(190, 15);
            this.BirthdaySurnamesLabel.TabIndex = 2;
            this.BirthdaySurnamesLabel.Text = "Абакунов, Петров, Иванов и др.";
            // 
            // BirthdayLabel
            // 
            this.BirthdayLabel.AutoSize = true;
            this.BirthdayLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BirthdayLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.BirthdayLabel.Location = new System.Drawing.Point(81, 17);
            this.BirthdayLabel.Name = "BirthdayLabel";
            this.BirthdayLabel.Size = new System.Drawing.Size(118, 15);
            this.BirthdayLabel.TabIndex = 1;
            this.BirthdayLabel.Text = "Today is Birthday of:";
            // 
            // BirthdayPanelPictureBox
            // 
            this.BirthdayPanelPictureBox.Image = global::ContactsApp.View.Properties.Resources.info_48x48;
            this.BirthdayPanelPictureBox.Location = new System.Drawing.Point(3, 3);
            this.BirthdayPanelPictureBox.Name = "BirthdayPanelPictureBox";
            this.BirthdayPanelPictureBox.Size = new System.Drawing.Size(73, 69);
            this.BirthdayPanelPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BirthdayPanelPictureBox.TabIndex = 0;
            this.BirthdayPanelPictureBox.TabStop = false;
            // 
            // VKTextBox
            // 
            this.VKTextBox.Location = new System.Drawing.Point(118, 248);
            this.VKTextBox.Name = "VKTextBox";
            this.VKTextBox.Size = new System.Drawing.Size(175, 23);
            this.VKTextBox.TabIndex = 10;
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(118, 140);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(175, 23);
            this.PhoneNumberTextBox.TabIndex = 8;
            this.PhoneNumberTextBox.Text = "+7 (999) 234 21-98";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailTextBox.Location = new System.Drawing.Point(118, 86);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(394, 23);
            this.EmailTextBox.TabIndex = 7;
            this.EmailTextBox.Text = "medvedeva@gmail.com";
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FullNameTextBox.Location = new System.Drawing.Point(118, 32);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(394, 23);
            this.FullNameTextBox.TabIndex = 6;
            this.FullNameTextBox.Text = "Медведева Полина ";
            // 
            // VKLable
            // 
            this.VKLable.AutoSize = true;
            this.VKLable.Location = new System.Drawing.Point(118, 230);
            this.VKLable.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.VKLable.Name = "VKLable";
            this.VKLable.Size = new System.Drawing.Size(24, 15);
            this.VKLable.TabIndex = 5;
            this.VKLable.Text = "VK:";
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.AutoSize = true;
            this.DateOfBirthLabel.Location = new System.Drawing.Point(118, 176);
            this.DateOfBirthLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(76, 15);
            this.DateOfBirthLabel.TabIndex = 4;
            this.DateOfBirthLabel.Text = "Date of Birth:";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(118, 122);
            this.PhoneNumberLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(88, 15);
            this.PhoneNumberLabel.TabIndex = 3;
            this.PhoneNumberLabel.Text = "PhoneNumber:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(118, 68);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(44, 15);
            this.EmailLabel.TabIndex = 2;
            this.EmailLabel.Text = "E-mail:";
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(118, 14);
            this.FullNameLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(64, 15);
            this.FullNameLabel.TabIndex = 1;
            this.FullNameLabel.Text = "Full Name:";
            // 
            // PhotoPictureBox
            // 
            this.PhotoPictureBox.Image = global::ContactsApp.View.Properties.Resources.photo_placeholder_100x100;
            this.PhotoPictureBox.Location = new System.Drawing.Point(12, 14);
            this.PhotoPictureBox.Margin = new System.Windows.Forms.Padding(5, 5, 3, 3);
            this.PhotoPictureBox.Name = "PhotoPictureBox";
            this.PhotoPictureBox.Size = new System.Drawing.Size(100, 100);
            this.PhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PhotoPictureBox.TabIndex = 0;
            this.PhotoPictureBox.TabStop = false;
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(524, 351);
            this.Controls.Add(this.RightPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ContactForm";
            this.ShowIcon = false;
            this.RightPanel.ResumeLayout(false);
            this.RightPanel.PerformLayout();
            this.ButtonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PhotoButton)).EndInit();
            this.BirthdayPanel.ResumeLayout(false);
            this.BirthdayPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BirthdayPanelPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel RightPanel;
        private Panel BirthdayPanel;
        private Button BirthdayPanelCloseButton;
        private Label BirthdaySurnamesLabel;
        private Label BirthdayLabel;
        private PictureBox BirthdayPanelPictureBox;
        private TextBox VKTextBox;
        private TextBox PhoneNumberTextBox;
        private TextBox EmailTextBox;
        private TextBox FullNameTextBox;
        private Label VKLable;
        private Label DateOfBirthLabel;
        private Label PhoneNumberLabel;
        private Label EmailLabel;
        private Label FullNameLabel;
        private PictureBox PhotoPictureBox;
        private PictureBox PhotoButton;
        private DateTimePicker dateTimePicker1;
        private Panel ButtonPanel;
        private Button CancelButton;
        private Button OkButton;
    }
}