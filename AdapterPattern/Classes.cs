namespace AdapterPattern
{
    /// <summary>
    /// Интерфейс по которому работает адаптер.
    /// </summary>
    public interface ITarget
    {
        /// <summary>
        /// Работа адаптера.
        /// </summary>
        string GetRequest();
    }

    /// <summary>
    /// Изначальный класс, к которому нужно применить Адаптер.
    /// </summary>
    class ContactAdaptee
    {
        public string GetSpecificRequest()
        {
            return "Функцональность Контакта";
        }
    }

    /// <summary>
    /// Адаптер.
    /// </summary>
    class Adapter : ITarget
    {
        /// <summary>
        /// Адаптируемый класс.
        /// </summary>
        private readonly ContactAdaptee _contactAdaptee;

        public Adapter(ContactAdaptee contactAdaptee)
        {
            _contactAdaptee = contactAdaptee;
        }

        /// <summary>
        /// Работа адаптера.
        /// </summary>
        public string GetRequest()
        {
            return $"Адаптер работает и использует '{_contactAdaptee.GetSpecificRequest()}'";
        }
    }
}