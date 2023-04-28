namespace ContactsApp.View
{
    using ContactsApp.Model;
    public partial class ContactForm : Form
    {
        /// <summary>
        /// Экземпляр  <see cref="Contact">
        /// </summary>
        private Contact _contact = new Contact("FullName", "Mail@mail.ru", "+79966361510",  new DateTime(1995, 1, 1), "vkid");
        
        /// <summary>
        /// Строка ошибки полного имени.
        /// </summary>
        private string _fullNameError = "";

        /// <summary>
        /// Строка ошибки email.
        /// </summary>
        private string _emailError = "";

        /// <summary>
        /// Строка ошибки номера телефона.
        /// </summary>
        private string _phoneNumberError = "";

        /// <summary>
        /// Строка ошибки дня рождения.
        /// </summary>
        private string _dateOfBirthError = "";

        /// <summary>
        /// Строка ошибки Id Вконтакте.
        /// </summary>
        private string _vkIdError = "";

        /// <summary>
        /// Присваивает в TextBox'ы переменные класса Contact.
        /// </summary>
        private void UpdateForm()
        {
            FullNameTextBox.Text = _contact.FullName;
            EmailTextBox.Text = _contact.Email;
            PhoneNumberTextBox.Text = _contact.PhoneNumber;
            DateofBirthTimePicker.Value = _contact.BirthDate.Date;
            VKTextBox.Text = _contact.VkId;
        }

        /// <summary>
        /// Присваивает в класс Contact значения TextBox'ов.
        /// </summary>
        private void UpdateContact()
        {
            var contact = _contact;
            contact.FullName = FullNameTextBox.Text;
            contact.Email = EmailTextBox.Text;
            contact.PhoneNumber = PhoneNumberTextBox.Text;
            contact.BirthDate = DateofBirthTimePicker.Value;
            contact.VkId = VKTextBox.Text;
        }

        /// <summary>
        /// Проверяет правильность ввода данных.
        /// </summary>
        /// <returns></returns>
        private bool CheckFormOnErrors()
        {
            if (_fullNameError != "" || _emailError != "" || _phoneNumberError != "" || _dateOfBirthError != "" || _vkIdError !="")
            {
                string errorMessage = "";
                if (_fullNameError != "") errorMessage = errorMessage + "- " + _fullNameError + "\n";
                if (_emailError != "") errorMessage = errorMessage + "- " + _emailError + "\n";
                if (_phoneNumberError != "") errorMessage = errorMessage + "- " + _phoneNumberError + "\n";
                if (_dateOfBirthError != "") errorMessage = errorMessage + "- " + _dateOfBirthError + "\n";
                if (_vkIdError != "") errorMessage =errorMessage + "- " + _vkIdError + "\n";
                MessageBox.Show(errorMessage);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Конструктор формы.
        /// </summary>
        public ContactForm()
        {
            InitializeComponent();
            UpdateForm();
        }

        /// <summary>
        /// Изменение заднего фона кнопки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PhotoButton_MouseEnter(object sender, EventArgs e)
        {
            PhotoButton.Image = Properties.Resources.add_photo_32x32;
        }

        /// <summary>
        /// Изменение заднего фона кнопки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PhotoButton_MouseLeave(object sender, EventArgs e)
        {
            PhotoButton.Image = Properties.Resources.add_photo_32x32_gray;
        }

        /// <summary>
        /// Изменение заднего фона кнопки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OkButton_Click(object sender, EventArgs e)
        {
            bool result = CheckFormOnErrors();
            if (result)
            {
                UpdateContact();
                this.Close();
            }
        }

        /// <summary>
        /// Изменение заднего фона кнопки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Обработка ошибок FullNameTextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try 
            {
                _contact.FullName = FullNameTextBox.Text;
                _fullNameError = "";
                FullNameTextBox.BackColor = Color.White;
            }
            catch (ArgumentException exception)
            {
                FullNameTextBox.BackColor = Color.LightPink;
                _fullNameError = exception.Message;
            }
        }

        /// <summary>
        /// Обработка ошибок EmailTextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.Email = EmailTextBox.Text;
                _emailError = "";
                EmailTextBox.BackColor = Color.White;
            }
            catch (ArgumentException exception)
            {
                EmailTextBox.BackColor = Color.LightPink;
                _emailError = exception.Message;
            }
        }

        /// <summary>
        /// Обработка ошибок PhoneNumberTextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PhoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.PhoneNumber = PhoneNumberTextBox.Text;
                _phoneNumberError = "";
                PhoneNumberTextBox.BackColor = Color.White;
            }
            catch (ArgumentException exception)
            {
                PhoneNumberTextBox.BackColor = Color.LightPink;
                _phoneNumberError = exception.Message;
            }
        }

        /// <summary>
        /// Обработка ошибок DateofBirthTimePicker.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DateofBirthTimePicker_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.BirthDate = DateofBirthTimePicker.Value;
                _dateOfBirthError = "";
                DateofBirthTimePicker.BackColor = Color.White;
            }
            catch (ArgumentException exception)
            {
                DateofBirthTimePicker.BackColor = Color.LightPink;
                _dateOfBirthError = exception.Message;
            }
        }

        /// <summary>
        /// Обработка ошибок VKTextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VKTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.VkId = VKTextBox.Text;
                _vkIdError = "";
                VKTextBox.BackColor = Color.White;
            }
            catch (ArgumentException exception)
            {
                VKTextBox.BackColor = Color.LightPink;
                _vkIdError = exception.Message;
            }
        }
    }
}
