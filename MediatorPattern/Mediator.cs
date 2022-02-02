using System;

namespace MediatorPattern
{
    /// <summary>
    /// Интерфейс уведомления посредника о событиях.
    /// </summary>
    public interface IMediator
    {
        /// <summary>
        /// Уведомление.
        /// </summary>
        void Notify(object sender, string ev);
    }

    /// <summary>
    /// Конкретный Посредник, координирующий компоненты.
    /// </summary>
    class ConcreteMediator : IMediator
    {
        /// <summary>
        /// Contact.
        /// </summary>
        private Contact _contact;

        /// <summary>
        /// Account.
        /// </summary>
        private Account _account;

        /// <summary>
        /// Создание экземпляра Посредника.
        /// </summary>
        public ConcreteMediator(Contact contact, Account account)
        {
            this._contact = contact;
            this._contact.SetMediator(this);
            this._account = account;
            this._account.SetMediator(this);
        }

        /// <inheritdoc />
        public void Notify(object sender, string ev)
        {
            switch (ev)
            {
                case "A":
                    Console.WriteLine("Посредник среагировал на A:");
                    _account.DoC();
                    break;
                case "D":
                    Console.WriteLine("Посредник среагировал на D:");
                    _contact.DoB();
                    _account.DoC();
                    break;
            }
        }
    }
}