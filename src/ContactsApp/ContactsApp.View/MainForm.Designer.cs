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
            MainTableLayoutPanel = new TableLayoutPanel();
            LeftPanel = new Panel();
            ButtonsTableLayoutPanel = new TableLayoutPanel();
            RemoveContactButton = new PictureBox();
            EditContactButton = new PictureBox();
            AddContactButton = new PictureBox();
            FindLabel = new Label();
            FindTextBox = new TextBox();
            ContactsListBox = new ListBox();
            RightPanel = new Panel();
            BirthdayPanel = new Panel();
            BirthdayPanelCloseButton = new PictureBox();
            BirthdaySurnamesLabel = new Label();
            BirthdayLabel = new Label();
            BirthdayPanelPictureBox = new PictureBox();
            VKTextBox = new TextBox();
            DateOfBirthTextBox = new TextBox();
            PhoneNumberTextBox = new TextBox();
            EmailTextBox = new TextBox();
            FullNameTextBox = new TextBox();
            VKLable = new Label();
            DateOfBirthLabel = new Label();
            PhoneNumberLabel = new Label();
            EmailLabel = new Label();
            FullNameLabel = new Label();
            PhotoPictureBox = new PictureBox();
            MainTableLayoutPanel.SuspendLayout();
            LeftPanel.SuspendLayout();
            ButtonsTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RemoveContactButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EditContactButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddContactButton).BeginInit();
            RightPanel.SuspendLayout();
            BirthdayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BirthdayPanelCloseButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BirthdayPanelPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PhotoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // MainTableLayoutPanel
            // 
            MainTableLayoutPanel.ColumnCount = 2;
            MainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            MainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            MainTableLayoutPanel.Controls.Add(LeftPanel, 0, 0);
            MainTableLayoutPanel.Controls.Add(RightPanel, 1, 0);
            MainTableLayoutPanel.Dock = DockStyle.Fill;
            MainTableLayoutPanel.Location = new Point(0, 0);
            MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            MainTableLayoutPanel.RowCount = 1;
            MainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            MainTableLayoutPanel.Size = new Size(800, 450);
            MainTableLayoutPanel.TabIndex = 0;
            // 
            // LeftPanel
            // 
            LeftPanel.Controls.Add(ButtonsTableLayoutPanel);
            LeftPanel.Controls.Add(FindLabel);
            LeftPanel.Controls.Add(FindTextBox);
            LeftPanel.Controls.Add(ContactsListBox);
            LeftPanel.Dock = DockStyle.Fill;
            LeftPanel.Location = new Point(3, 3);
            LeftPanel.Name = "LeftPanel";
            LeftPanel.Size = new Size(244, 444);
            LeftPanel.TabIndex = 0;
            // 
            // ButtonsTableLayoutPanel
            // 
            ButtonsTableLayoutPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ButtonsTableLayoutPanel.ColumnCount = 3;
            ButtonsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            ButtonsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            ButtonsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            ButtonsTableLayoutPanel.Controls.Add(RemoveContactButton, 0, 0);
            ButtonsTableLayoutPanel.Controls.Add(EditContactButton, 0, 0);
            ButtonsTableLayoutPanel.Controls.Add(AddContactButton, 0, 0);
            ButtonsTableLayoutPanel.Location = new Point(3, 406);
            ButtonsTableLayoutPanel.Name = "ButtonsTableLayoutPanel";
            ButtonsTableLayoutPanel.RowCount = 1;
            ButtonsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            ButtonsTableLayoutPanel.Size = new Size(238, 41);
            ButtonsTableLayoutPanel.TabIndex = 3;
            // 
            // RemoveContactButton
            // 
            RemoveContactButton.Dock = DockStyle.Fill;
            RemoveContactButton.Image = Properties.Resources.remove_contact_32x32_gray;
            RemoveContactButton.Location = new Point(158, 0);
            RemoveContactButton.Margin = new Padding(0);
            RemoveContactButton.Name = "RemoveContactButton";
            RemoveContactButton.Size = new Size(80, 41);
            RemoveContactButton.SizeMode = PictureBoxSizeMode.CenterImage;
            RemoveContactButton.TabIndex = 6;
            RemoveContactButton.TabStop = false;
            RemoveContactButton.MouseEnter += RemoveContactButton_MouseEnter;
            RemoveContactButton.MouseLeave += RemoveContactButton_MouseLeave;
            // 
            // EditContactButton
            // 
            EditContactButton.Dock = DockStyle.Fill;
            EditContactButton.Image = Properties.Resources.edit_contact_32x32_gray;
            EditContactButton.Location = new Point(79, 0);
            EditContactButton.Margin = new Padding(0);
            EditContactButton.Name = "EditContactButton";
            EditContactButton.Size = new Size(79, 41);
            EditContactButton.SizeMode = PictureBoxSizeMode.CenterImage;
            EditContactButton.TabIndex = 5;
            EditContactButton.TabStop = false;
            EditContactButton.MouseEnter += EditContactButton_MouseEnter;
            EditContactButton.MouseLeave += EditContactButton_MouseLeave;
            // 
            // AddContactButton
            // 
            AddContactButton.Dock = DockStyle.Fill;
            AddContactButton.Image = Properties.Resources.add_contact_32x32_gray;
            AddContactButton.Location = new Point(0, 0);
            AddContactButton.Margin = new Padding(0);
            AddContactButton.Name = "AddContactButton";
            AddContactButton.Size = new Size(79, 41);
            AddContactButton.SizeMode = PictureBoxSizeMode.CenterImage;
            AddContactButton.TabIndex = 4;
            AddContactButton.TabStop = false;
            AddContactButton.Click += AddContactButton_Click;
            AddContactButton.MouseEnter += AddContactButton_MouseEnter;
            AddContactButton.MouseLeave += AddContactButton_MouseLeave;
            // 
            // FindLabel
            // 
            FindLabel.AutoSize = true;
            FindLabel.Location = new Point(9, 6);
            FindLabel.Name = "FindLabel";
            FindLabel.Size = new Size(33, 15);
            FindLabel.TabIndex = 2;
            FindLabel.Text = "Find:";
            // 
            // FindTextBox
            // 
            FindTextBox.Location = new Point(48, 3);
            FindTextBox.Name = "FindTextBox";
            FindTextBox.Size = new Size(193, 23);
            FindTextBox.TabIndex = 1;
            // 
            // ContactsListBox
            // 
            ContactsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ContactsListBox.FormattingEnabled = true;
            ContactsListBox.IntegralHeight = false;
            ContactsListBox.ItemHeight = 15;
            ContactsListBox.Items.AddRange(new object[] { "Медведева Полина ", "Михайлов Георгий ", "Мальцева Анастасия ", "Голубева Елизавета", "Голубева Зоя ", "Орлов Алексей", "Белова Оливия", "Руднева Дарья ", "Лапшин Богдан ", "Федоров Денис" });
            ContactsListBox.Location = new Point(3, 32);
            ContactsListBox.Name = "ContactsListBox";
            ContactsListBox.Size = new Size(238, 374);
            ContactsListBox.TabIndex = 0;
            // 
            // RightPanel
            // 
            RightPanel.Controls.Add(BirthdayPanel);
            RightPanel.Controls.Add(VKTextBox);
            RightPanel.Controls.Add(DateOfBirthTextBox);
            RightPanel.Controls.Add(PhoneNumberTextBox);
            RightPanel.Controls.Add(EmailTextBox);
            RightPanel.Controls.Add(FullNameTextBox);
            RightPanel.Controls.Add(VKLable);
            RightPanel.Controls.Add(DateOfBirthLabel);
            RightPanel.Controls.Add(PhoneNumberLabel);
            RightPanel.Controls.Add(EmailLabel);
            RightPanel.Controls.Add(FullNameLabel);
            RightPanel.Controls.Add(PhotoPictureBox);
            RightPanel.Dock = DockStyle.Fill;
            RightPanel.Location = new Point(253, 3);
            RightPanel.Name = "RightPanel";
            RightPanel.Size = new Size(544, 444);
            RightPanel.TabIndex = 1;
            // 
            // BirthdayPanel
            // 
            BirthdayPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BirthdayPanel.BackColor = Color.FromArgb(245, 245, 255);
            BirthdayPanel.Controls.Add(BirthdayPanelCloseButton);
            BirthdayPanel.Controls.Add(BirthdaySurnamesLabel);
            BirthdayPanel.Controls.Add(BirthdayLabel);
            BirthdayPanel.Controls.Add(BirthdayPanelPictureBox);
            BirthdayPanel.Location = new Point(3, 366);
            BirthdayPanel.Name = "BirthdayPanel";
            BirthdayPanel.Size = new Size(538, 81);
            BirthdayPanel.TabIndex = 11;
            // 
            // BirthdayPanelCloseButton
            // 
            BirthdayPanelCloseButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BirthdayPanelCloseButton.Image = Properties.Resources.close_32x32;
            BirthdayPanelCloseButton.Location = new Point(503, 3);
            BirthdayPanelCloseButton.Margin = new Padding(0);
            BirthdayPanelCloseButton.Name = "BirthdayPanelCloseButton";
            BirthdayPanelCloseButton.Size = new Size(32, 32);
            BirthdayPanelCloseButton.SizeMode = PictureBoxSizeMode.CenterImage;
            BirthdayPanelCloseButton.TabIndex = 7;
            BirthdayPanelCloseButton.TabStop = false;
            BirthdayPanelCloseButton.Click += BirthdayPanelCloseButton_Click;
            // 
            // BirthdaySurnamesLabel
            // 
            BirthdaySurnamesLabel.AutoSize = true;
            BirthdaySurnamesLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BirthdaySurnamesLabel.ForeColor = Color.FromArgb(0, 144, 255);
            BirthdaySurnamesLabel.Location = new Point(68, 42);
            BirthdaySurnamesLabel.Name = "BirthdaySurnamesLabel";
            BirthdaySurnamesLabel.Size = new Size(190, 15);
            BirthdaySurnamesLabel.TabIndex = 2;
            BirthdaySurnamesLabel.Text = "Абакунов, Петров, Иванов и др.";
            // 
            // BirthdayLabel
            // 
            BirthdayLabel.AutoSize = true;
            BirthdayLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BirthdayLabel.ForeColor = Color.FromArgb(0, 144, 255);
            BirthdayLabel.Location = new Point(68, 23);
            BirthdayLabel.Name = "BirthdayLabel";
            BirthdayLabel.Size = new Size(118, 15);
            BirthdayLabel.TabIndex = 1;
            BirthdayLabel.Text = "Today is Birthday of:";
            // 
            // BirthdayPanelPictureBox
            // 
            BirthdayPanelPictureBox.Image = Properties.Resources.info_48x48;
            BirthdayPanelPictureBox.Location = new Point(9, 5);
            BirthdayPanelPictureBox.Name = "BirthdayPanelPictureBox";
            BirthdayPanelPictureBox.Size = new Size(59, 66);
            BirthdayPanelPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            BirthdayPanelPictureBox.TabIndex = 0;
            BirthdayPanelPictureBox.TabStop = false;
            // 
            // VKTextBox
            // 
            VKTextBox.Location = new Point(109, 242);
            VKTextBox.Name = "VKTextBox";
            VKTextBox.Size = new Size(175, 23);
            VKTextBox.TabIndex = 10;
            VKTextBox.KeyPress += VKTextBox_KeyPress;
            // 
            // DateOfBirthTextBox
            // 
            DateOfBirthTextBox.Location = new Point(109, 188);
            DateOfBirthTextBox.Name = "DateOfBirthTextBox";
            DateOfBirthTextBox.Size = new Size(175, 23);
            DateOfBirthTextBox.TabIndex = 9;
            DateOfBirthTextBox.KeyPress += DateOfBirthTextBox_KeyPress;
            // 
            // PhoneNumberTextBox
            // 
            PhoneNumberTextBox.Location = new Point(109, 134);
            PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            PhoneNumberTextBox.Size = new Size(175, 23);
            PhoneNumberTextBox.TabIndex = 8;
            PhoneNumberTextBox.Text = "+7 (999) 234 21-98";
            PhoneNumberTextBox.KeyPress += PhoneNumberTextBox_KeyPress;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            EmailTextBox.Location = new Point(109, 80);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(432, 23);
            EmailTextBox.TabIndex = 7;
            EmailTextBox.Text = "medvedeva@gmail.com";
            EmailTextBox.KeyPress += EmailTextBox_KeyPress;
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FullNameTextBox.Location = new Point(109, 24);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new Size(432, 23);
            FullNameTextBox.TabIndex = 6;
            FullNameTextBox.Text = "Медведева Полина ";
            FullNameTextBox.KeyPress += FullNameTextBox_KeyPress;
            // 
            // VKLable
            // 
            VKLable.AutoSize = true;
            VKLable.Location = new Point(109, 224);
            VKLable.Margin = new Padding(3, 10, 3, 0);
            VKLable.Name = "VKLable";
            VKLable.Size = new Size(24, 15);
            VKLable.TabIndex = 5;
            VKLable.Text = "VK:";
            // 
            // DateOfBirthLabel
            // 
            DateOfBirthLabel.AutoSize = true;
            DateOfBirthLabel.Location = new Point(109, 170);
            DateOfBirthLabel.Margin = new Padding(3, 10, 3, 0);
            DateOfBirthLabel.Name = "DateOfBirthLabel";
            DateOfBirthLabel.Size = new Size(76, 15);
            DateOfBirthLabel.TabIndex = 4;
            DateOfBirthLabel.Text = "Date of Birth:";
            // 
            // PhoneNumberLabel
            // 
            PhoneNumberLabel.AutoSize = true;
            PhoneNumberLabel.Location = new Point(109, 116);
            PhoneNumberLabel.Margin = new Padding(3, 10, 3, 0);
            PhoneNumberLabel.Name = "PhoneNumberLabel";
            PhoneNumberLabel.Size = new Size(88, 15);
            PhoneNumberLabel.TabIndex = 3;
            PhoneNumberLabel.Text = "PhoneNumber:";
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new Point(109, 60);
            EmailLabel.Margin = new Padding(3, 10, 3, 0);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(44, 15);
            EmailLabel.TabIndex = 2;
            EmailLabel.Text = "E-mail:";
            // 
            // FullNameLabel
            // 
            FullNameLabel.AutoSize = true;
            FullNameLabel.Location = new Point(109, 6);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(64, 15);
            FullNameLabel.TabIndex = 1;
            FullNameLabel.Text = "Full Name:";
            // 
            // PhotoPictureBox
            // 
            PhotoPictureBox.Image = Properties.Resources.photo_placeholder_100x100;
            PhotoPictureBox.Location = new Point(3, 3);
            PhotoPictureBox.Name = "PhotoPictureBox";
            PhotoPictureBox.Size = new Size(100, 100);
            PhotoPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            PhotoPictureBox.TabIndex = 0;
            PhotoPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(MainTableLayoutPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "ContactsApp";
            KeyDown += MainForm_KeyDown;
            MainTableLayoutPanel.ResumeLayout(false);
            LeftPanel.ResumeLayout(false);
            LeftPanel.PerformLayout();
            ButtonsTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)RemoveContactButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)EditContactButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddContactButton).EndInit();
            RightPanel.ResumeLayout(false);
            RightPanel.PerformLayout();
            BirthdayPanel.ResumeLayout(false);
            BirthdayPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BirthdayPanelCloseButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)BirthdayPanelPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)PhotoPictureBox).EndInit();
            ResumeLayout(false);
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