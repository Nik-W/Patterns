using System;

namespace MediatorPattern
{
    /// <summary>
    /// Базовый Компонент
    /// </summary>
    class BaseEntity
    {
        /// <summary>
        /// Посредник.
        /// </summary>
        protected IMediator _mediator;

        /// <summary>
        /// Создание экземпляра компонента.
        /// </summary>
        public BaseEntity(IMediator mediator = null)
        {
            this._mediator = mediator;
        }

        /// <summary>
        /// Установка Посредника компоненту.
        /// </summary>
        public void SetMediator(IMediator mediator)
        {
            _mediator = mediator;
        }
    }

    /// <summary>
    /// Contact.
    /// </summary>
    class Contact : BaseEntity
    {
        /// <summary>
        /// Функциональность А.
        /// </summary>
        public void DoA()
        {
            Console.WriteLine("Функциональность A Contact.");
            _mediator.Notify(this, "A");
        }

        /// <summary>
        /// Функциональность B.
        /// </summary>
        public void DoB()
        {
            Console.WriteLine("Функциональность B Contact.");
            _mediator.Notify(this, "B");
        }
    }

    /// <summary>
    /// Account.
    /// </summary>
    class Account : BaseEntity
    {
        /// <summary>
        /// Функциональность C.
        /// </summary>
        public void DoC()
        {
            Console.WriteLine("Функциональность C Account.");
            _mediator.Notify(this, "C");
        }

        /// <summary>
        /// Функциональность D.
        /// </summary>
        public void DoD()
        {
            Console.WriteLine("Функциональность D Account.");
            _mediator.Notify(this, "D");
        }
    }
}