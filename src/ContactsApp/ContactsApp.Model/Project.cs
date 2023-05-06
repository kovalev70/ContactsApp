namespace ContactsApp.Model
{
    /// <summary>
    /// Класс проекта.
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Список контактов.
        /// </summary>
        private List<Contact> _contacts = new List<Contact>();
        /// <summary>
        /// Добаввляет контакт в список.
        /// </summary>
        /// <param name="contact"></param>
        public void AddContact(Contact contact)
        {
            _contacts.Add(contact);
        }
        /// <summary>
        /// Удалаяет контакт из списка.
        /// </summary>
        /// <param name="contact"></param>
        public void RemoveContact(Contact contact)
        {
            _contacts.Remove(contact);
        }
        /// <summary>
        /// Возвращает список контактов.
        /// </summary>
        /// <returns></returns>
        public List<Contact> GetAllContacts()
        {
            return _contacts;
        }

        /// <summary>
        /// Выдает список контактов, в которых содержится передаваемся строка
        /// </summary>
        /// <param name="substring"></param>
        /// <returns></returns>
        public List<Contact> SortingContacts()
        {
            return _contacts.OrderBy(Contact => Contact.FullName).ToList();
        }

        /// <summary>
        /// Выдает список контактов, в которых содержится передаваемся строка
        /// </summary>
        /// <param name="substring"></param>
        /// <returns></returns>
        public List<Contact> FindByNameAndSurname(string substring)
        {
            var sorted = SortingContacts();
            return sorted.Where(Сontact => Сontact.FullName.Contains(substring)).ToList();
        }
    }
}
