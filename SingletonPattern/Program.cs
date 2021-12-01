using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var singleton1 = Singleton.GetInstance("Уникальный экземпляр");
            var singleton2 = Singleton.GetInstance("Не уникальный экземпляр");
            //В консоль будет выведено "Уникальный экземпляр", так как инициализация нового экземпляра не произошла
            Console.WriteLine(singleton2.Data);
            
            if (singleton1 == singleton2)
            {
                Console.WriteLine("Одиночка работает, обе переменные содержат один и тот же экземпляр.");
            }
            else
            {
                Console.WriteLine("Одиночка не работает, переменные содержат разные экземпляры.");
            }
            Console.ReadLine();
        }
    }
}
