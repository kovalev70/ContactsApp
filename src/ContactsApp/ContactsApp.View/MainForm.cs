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
        /// Конструктор формы.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Обновляет ListBox.
        /// </summary>
        private void UpdateListBox()
        {
            ContactsListBox.Items.Clear();
            foreach (var contact in _project.GetAllContacts())
            {
                ContactsListBox.Items.Add(contact.FullName);
            }
        }

        /// <summary>
        /// Добавляет новый Contact со случайными данными.
        /// </summary>
        private void AddContact()
        {
            var fullNameList = new List<string>()  { "Ivan Ivanov", "Petr Petrovich", "Efim Efimov", "Denis Denisov" };
            var emailList = new List<string>() { "IvanIvanov@mail.ru", "PetrPetrovich@mail.ru", "EfimEfimov@mail.ru", "DenisDenisov@mail.ru" };
            var phoneNumberList = new List<string>() { "+79966361590", "+79966221590", "+79966361880", "+79911361590" };
            var vkIdList = new List<string>() { "+ivan2222", "billy111", "bestMan123", "Nagibator666" };
            DateTime start = new DateTime(1995, 1, 1);
            int range = (DateTime.Today - start).Days;
            Random rand = new Random();
            var randFullName = fullNameList[rand.Next(fullNameList.Count)];
            var randEmail = emailList[rand.Next(emailList.Count)];
            var randPhoneNumber = phoneNumberList[rand.Next(phoneNumberList.Count)];
            var randVkId = vkIdList[rand.Next(vkIdList.Count)];
            var randBirthDate = start.AddDays(rand.Next(range));
            Contact newContact = new Contact(randFullName, randEmail, randPhoneNumber, randBirthDate, randVkId);
            _project.AddContact(newContact);
        }

        /// <summary>
        /// Удаление контакта
        /// </summary>
        /// <param name="index"></param>
        private void RemoveContact(int index)
        {
            _project.RemoveContact(_project.GetAllContacts()[index]);
        }

        /// <summary>
        /// Обновление выбранного контакта.
        /// </summary>
        /// <param name="index"></param>
        private void UpdateSelectedContact(int index)
        {
            FullNameTextBox.Text = _project.GetAllContacts()[index].FullName;
            EmailTextBox.Text = _project.GetAllContacts()[index].Email;
            PhoneNumberTextBox.Text = _project.GetAllContacts()[index].PhoneNumber;
            DateOfBirthTextBox.Text = _project.GetAllContacts()[index].BirthDate.Date.ToString("dd/MM/yyyy");
            VKTextBox.Text = _project.GetAllContacts()[index].VkId;
        }

        /// <summary>
        /// Вызов формы ContactForm.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddContactButton_Click(object sender, EventArgs e)
        {
            //AddContact();
            //UpdateListBox();
            var form = new ContactForm();
            form.ShowDialog();
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
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddContactButton_MouseEnter(object sender, EventArgs e)
        {
            AddContactButton.Image = Properties.Resources.add_contact_32x32;
            AddContactButton.BackColor = ColorTranslator.FromHtml("#F5F5F5");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddContactButton_MouseLeave(object sender, EventArgs e)
        {
            AddContactButton.Image = Properties.Resources.add_contact_32x32_gray;
            AddContactButton.BackColor = Color.White;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditContactButton_MouseEnter(object sender, EventArgs e)
        {
            EditContactButton.Image = Properties.Resources.edit_contact_32x32;
            EditContactButton.BackColor = ColorTranslator.FromHtml("#F5F5F5");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditContactButton_MouseLeave(object sender, EventArgs e)
        {
            EditContactButton.Image = Properties.Resources.edit_contact_32x32_gray;
            EditContactButton.BackColor = Color.White;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveContactButton_MouseEnter(object sender, EventArgs e)
        {
            RemoveContactButton.Image = Properties.Resources.remove_contact_32x32;
            RemoveContactButton.BackColor = ColorTranslator.FromHtml("#FAF5F5");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveContactButton_MouseLeave(object sender, EventArgs e)
        {
            RemoveContactButton.Image = Properties.Resources.remove_contact_32x32_gray;
            RemoveContactButton.BackColor = Color.White;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FullNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmailTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PhoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DateOfBirthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VKTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BirthdayPanelCloseButton_Click(object sender, EventArgs e)
        {
            BirthdayPanel.Visible = false;
        }

        /// <summary>
        /// 
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
    }
}