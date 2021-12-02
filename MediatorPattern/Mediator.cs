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
        /// Компонент 1.
        /// </summary>
        private Component1 _component1;

        /// <summary>
        /// Компонент 2.
        /// </summary>
        private Component2 _component2;

        /// <summary>
        /// Создание экземпляра Посредника.
        /// </summary>
        public ConcreteMediator(Component1 component1, Component2 component2)
        {
            this._component1 = component1;
            this._component1.SetMediator(this);
            this._component2 = component2;
            this._component2.SetMediator(this);
        }

        /// <inheritdoc />
        public void Notify(object sender, string ev)
        {
            switch (ev)
            {
                case "A":
                    Console.WriteLine("Посредник среагировал на A:");
                    _component2.DoC();
                    break;
                case "D":
                    Console.WriteLine("Посредник среагировал на D:");
                    _component1.DoB();
                    _component2.DoC();
                    break;
            }
        }
    }
}