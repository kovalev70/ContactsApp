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
    }
}
