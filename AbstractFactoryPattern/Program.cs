using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Тестирование видеофайлов.");
            ClientMethod(new ConcreteFactoryVideo());
            Console.WriteLine();

            Console.WriteLine("Тестирование аудиофайлов.");
            ClientMethod(new ConcreteFactoryAudio());

            Console.ReadLine();
        }

        /// <summary>
        /// Работа конкретной фабрики.
        /// </summary>
        public static void ClientMethod(IAbstractFactory factory)
        {
            var productA = factory.CreateHighQuality();
            var productB = factory.CreateLowQuality();

            Console.WriteLine(productB.UsefulFunctionLowQuality());
            Console.WriteLine(productB.AnotherUsefulFunction(productA));
            Console.WriteLine(productA.UsefulFunctionHighQuality());
        }
    }
}
