using System;
using System.Threading;

namespace IoС_DI_Pattern
{
    /// <summary>
    /// Основной класс выполняющих майнинг.
    /// </summary>
    public class Miner
    {
        /// <summary>
        /// Алгоритм поиска хеша.
        /// </summary>
        private IAlgorithm algoritm;

        /// <summary>
        /// Поток в котором выполняется поиск.
        /// </summary>
        private Thread thread;

        /// <summary>
        /// Событие нахождения хеша.
        /// </summary>
        public event EventHandler<bool> HashFound;

        /// <summary>
        /// Создать экземпляр майнера.
        /// </summary>
        /// <param name="algorithm">Алгоритм выполняющий вычисления.</param>
        public Miner(IAlgorithm algorithm)
        {
            algoritm = algorithm;
            thread = new Thread(Mine);
            thread.Start();
        }

        /// <summary>
        /// Метод выполняющий майнинг.
        /// </summary>
        private void Mine()
        {
            while (true)
            {
                var hashResult = algoritm.Hash();
                HashFound?.Invoke(this, hashResult);
            }
        }
    }
}