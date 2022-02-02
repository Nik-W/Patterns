using System;

namespace DecoratorPattern
{
    /// <summary>
    /// Интерфейс компонента.
    /// </summary>
    interface IComponent
    {
        void SendMessage();
    }

    /// <summary>
    /// Чат.
    /// </summary>
    class Chat : IComponent
    {
        /// <summary>
        /// Отправить сообщение.
        /// </summary>
        public void SendMessage()
        {
            Console.WriteLine("Отправка сообщения.");
        }
    }
}