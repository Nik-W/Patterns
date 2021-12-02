using System;
using System.Threading;

namespace IoС_DI_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Внедрение зависимостей через конструктор
            var miner1 = new Miner(new Algorithm1());
            var miner2 = new Miner(new Algorithm2());
            miner1.HashFound += Miner_HashFound;
            miner2.HashFound += Miner_HashFound;
        }

        /// <summary>
        /// Обработчик события нахождения хеша.
        /// </summary>
        /// <param name="sender">Майнер.</param>
        /// <param name="e">Корректность хеша.</param>
        private static void Miner_HashFound(object sender, bool e)
        {
            Console.WriteLine(e ? "Хеш найден" : "Некорректный хеш");
        }
    }
}
