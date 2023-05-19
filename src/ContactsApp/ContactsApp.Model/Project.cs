namespace ContactsApp.Model
{
    /// <summary>
    /// Класс проекта.
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Содержит информацию о всех <see cref="Contacts"/>
        /// </summary>
        public List<Contact> Contacts { get; set; } = new List<Contact>();

        /// <summary>
        /// Сортирует список контактов по полному имени в алфавитном порядке
        /// </summary>
        /// <returns>
        /// Сортированный список
        /// </returns>
        public List<Contact> SortingContacts()
        {
            return Contacts.OrderBy(contact => contact.FullName).ToList();
        }

        /// <summary>
        /// Выполняет поиск именинников на указанную дату
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public List<Contact> FindBirthdayContacts(DateTime date)
        {
            return Contacts.Where(contact => contact.BirthDate.Day == date.Day
            && contact.BirthDate.Month == date.Month).ToList();
        }


        /// <summary>
        /// Выдает список контактов, в которых содержится передающаяся строка
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <returns></returns>
        public List<Contact> FindContacts(string str)
        {
            DateTime date;
            try
            {
                date = DateTime.Parse(str);
            }
            catch (FormatException)
            {
                date = default;
            }

            var sorted = SortingContacts();
            return sorted.Where(contact => 
            contact.PhoneNumber.Contains(str) 
            || contact.FullName.Contains(str)
            || contact.Email.Contains(str)
            || contact.VkId.Contains(str)
            || contact.FullName.Contains(str)
            || (contact.BirthDate.Day == date.Day 
            && contact.BirthDate.Month == date.Month 
            && date.Year != DateTime.MinValue.Year)).ToList();
        }
    }
}
