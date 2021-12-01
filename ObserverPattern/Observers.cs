using System;

namespace ObserverPattern
{
    /// <summary>
    /// Наблюдатель А.
    /// </summary>
    class ConcreteObserverA : IObserver
    {
        /// <summary>
        /// Получение обновлений от издателя.
        /// </summary>
        public void Update(ISubject subject)
        {
            if (((Subject) subject).State < 3)
            {
                Console.WriteLine("Реакция наблюдателя А.");
            }
        }
    }

    /// <summary>
    /// Наблюдатель В.
    /// </summary>
    class ConcreteObserverB : IObserver
    {
        /// <summary>
        /// Получение обновлений от издателя.
        /// </summary>
        public void Update(ISubject subject)
        {
            if (((Subject) subject).State == 0 || ((Subject) subject).State >= 2)
            {
                Console.WriteLine("Реакция наблюдателя В.");
            }
        }
    }
}