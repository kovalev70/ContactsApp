namespace ContactsApp.View
{
    using ContactsApp.Model;
    public partial class MainForm : Form
    {
        /// <summary>
        /// Экземпляр класса Project.
        /// </summary>
        private Project _project = new Project();

        /// <summary>
        /// 
        /// </summary>
        private List<ContactsData> _contactsData = new List<ContactsData>();

        /// <summary>
        /// Вспомогательный список для поиска
        /// </summary>
        private List<Contact> _contacts;

        /// <summary>
        /// Конструктор формы.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            UpdateListBox();
            FillListBoxByTestData();
            UpdateListBox();
        }

        /// <summary>
        /// Выполняет сортировку контактов по алфавиту
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
        /// Очищает поля textBox
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
        /// Заполняет ListBox тестовыми контактами.
        /// </summary>
        /// <param name="dataCount"></param>
        private void FillListBoxByTestData(int dataCount = 3)
        {
            for (int i = 0; i < dataCount; i++)
            {
                Contact testContact = TestData.AddContact();
                var data = new ContactsData()
                {
                    Contact = testContact
                };
                _contactsData.Add(data);
                _project.AddContact(testContact);
                ContactsListBox.Items.Add(_contacts);

            }
        }

        /// <summary>
        /// Обновляет ListBox.
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
        /// Удаление контакта
        /// </summary>
        /// <param name="index"></param>
        private void RemoveContact(int index)
        {
            _project.RemoveContact(_contacts[index]);
        }

        /// <summary>
        /// Обновление выбранного контакта.
        /// </summary>
        /// <param name="index"></param>
        private void UpdateSelectedContact(int index)
        {
            Contact AllContacts = _project.GetAllContacts()[index];
            FullNameTextBox.Text = AllContacts.FullName;
            EmailTextBox.Text = AllContacts.Email;
            PhoneNumberTextBox.Text = AllContacts.PhoneNumber;
            DateOfBirthTextBox.Text = AllContacts.BirthDate.Date.ToString("yyyy/MM/dd");
            VKTextBox.Text = AllContacts.VkId;
        }

        /// <summary>
        /// Вызов формы ContactForm.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddContactButton_Click(object sender, EventArgs e)
        {
            var form = new ContactForm();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                var updatedData = form.ContactsData;
                _project.AddContact(updatedData.Contact);
                _contactsData.Add(updatedData);
                ContactsListBox.Items.Add(updatedData.Contact.FullName);
                var selectedIndex = ContactsListBox.SelectedIndex;
                FullNameTextBox.Text = updatedData.Contact.FullName;
                PhoneNumberTextBox.Text = updatedData.Contact.PhoneNumber;
                EmailTextBox.Text = updatedData.Contact.Email;
                DateOfBirthTextBox.Text = updatedData.Contact.BirthDate.ToString("yyyy/MM/dd");
                VKTextBox.Text = updatedData.Contact.VkId;
                UpdateListBox();
            }
        }

        /// <summary>
        /// Очищает выбранный контакт.
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
        /// Обработка наведения мышки на клавишу.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddContactButton_MouseEnter(object sender, EventArgs e)
        {
            AddContactButton.Image = Properties.Resources.add_contact_32x32;
            AddContactButton.BackColor = ColorTranslator.FromHtml("#F5F5F5");
        }

        /// <summary>
        /// Обработка убирания мышки с клавиши.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddContactButton_MouseLeave(object sender, EventArgs e)
        {
            AddContactButton.Image = Properties.Resources.add_contact_32x32_gray;
            AddContactButton.BackColor = Color.White;
        }

        /// <summary>
        /// Обработка наведения мышки на клавишу.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditContactButton_MouseEnter(object sender, EventArgs e)
        {
            EditContactButton.Image = Properties.Resources.edit_contact_32x32;
            EditContactButton.BackColor = ColorTranslator.FromHtml("#F5F5F5");
        }

        /// <summary>
        /// Обработка убирания мышки с клавиши.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditContactButton_MouseLeave(object sender, EventArgs e)
        {
            EditContactButton.Image = Properties.Resources.edit_contact_32x32_gray;
            EditContactButton.BackColor = Color.White;
        }

        /// <summary>
        /// Обработка наведения мышки на клавишу.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveContactButton_MouseEnter(object sender, EventArgs e)
        {
            RemoveContactButton.Image = Properties.Resources.remove_contact_32x32;
            RemoveContactButton.BackColor = ColorTranslator.FromHtml("#FAF5F5");
        }

        /// <summary>
        /// Обработка убирания мышки с клавиши.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveContactButton_MouseLeave(object sender, EventArgs e)
        {
            RemoveContactButton.Image = Properties.Resources.remove_contact_32x32_gray;
            RemoveContactButton.BackColor = Color.White;
        }

        /// <summary>
        /// Обработка нажатия на текстбоксе.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FullNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// Обработка нажатия на текстбоксе.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmailTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// Обработка нажатия на текстбоксе.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PhoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// Обработка нажатия на текстбоксе.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DateOfBirthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// Обработка нажатия на текстбоксе.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VKTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// Закрытие панели дня рождения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BirthdayPanelCloseButton_Click(object sender, EventArgs e)
        {
            BirthdayPanel.Visible = false;
        }

        /// <summary>
        /// Обработка нажатия f1.
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

        /// <summary>
        /// Обработка нажатия кнопки RemoveContactButton.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveContactButton_Click(object sender, EventArgs e)
        {
            if (ContactsListBox.SelectedIndex == -1) return;
            else 
            {
                DialogResult result = MessageBox.Show(
                    "Do you really want to remove " + _project.GetAllContacts()[ContactsListBox.SelectedIndex].FullName + "?",
                    "Message",
                    MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    RemoveContact(ContactsListBox.SelectedIndex);
                    ClearRightPanel();
                    UpdateListBox();
                }
            }
        }

        /// <summary>
        /// Обработка вывода данных.
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
        /// Вызов MessageBox при закрытии формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show("Close the ContactsApp?", "Message", MessageBoxButtons.YesNo) == DialogResult.No;
        }
        /// <summary>
        /// Вызов окна редактирования контакта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditContactButton_Click(object sender, EventArgs e)
        {
            var selectedIndex = ContactsListBox.SelectedIndex;
            if (selectedIndex != -1)
            {
                var selectedData = _contactsData[selectedIndex];
                var form = new ContactForm();
                form.ContactsData = selectedData;
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                {
                    var updatedData = form.ContactsData;
                    ContactsListBox.Items.RemoveAt(selectedIndex);
                    _contactsData.RemoveAt(selectedIndex);
                    _contactsData.Insert(selectedIndex, updatedData);
                    _project.GetAllContacts()[selectedIndex] = updatedData.Contact;
                    ContactsListBox.Items.Add(updatedData.Contact.FullName);
                    FullNameTextBox.Text = updatedData.Contact.FullName;
                    PhoneNumberTextBox.Text = updatedData.Contact.PhoneNumber;
                    EmailTextBox.Text = updatedData.Contact.Email;
                    DateOfBirthTextBox.Text = updatedData.Contact.BirthDate.ToString("yyyy/MM/dd");
                    VKTextBox.Text = updatedData.Contact.VkId;
                    _contactsData[selectedIndex] = updatedData;
                    UpdateListBox();
                }
            }
        }
    }
}