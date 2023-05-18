namespace ContactsApp.View
{
    using ContactsApp.Model;
    using System.Collections.Generic;

    public partial class ContactForm : Form
    {
        /// <summary>
        /// Экземпляр  <see cref="Contact">
        /// </summary>
        private Contact _contact = new Contact();

        /// <summary>
        /// Поле содержащее бэкап копию контакта.
        /// </summary>
        private Contact _contactClone = new Contact();

        /// <summary>
        /// Словарь с ошибками.
        /// </summary>
        private Dictionary<string, string> _errors = new Dictionary<string, string>()
        {
            {"fullNameError", "" },
            {"emailError", "" },
            {"phoneNumberError", "" },
            {"dateOfBirthError", "" },
            {"vkIdError", "" }
        };


        /// <summary>
        /// Цвет верно введенного поля.
        /// </summary>
        private readonly Color _rightValueColor = Color.White;

        /// <summary>
        /// Цвет неверно введенного поля.
        /// </summary>
        private readonly Color _wrongValueColor = Color.LightPink;

        /// <summary>
        /// Свойство ContactsData.
        /// </summary>
        public Contact Contact
        {
            get { return _contact; }
            set 
            {
                _contact = value;
                UpdateForm();
                _contactClone = (Contact)_contact.Clone();
            }
        }
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
            var contact = _contactClone;
            contact.FullName = FullNameTextBox.Text;
            contact.Email = EmailTextBox.Text;
            contact.PhoneNumber = PhoneNumberTextBox.Text;
            contact.BirthDate = DateofBirthTimePicker.Value;
            contact.VkId = VKTextBox.Text;
            _contact = contact;
        }

        /// <summary>
        /// Проверяет правильность ввода данных и выводит MessageBox.
        /// </summary>
        /// <returns></returns>
        private bool CheckFormOnErrors()
        {
            string errorMessage = "";
            foreach (var error in _errors)
            {
                if (error.Value != "")
                {
                    errorMessage = errorMessage + "- " + error.Value + "\n";
                }
            }
            if (errorMessage != "")
            {
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
                this.DialogResult = DialogResult.OK;
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
                _contactClone.FullName = FullNameTextBox.Text;
                _errors["fullNameError"] = "";
                FullNameTextBox.BackColor = _rightValueColor;
            }
            catch (ArgumentException exception)
            {
                FullNameTextBox.BackColor = _wrongValueColor;
                _errors["fullNameError"] = exception.Message;
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
                _contactClone.Email = EmailTextBox.Text;
                _errors["emailError"] = "";
                EmailTextBox.BackColor = _rightValueColor;
            }
            catch (ArgumentException exception)
            {
                EmailTextBox.BackColor = _wrongValueColor;
                _errors["emailError"] = exception.Message;
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
                _contactClone.PhoneNumber = PhoneNumberTextBox.Text;
                _errors["phoneNumberError"] = "";
                PhoneNumberTextBox.BackColor = _rightValueColor;
            }
            catch (ArgumentException exception)
            {
                PhoneNumberTextBox.BackColor = _wrongValueColor;
                _errors["phoneNumberError"] = exception.Message;
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
                _contactClone.BirthDate = DateofBirthTimePicker.Value;
                _errors["dateOfBirthError"] = "";
                DateofBirthTimePicker.BackColor = _rightValueColor;
            }
            catch (ArgumentException exception)
            {
                DateofBirthTimePicker.BackColor = _wrongValueColor;
                _errors["dateOfBirthError"] = exception.Message;
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
                _contactClone.VkId = VKTextBox.Text;
                _errors["vkIdError"] = "";
                VKTextBox.BackColor = _rightValueColor;
            }
            catch (ArgumentException exception)
            {
                VKTextBox.BackColor = _wrongValueColor;
                _errors["vkIdErrorError"] = exception.Message;
            }
        }
    }
}
