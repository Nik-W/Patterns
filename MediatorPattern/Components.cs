using System;

namespace MediatorPattern
{
    /// <summary>
    /// Базовый Компонент
    /// </summary>
    class BaseComponent
    {
        /// <summary>
        /// Посредник.
        /// </summary>
        protected IMediator _mediator;

        /// <summary>
        /// Создание экземпляра компонента.
        /// </summary>
        public BaseComponent(IMediator mediator = null)
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
    /// Компонент 1.
    /// </summary>
    class Component1 : BaseComponent
    {
        /// <summary>
        /// Функциональность A.
        /// </summary>
        public void DoA()
        {
            Console.WriteLine("Функциональность A Компонента 1.");
            _mediator.Notify(this, "A");
        }

        /// <summary>
        /// Функциональность B.
        /// </summary>
        public void DoB()
        {
            Console.WriteLine("Функциональность B Компонента 1.");
            _mediator.Notify(this, "B");
        }
    }

    /// <summary>
    /// Компонент 2.
    /// </summary>
    class Component2 : BaseComponent
    {
        /// <summary>
        /// Функциональность C.
        /// </summary>
        public void DoC()
        {
            Console.WriteLine("Функциональность C Компонента 2.");
            _mediator.Notify(this, "C");
        }

        /// <summary>
        /// Функциональность D.
        /// </summary>
        public void DoD()
        {
            Console.WriteLine("Функциональность D Компонента 2.");
            _mediator.Notify(this, "D");
        }
    }
}