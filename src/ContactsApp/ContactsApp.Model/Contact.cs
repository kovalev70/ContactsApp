using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ContactsApp.Model
{
    /// <summary>
    /// Описывает контакт.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Полное имя контакта.
        /// </summary>
        private string _fullName;
        /// <summary>
        /// Электронная почта контакта.
        /// </summary>
        private string _email;
        /// <summary>
        /// Номер телефона контакта.
        /// </summary>
        private string _phoneNumber;
        /// <summary>
        /// День рождения контакта.
        /// </summary>
        private DateTime _birthDate;
        /// <summary>
        /// ID Вконтакте контакта.
        /// </summary>
        private string _vkId;

        /// <summary>
        /// Создает экземпляр <see cref="Contact">.
        /// </summary>
        /// <param name="fullName"></param>
        /// <param name="email"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="birthDate"></param>
        /// <param name="vkId"></param>
        public Contact(string fullName, string email, string phoneNumber, DateTime birthDate, string vkId)
        {
            FullName = fullName;
            Email = email;
            PhoneNumber = phoneNumber;
            BirthDate = birthDate;
            VkId = vkId;
        }
        /// <summary>
        /// Возвращает или задает полное имя контакта.
        /// </summary>
        public string FullName
        {
            get { return _fullName; }
            set
            {
                if (value.Length > 100)
                {
                    throw new ArgumentException("Full name must be no more than 100 characters long.");
                }
                _fullName = ToUpperFirst(value);
            }
        }
        /// <summary>
        /// Возвращает или задает электронную почту контакта.
        /// </summary>
        public string Email
        {
            get { return _email; }
            set
            {
                if (value.Length > 100)
                {
                    throw new ArgumentException("Email must be no more than 100 characters long.");
                }
                _email = value;
            }
        }
        /// <summary>
        /// Возвращает или задает номер телефона контакта.
        /// </summary>
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                if (!IsPhoneNumberValid(value))
                {
                    throw new ArgumentException("Invalid phone number.");
                }
                _phoneNumber = value;
            }
        }
        /// <summary>
        /// Возвращает или задает день рождения контакта.
        /// </summary>
        public DateTime BirthDate
        {
            get { return _birthDate; }
            set
            {
                if (value > DateTime.Now || value.Year < 1900)
                {
                    throw new ArgumentException("Invalid birth date.");
                }
                _birthDate = value;
            }
        }
        /// <summary>
        /// Возвращает или задает ID Вконтакте контакта.
        /// </summary>
        public string VkId
        {
            get { return _vkId; }
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException("VK ID must be no more than 50 characters long.");
                }
                _vkId = value;
            }
        }
        /// <summary>
        /// Возвращает строку, где первый символ каждого слова пишется с заглавной буквы.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private string ToUpperFirst(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(s.ToLower());
        }
        /// <summary>
        /// Проверяет правильность написания номера телефона.
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <returns></returns>
        private static bool IsPhoneNumberValid(string phoneNumber)
        {
            string pattern = @"^((8|\+7)[\- ]?)?(\(?\d{3}\)?[\- ]?)?[\d\- ]{7,10}$";
            return Regex.IsMatch(phoneNumber, pattern);
        }
    }
}
