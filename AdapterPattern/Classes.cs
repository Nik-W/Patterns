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
    class Adaptee
    {
        public string GetSpecificRequest()
        {
            return "Специфическая функциональность";
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
        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        /// <summary>
        /// Работа адаптера.
        /// </summary>
        public string GetRequest()
        {
            return $"Адаптер работает и использует '{_adaptee.GetSpecificRequest()}'";
        }
    }
}