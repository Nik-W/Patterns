using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IComponent component = new ConcreteComponent();
            component.Operation();
            Console.WriteLine();

            Decorator decoratorA = new ConcreteDecoratorA(component);
            decoratorA.Operation();
            Console.WriteLine();

            Decorator decoratorB = new ConcreteDecoratorB(component);
            decoratorB.Operation();
            Console.WriteLine();

            Decorator decoratorBA = new ConcreteDecoratorB(decoratorA);
            decoratorBA.Operation();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
