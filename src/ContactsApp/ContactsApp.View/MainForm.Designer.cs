namespace ContactsApp.View
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.ButtonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.RemoveContactButton = new System.Windows.Forms.PictureBox();
            this.EditContactButton = new System.Windows.Forms.PictureBox();
            this.AddContactButton = new System.Windows.Forms.PictureBox();
            this.FindLabel = new System.Windows.Forms.Label();
            this.FindTextBox = new System.Windows.Forms.TextBox();
            this.ContactsListBox = new System.Windows.Forms.ListBox();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.BirthdayPanel = new System.Windows.Forms.Panel();
            this.BirthdayPanelCloseButton = new System.Windows.Forms.PictureBox();
            this.BirthdaySurnamesLabel = new System.Windows.Forms.Label();
            this.BirthdayLabel = new System.Windows.Forms.Label();
            this.BirthdayPanelPictureBox = new System.Windows.Forms.PictureBox();
            this.VKTextBox = new System.Windows.Forms.TextBox();
            this.DateOfBirthTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.VKLable = new System.Windows.Forms.Label();
            this.DateOfBirthLabel = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.PhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.MainTableLayoutPanel.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.ButtonsTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveContactButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditContactButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddContactButton)).BeginInit();
            this.RightPanel.SuspendLayout();
            this.BirthdayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BirthdayPanelCloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BirthdayPanelPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTableLayoutPanel
            // 
            this.MainTableLayoutPanel.ColumnCount = 2;
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 286F));
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.Controls.Add(this.LeftPanel, 0, 0);
            this.MainTableLayoutPanel.Controls.Add(this.RightPanel, 1, 0);
            this.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            this.MainTableLayoutPanel.RowCount = 1;
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.Size = new System.Drawing.Size(914, 600);
            this.MainTableLayoutPanel.TabIndex = 0;
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.ButtonsTableLayoutPanel);
            this.LeftPanel.Controls.Add(this.FindLabel);
            this.LeftPanel.Controls.Add(this.FindTextBox);
            this.LeftPanel.Controls.Add(this.ContactsListBox);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftPanel.Location = new System.Drawing.Point(3, 4);
            this.LeftPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(280, 592);
            this.LeftPanel.TabIndex = 0;
            // 
            // ButtonsTableLayoutPanel
            // 
            this.ButtonsTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonsTableLayoutPanel.ColumnCount = 3;
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonsTableLayoutPanel.Controls.Add(this.RemoveContactButton, 0, 0);
            this.ButtonsTableLayoutPanel.Controls.Add(this.EditContactButton, 0, 0);
            this.ButtonsTableLayoutPanel.Controls.Add(this.AddContactButton, 0, 0);
            this.ButtonsTableLayoutPanel.Location = new System.Drawing.Point(3, 541);
            this.ButtonsTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonsTableLayoutPanel.Name = "ButtonsTableLayoutPanel";
            this.ButtonsTableLayoutPanel.RowCount = 1;
            this.ButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonsTableLayoutPanel.Size = new System.Drawing.Size(272, 55);
            this.ButtonsTableLayoutPanel.TabIndex = 3;
            // 
            // RemoveContactButton
            // 
            this.RemoveContactButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveContactButton.Image = global::ContactsApp.View.Properties.Resources.remove_contact_32x32_gray;
            this.RemoveContactButton.Location = new System.Drawing.Point(180, 0);
            this.RemoveContactButton.Margin = new System.Windows.Forms.Padding(0);
            this.RemoveContactButton.Name = "RemoveContactButton";
            this.RemoveContactButton.Size = new System.Drawing.Size(92, 55);
            this.RemoveContactButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.RemoveContactButton.TabIndex = 6;
            this.RemoveContactButton.TabStop = false;
            this.RemoveContactButton.Click += new System.EventHandler(this.RemoveContactButton_Click);
            this.RemoveContactButton.MouseEnter += new System.EventHandler(this.RemoveContactButton_MouseEnter);
            this.RemoveContactButton.MouseLeave += new System.EventHandler(this.RemoveContactButton_MouseLeave);
            // 
            // EditContactButton
            // 
            this.EditContactButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditContactButton.Image = global::ContactsApp.View.Properties.Resources.edit_contact_32x32_gray;
            this.EditContactButton.Location = new System.Drawing.Point(90, 0);
            this.EditContactButton.Margin = new System.Windows.Forms.Padding(0);
            this.EditContactButton.Name = "EditContactButton";
            this.EditContactButton.Size = new System.Drawing.Size(90, 55);
            this.EditContactButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.EditContactButton.TabIndex = 5;
            this.EditContactButton.TabStop = false;
            this.EditContactButton.Click += new System.EventHandler(this.EditContactButton_Click);
            this.EditContactButton.MouseEnter += new System.EventHandler(this.EditContactButton_MouseEnter);
            this.EditContactButton.MouseLeave += new System.EventHandler(this.EditContactButton_MouseLeave);
            // 
            // AddContactButton
            // 
            this.AddContactButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddContactButton.Image = global::ContactsApp.View.Properties.Resources.add_contact_32x32_gray;
            this.AddContactButton.Location = new System.Drawing.Point(0, 0);
            this.AddContactButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddContactButton.Name = "AddContactButton";
            this.AddContactButton.Size = new System.Drawing.Size(90, 55);
            this.AddContactButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.AddContactButton.TabIndex = 4;
            this.AddContactButton.TabStop = false;
            this.AddContactButton.Click += new System.EventHandler(this.AddContactButton_Click);
            this.AddContactButton.MouseEnter += new System.EventHandler(this.AddContactButton_MouseEnter);
            this.AddContactButton.MouseLeave += new System.EventHandler(this.AddContactButton_MouseLeave);
            // 
            // FindLabel
            // 
            this.FindLabel.AutoSize = true;
            this.FindLabel.Location = new System.Drawing.Point(10, 8);
            this.FindLabel.Name = "FindLabel";
            this.FindLabel.Size = new System.Drawing.Size(40, 20);
            this.FindLabel.TabIndex = 2;
            this.FindLabel.Text = "Find:";
            // 
            // FindTextBox
            // 
            this.FindTextBox.Location = new System.Drawing.Point(55, 4);
            this.FindTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.Size = new System.Drawing.Size(220, 27);
            this.FindTextBox.TabIndex = 1;
            this.FindTextBox.TextChanged += new System.EventHandler(this.FindTextBox_TextChanged);
            // 
            // ContactsListBox
            // 
            this.ContactsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactsListBox.FormattingEnabled = true;
            this.ContactsListBox.IntegralHeight = false;
            this.ContactsListBox.ItemHeight = 20;
            this.ContactsListBox.Location = new System.Drawing.Point(3, 43);
            this.ContactsListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ContactsListBox.Name = "ContactsListBox";
            this.ContactsListBox.Size = new System.Drawing.Size(271, 497);
            this.ContactsListBox.TabIndex = 0;
            this.ContactsListBox.SelectedIndexChanged += new System.EventHandler(this.ContactsListBox_SelectedIndexChanged);
            // 
            // RightPanel
            // 
            this.RightPanel.Controls.Add(this.BirthdayPanel);
            this.RightPanel.Controls.Add(this.VKTextBox);
            this.RightPanel.Controls.Add(this.DateOfBirthTextBox);
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
            this.RightPanel.Location = new System.Drawing.Point(289, 4);
            this.RightPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(622, 592);
            this.RightPanel.TabIndex = 1;
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
            this.BirthdayPanel.Location = new System.Drawing.Point(3, 488);
            this.BirthdayPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BirthdayPanel.Name = "BirthdayPanel";
            this.BirthdayPanel.Size = new System.Drawing.Size(615, 108);
            this.BirthdayPanel.TabIndex = 11;
            // 
            // BirthdayPanelCloseButton
            // 
            this.BirthdayPanelCloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BirthdayPanelCloseButton.Image = global::ContactsApp.View.Properties.Resources.close_32x32;
            this.BirthdayPanelCloseButton.Location = new System.Drawing.Point(575, 4);
            this.BirthdayPanelCloseButton.Margin = new System.Windows.Forms.Padding(0);
            this.BirthdayPanelCloseButton.Name = "BirthdayPanelCloseButton";
            this.BirthdayPanelCloseButton.Size = new System.Drawing.Size(37, 43);
            this.BirthdayPanelCloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BirthdayPanelCloseButton.TabIndex = 7;
            this.BirthdayPanelCloseButton.TabStop = false;
            this.BirthdayPanelCloseButton.Click += new System.EventHandler(this.BirthdayPanelCloseButton_Click);
            // 
            // BirthdaySurnamesLabel
            // 
            this.BirthdaySurnamesLabel.AutoSize = true;
            this.BirthdaySurnamesLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BirthdaySurnamesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.BirthdaySurnamesLabel.Location = new System.Drawing.Point(78, 56);
            this.BirthdaySurnamesLabel.Name = "BirthdaySurnamesLabel";
            this.BirthdaySurnamesLabel.Size = new System.Drawing.Size(0, 20);
            this.BirthdaySurnamesLabel.TabIndex = 2;
            // 
            // BirthdayLabel
            // 
            this.BirthdayLabel.AutoSize = true;
            this.BirthdayLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BirthdayLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.BirthdayLabel.Location = new System.Drawing.Point(78, 31);
            this.BirthdayLabel.Name = "BirthdayLabel";
            this.BirthdayLabel.Size = new System.Drawing.Size(154, 20);
            this.BirthdayLabel.TabIndex = 1;
            this.BirthdayLabel.Text = "Today is Birthday of:";
            // 
            // BirthdayPanelPictureBox
            // 
            this.BirthdayPanelPictureBox.Image = global::ContactsApp.View.Properties.Resources.info_48x48;
            this.BirthdayPanelPictureBox.Location = new System.Drawing.Point(10, 7);
            this.BirthdayPanelPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BirthdayPanelPictureBox.Name = "BirthdayPanelPictureBox";
            this.BirthdayPanelPictureBox.Size = new System.Drawing.Size(67, 88);
            this.BirthdayPanelPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BirthdayPanelPictureBox.TabIndex = 0;
            this.BirthdayPanelPictureBox.TabStop = false;
            // 
            // VKTextBox
            // 
            this.VKTextBox.Location = new System.Drawing.Point(125, 323);
            this.VKTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.VKTextBox.Name = "VKTextBox";
            this.VKTextBox.Size = new System.Drawing.Size(199, 27);
            this.VKTextBox.TabIndex = 10;
            this.VKTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VKTextBox_KeyPress);
            // 
            // DateOfBirthTextBox
            // 
            this.DateOfBirthTextBox.Location = new System.Drawing.Point(125, 251);
            this.DateOfBirthTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DateOfBirthTextBox.Name = "DateOfBirthTextBox";
            this.DateOfBirthTextBox.Size = new System.Drawing.Size(199, 27);
            this.DateOfBirthTextBox.TabIndex = 9;
            this.DateOfBirthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DateOfBirthTextBox_KeyPress);
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(125, 179);
            this.PhoneNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(199, 27);
            this.PhoneNumberTextBox.TabIndex = 8;
            this.PhoneNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneNumberTextBox_KeyPress);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailTextBox.Location = new System.Drawing.Point(125, 107);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(493, 27);
            this.EmailTextBox.TabIndex = 7;
            this.EmailTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmailTextBox_KeyPress);
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FullNameTextBox.Location = new System.Drawing.Point(125, 32);
            this.FullNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(493, 27);
            this.FullNameTextBox.TabIndex = 6;
            this.FullNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FullNameTextBox_KeyPress);
            // 
            // VKLable
            // 
            this.VKLable.AutoSize = true;
            this.VKLable.Location = new System.Drawing.Point(125, 299);
            this.VKLable.Margin = new System.Windows.Forms.Padding(3, 13, 3, 0);
            this.VKLable.Name = "VKLable";
            this.VKLable.Size = new System.Drawing.Size(30, 20);
            this.VKLable.TabIndex = 5;
            this.VKLable.Text = "VK:";
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.AutoSize = true;
            this.DateOfBirthLabel.Location = new System.Drawing.Point(125, 227);
            this.DateOfBirthLabel.Margin = new System.Windows.Forms.Padding(3, 13, 3, 0);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(97, 20);
            this.DateOfBirthLabel.TabIndex = 4;
            this.DateOfBirthLabel.Text = "Date of Birth:";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(125, 155);
            this.PhoneNumberLabel.Margin = new System.Windows.Forms.Padding(3, 13, 3, 0);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(107, 20);
            this.PhoneNumberLabel.TabIndex = 3;
            this.PhoneNumberLabel.Text = "PhoneNumber:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(125, 80);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(3, 13, 3, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(55, 20);
            this.EmailLabel.TabIndex = 2;
            this.EmailLabel.Text = "E-mail:";
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(125, 8);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(79, 20);
            this.FullNameLabel.TabIndex = 1;
            this.FullNameLabel.Text = "Full Name:";
            // 
            // PhotoPictureBox
            // 
            this.PhotoPictureBox.Image = global::ContactsApp.View.Properties.Resources.photo_placeholder_100x100;
            this.PhotoPictureBox.Location = new System.Drawing.Point(3, 4);
            this.PhotoPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PhotoPictureBox.Name = "PhotoPictureBox";
            this.PhotoPictureBox.Size = new System.Drawing.Size(114, 133);
            this.PhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PhotoPictureBox.TabIndex = 0;
            this.PhotoPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.MainTableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "ContactsApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.MainTableLayoutPanel.ResumeLayout(false);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.ButtonsTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RemoveContactButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditContactButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddContactButton)).EndInit();
            this.RightPanel.ResumeLayout(false);
            this.RightPanel.PerformLayout();
            this.BirthdayPanel.ResumeLayout(false);
            this.BirthdayPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BirthdayPanelCloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BirthdayPanelPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel MainTableLayoutPanel;
        private Panel LeftPanel;
        private ListBox ContactsListBox;
        private Panel RightPanel;
        private TableLayoutPanel ButtonsTableLayoutPanel;
        private Label FindLabel;
        private TextBox FindTextBox;
        private Panel BirthdayPanel;
        private Label BirthdaySurnamesLabel;
        private Label BirthdayLabel;
        private PictureBox BirthdayPanelPictureBox;
        private TextBox VKTextBox;
        private TextBox DateOfBirthTextBox;
        private TextBox PhoneNumberTextBox;
        private TextBox EmailTextBox;
        private TextBox FullNameTextBox;
        private Label VKLable;
        private Label DateOfBirthLabel;
        private Label PhoneNumberLabel;
        private Label EmailLabel;
        private Label FullNameLabel;
        private PictureBox PhotoPictureBox;
        private PictureBox AddContactButton;
        private PictureBox RemoveContactButton;
        private PictureBox EditContactButton;
        private PictureBox BirthdayPanelCloseButton;
    }
}