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
        /// Выдает список контактов, в которых содержится передаваемся строка
        /// </summary>
        /// <param name="substring"></param>
        /// <returns></returns>
        public List<Contact> FindByNameAndSurname(string substring)
        {
            var sorted = SortingContacts();
            return sorted.Where(contact => contact.FullName.Contains(substring)
            || contact.FullName.Contains(substring)).ToList();
        }
    }
}
