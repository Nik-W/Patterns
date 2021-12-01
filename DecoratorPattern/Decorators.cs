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
        /// Логика.
        /// </summary>
        public abstract void Operation();
    }

    /// <summary>
    /// Декоратор А.
    /// </summary>
    class ConcreteDecoratorA : Decorator
    {
        public ConcreteDecoratorA(IComponent component) : base(component) { }

        /// <summary>
        /// Логика.
        /// </summary>
        public override void Operation()
        {
            _component.Operation();
            Console.WriteLine("Логика с Декоратором А.");
        }
    }

    /// <summary>
    /// Декоратор В.
    /// </summary>
    class ConcreteDecoratorB : Decorator
    {
        public ConcreteDecoratorB(IComponent component) : base(component) { }

        /// <summary>
        /// Логика.
        /// </summary>
        public override void Operation()
        {
            _component.Operation();
            Console.WriteLine("Логика с Декоратором В.");
        }
    }
}