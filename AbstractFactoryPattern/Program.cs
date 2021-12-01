using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Тестирование продуктов фабрики 1.");
            ClientMethod(new ConcreteFactory1());
            Console.WriteLine();

            Console.WriteLine("Тестирование продуктов фабрики 2.");
            ClientMethod(new ConcreteFactory2());

            Console.ReadLine();
        }

        /// <summary>
        /// Работа конкретной фабрики.
        /// </summary>
        public static void ClientMethod(IAbstractFactory factory)
        {
            var productA = factory.CreateProductA();
            var productB = factory.CreateProductB();

            Console.WriteLine(productB.UsefulFunctionB());
            Console.WriteLine(productB.AnotherUsefulFunctionB(productA));
        }
    }
}
