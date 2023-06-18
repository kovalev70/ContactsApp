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
        /// Вспомогательный список для поиска
        /// </summary>
        private List<Contact> _contacts;

        /// <summary>
        /// Конструктор формы.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            try
            {
                _project = ProjectSerializer.LoadFromFile(ProjectSerializer.Filename);
            }
            catch (AccessViolationException exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK);
                _project = new Project();
            }
            var birthdayContacts = _project.FindBirthdayContacts(DateTime.Now);
            if (birthdayContacts.Count != 0)
            {
                BirthdaySurnamesLabel.Text += string.Join(", ", birthdayContacts.
                    Select(contact => contact.FullName));
            }
            else
            {
                BirthdayPanel.Visible = false;
            }
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
                _contacts = _project.FindContacts(FindTextBox.Text);
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
        /// Обработка нажатия кнопки RemoveContactButton.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveContactButton_Click(object sender, EventArgs e)
        {
            var index = ContactsListBox.SelectedIndex;
            if (index == -1) return;
            var contact = _project.Contacts[index];
            DialogResult result = MessageBox.Show(
                "Do you really want to remove " + contact.FullName + "?",
                "Message",
                MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                var selectedContact = _contacts[index];
                _project.Contacts.Remove(selectedContact);
                ProjectSerializer.SaveToFile(_project, ProjectSerializer.Filename);
                ClearRightPanel();
                UpdateListBox();
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
            else ChangeTextBox(_contacts[ContactsListBox.SelectedIndex]);
        }

        /// <summary>
        /// Вызов MessageBox при закрытии формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProjectSerializer.SaveToFile(_project, ProjectSerializer.Filename);
            e.Cancel = MessageBox.Show("Close the ContactsApp?", 
                "Message", 
                MessageBoxButtons.YesNo) == DialogResult.No;
        }

        /// <summary>
        /// Обновляет поля TextBox на новые значения
        /// </summary>
        /// <param name="contact"></param>
        private void ChangeTextBox(Contact contact)
        {
            FullNameTextBox.Text = contact.FullName;
            PhoneNumberTextBox.Text = contact.PhoneNumber;
            EmailTextBox.Text = contact.Email;
            DateOfBirthTextBox.Text = contact.BirthDate.ToString("yyyy/MM/dd");
            VKTextBox.Text = contact.VkId;
        }

        /// <summary>
        /// Вызов окна редактирования контакта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditContactButton_Click(object sender, EventArgs e)
        {
            var selectedIndex = ContactsListBox.SelectedIndex;
            if (selectedIndex == -1) return;
            var selectedContact = _contacts[selectedIndex];
            var form = new ContactForm();
            form.Contact = selectedContact;
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                var editContact = form.Contact;
                _project.Contacts.Remove(selectedContact);
                _project.Contacts.Add(editContact);
                ProjectSerializer.SaveToFile(_project, ProjectSerializer.Filename);
                ChangeTextBox(editContact);
                UpdateListBox();
                ContactsListBox.SelectedIndex = _contacts.IndexOf(editContact);
            }
        }

        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            ContactSort();
            UpdateListBox();
            ClearRightPanel();
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
                var newContact = form.Contact;
                _project.Contacts.Add(newContact);
                ProjectSerializer.SaveToFile(_project, ProjectSerializer.Filename);
                UpdateListBox();
                ChangeTextBox(newContact);
                ContactsListBox.SelectedIndex = _contacts.IndexOf(newContact);
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
    }
}