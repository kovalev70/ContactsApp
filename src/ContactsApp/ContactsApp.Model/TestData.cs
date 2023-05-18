namespace ContactsApp.Model
{
    /// <summary>
    /// Класс с тестовыми данными.
    /// </summary>
    public static class TestData
    {
        /// <summary>
        /// Список полных имен.
        /// </summary>
        private static List<string> _fullNameList = new List<string>() { 
            "Ivan Ivanov", 
            "Petr Petrovich", 
            "Efim Efimov", 
            "Denis Denisov" };

        /// <summary>
        /// Список Email.
        /// </summary>
        private static List<string> _emailList = new List<string>() { 
            "IvanIvanov@mail.ru", 
            "PetrPetrovich@mail.ru", 
            "EfimEfimov@mail.ru", 
            "DenisDenisov@mail.ru" };

        /// <summary>
        /// Список номера телефонов.
        /// </summary>
        private static List<string> _phoneNumberList = new List<string>() { 
            "+79966361590", 
            "+79966221590", 
            "+79966361880", 
            "+79911361590" };

        /// <summary>
        /// Список ID Вконтакте.
        /// </summary>
        private static List<string> _vkIdList = new List<string>() { 
            "ivan2222", 
            "billy111", 
            "bestMan123", 
            "krutoeID" };

        /// <summary>
        /// Возвращает экземпляр класса Contact со случайными данными.
        /// </summary>
        /// <returns></returns>
        public static Contact AddContact()
        {
            DateTime start = new DateTime(1995, 1, 1);
            int range = (DateTime.Today - start).Days;
            Random rand = new Random();
            var randFullName = _fullNameList[rand.Next(_fullNameList.Count)];
            var randEmail = _emailList[rand.Next(_emailList.Count)];
            var randPhoneNumber = _phoneNumberList[rand.Next(_phoneNumberList.Count)];
            var randVkId = _vkIdList[rand.Next(_vkIdList.Count)];
            var randBirthDate = start.AddDays(rand.Next(range));
            Contact newContact = new Contact(randFullName, randEmail, randPhoneNumber, randBirthDate, randVkId);
            return newContact;
        }
    }
}
