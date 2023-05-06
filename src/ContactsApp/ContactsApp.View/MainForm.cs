namespace ContactsApp.View
{
    using ContactsApp.Model;
    public partial class MainForm : Form
    {
        /// <summary>
        /// ��������� ������ Project.
        /// </summary>
        private Project _project = new Project();

        /// <summary>
        /// ��������������� ������ ��� ������
        /// </summary>
        private List<Contact> _contacts;

        /// <summary>
        /// ����������� �����.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            UpdateListBox();
            FillListBoxByTestData();
            UpdateListBox();
        }

        /// <summary>
        /// ��������� ���������� ��������� �� ��������
        /// </summary>
        private void ContactSort()
        {
            if (FindTextBox.Text.Length == 0)
            {
                _contacts = _project.SortingContacts();
            }
            else if (FindTextBox.Text.Length != 0)
            {
                _contacts = _project.FindByNameAndSurname(FindTextBox.Text);
            }
        }

        /// <summary>
        /// ������� ���� textBox
        /// </summary>
        private void ClearRightPanel()
        {
            FullNameTextBox.Clear();
            DateOfBirthTextBox.Clear();
            PhoneNumberTextBox.Clear();
            EmailTextBox.Clear();
            VKTextBox.Clear();
        }

        /// <summary>
        /// ��������� ListBox ��������� ����������.
        /// </summary>
        /// <param name="dataCount"></param>
        private void FillListBoxByTestData(int dataCount = 3)
        {
            for (int i = 0; i < dataCount; i++)
            {
                Contact testContact = TestData.AddContact();
                _project.AddContact(testContact);
                ContactsListBox.Items.Add(_project);

            }
        }
        /// <summary>
        /// ��������� ������� ������ RemoveContactButton.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveContactButton_Click(object sender, EventArgs e)
        {
            var index = ContactsListBox.SelectedIndex;
            var contact = _project.GetAllContacts()[index];
            if (index == -1) return;
            DialogResult result = MessageBox.Show(
                "Do you really want to remove " + contact.FullName + "?",
                "Message",
                MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                RemoveContact(index);
                ClearRightPanel();
                UpdateListBox();
            }
        }

        /// <summary>
        /// ��������� ������ ������.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContactsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ContactsListBox.SelectedIndex == -1)
            {
                ClearSelectedContact();
            }
            else UpdateSelectedContact(ContactsListBox.SelectedIndex);
        }

        /// <summary>
        /// ����� MessageBox ��� �������� �����.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show("Close the ContactsApp?", 
                "Message", 
                MessageBoxButtons.YesNo) == DialogResult.No;
        }
        /// <summary>
        /// ����� ���� �������������� ��������.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditContactButton_Click(object sender, EventArgs e)
        {
            var selectedIndex = ContactsListBox.SelectedIndex;
            if (selectedIndex != -1)
            {
                var selectedData = _project.GetAllContacts()[selectedIndex];
                var form = new ContactForm();
                form.Contact = selectedData;
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                {
                    var updatedData = form.Contact;
                    ContactsListBox.Items.RemoveAt(selectedIndex);
                    _project.GetAllContacts()[selectedIndex] = updatedData;
                    ContactsListBox.Items.Add(updatedData.FullName);
                    FullNameTextBox.Text = updatedData.FullName;
                    PhoneNumberTextBox.Text = updatedData.PhoneNumber;
                    EmailTextBox.Text = updatedData.Email;
                    DateOfBirthTextBox.Text = updatedData.BirthDate.ToString("yyyy/MM/dd");
                    VKTextBox.Text = updatedData.VkId;
                    UpdateListBox();
                }
            }
        }

        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            ContactSort();
            UpdateListBox();
        }
        /// <summary>
        /// ��������� ListBox.
        /// </summary>
        private void UpdateListBox()
        {
            ContactSort();
            ContactsListBox.Items.Clear();
            foreach (var contact in _contacts)
            {
                ContactsListBox.Items.Add(contact.FullName);
            }
        }

        /// <summary>
        /// �������� ��������
        /// </summary>
        /// <param name="index"></param>
        private void RemoveContact(int index)
        {
            _project.RemoveContact(_contacts[index]);
        }

        /// <summary>
        /// ���������� ���������� ��������.
        /// </summary>
        /// <param name="index"></param>
        private void UpdateSelectedContact(int index)
        {
            Contact AllContacts = _contacts[index];
            FullNameTextBox.Text = AllContacts.FullName;
            EmailTextBox.Text = AllContacts.Email;
            PhoneNumberTextBox.Text = AllContacts.PhoneNumber;
            DateOfBirthTextBox.Text = AllContacts.BirthDate.Date.ToString("yyyy/MM/dd");
            VKTextBox.Text = AllContacts.VkId;
        }

        /// <summary>
        /// ����� ����� ContactForm.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddContactButton_Click(object sender, EventArgs e)
        {
            var form = new ContactForm();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                var updatedData = form.Contact;
                _project.AddContact(updatedData);
                ContactsListBox.Items.Add(updatedData.FullName);
                var selectedIndex = ContactsListBox.SelectedIndex;
                FullNameTextBox.Text = updatedData.FullName;
                PhoneNumberTextBox.Text = updatedData.PhoneNumber;
                EmailTextBox.Text = updatedData.Email;
                DateOfBirthTextBox.Text = updatedData.BirthDate.ToString("yyyy/MM/dd");
                VKTextBox.Text = updatedData.VkId;
                UpdateListBox();
            }
        }

        /// <summary>
        /// ������� ��������� �������.
        /// </summary>
        private void ClearSelectedContact()
        {
            FullNameTextBox.Text = string.Empty;
            EmailTextBox.Text = string.Empty;
            PhoneNumberTextBox.Text = string.Empty;
            DateOfBirthTextBox.Text = string.Empty;
            VKTextBox.Text = string.Empty;
        }

        /// <summary>
        /// ��������� ��������� ����� �� �������.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddContactButton_MouseEnter(object sender, EventArgs e)
        {
            AddContactButton.Image = Properties.Resources.add_contact_32x32;
            AddContactButton.BackColor = ColorTranslator.FromHtml("#F5F5F5");
        }

        /// <summary>
        /// ��������� �������� ����� � �������.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddContactButton_MouseLeave(object sender, EventArgs e)
        {
            AddContactButton.Image = Properties.Resources.add_contact_32x32_gray;
            AddContactButton.BackColor = Color.White;
        }

        /// <summary>
        /// ��������� ��������� ����� �� �������.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditContactButton_MouseEnter(object sender, EventArgs e)
        {
            EditContactButton.Image = Properties.Resources.edit_contact_32x32;
            EditContactButton.BackColor = ColorTranslator.FromHtml("#F5F5F5");
        }

        /// <summary>
        /// ��������� �������� ����� � �������.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditContactButton_MouseLeave(object sender, EventArgs e)
        {
            EditContactButton.Image = Properties.Resources.edit_contact_32x32_gray;
            EditContactButton.BackColor = Color.White;
        }

        /// <summary>
        /// ��������� ��������� ����� �� �������.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveContactButton_MouseEnter(object sender, EventArgs e)
        {
            RemoveContactButton.Image = Properties.Resources.remove_contact_32x32;
            RemoveContactButton.BackColor = ColorTranslator.FromHtml("#FAF5F5");
        }

        /// <summary>
        /// ��������� �������� ����� � �������.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveContactButton_MouseLeave(object sender, EventArgs e)
        {
            RemoveContactButton.Image = Properties.Resources.remove_contact_32x32_gray;
            RemoveContactButton.BackColor = Color.White;
        }

        /// <summary>
        /// ��������� ������� �� ����������.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FullNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// ��������� ������� �� ����������.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmailTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// ��������� ������� �� ����������.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PhoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// ��������� ������� �� ����������.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DateOfBirthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// ��������� ������� �� ����������.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VKTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// �������� ������ ��� ��������.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BirthdayPanelCloseButton_Click(object sender, EventArgs e)
        {
            BirthdayPanel.Visible = false;
        }

        /// <summary>
        /// ��������� ������� f1.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                var form = new AboutForm();
                form.ShowDialog();
            }
        }
    }
}