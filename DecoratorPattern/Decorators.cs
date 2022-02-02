using System;

namespace DecoratorPattern
{
    /// <summary>
    /// Декоратор.
    /// </summary>
    abstract class Decorator : IComponent
    {
        /// <summary>
        /// Компонент.
        /// </summary>
        protected IComponent _component;

        /// <summary>
        /// Декоратор для компонента.
        /// </summary>
        public Decorator(IComponent component)
        {
            _component = component;
        }

        /// <summary>
        /// Отправить сообщение.
        /// </summary>
        public abstract void SendMessage();
    }

    /// <summary>
    /// Декоратор А.
    /// </summary>
    class TelegramСhat : Decorator
    {
        public TelegramСhat(IComponent component) : base(component) { }

        /// <summary>
        /// Логика.
        /// </summary>
        public override void SendMessage()
        {
            _component.SendMessage();
            Console.WriteLine("Отправка сообщения в Telegram.");
        }
    }

    /// <summary>
    /// Декоратор В.
    /// </summary>
    class WhatsAppChat : Decorator
    {
        public WhatsAppChat(IComponent component) : base(component) { }

        /// <summary>
        /// Логика.
        /// </summary>
        public override void SendMessage()
        {
            _component.SendMessage();
            Console.WriteLine("Отправка сообщения в WhatsApp.");
        }
    }
}