using System;

namespace DecoratorPattern
{
    /// <summary>
    /// Интерфейс компонента.
    /// </summary>
    interface IComponent
    {
        void Operation();
    }

    /// <summary>
    /// Конкретный компонент.
    /// </summary>
    class ConcreteComponent : IComponent
    {
        /// <summary>
        /// Базовая логика.
        /// </summary>
        public void Operation()
        {
            Console.WriteLine("Поведение по умолчанию.");
        }
    }
}