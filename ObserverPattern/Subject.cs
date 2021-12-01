using System;
using System.Collections.Generic;
using System.Threading;

namespace ObserverPattern
{
    /// <summary>
    /// Издатель владеет некоторым важным состоянием и оповещает наблюдателей о его изменениях.
    /// </summary>
    public class Subject : ISubject
    {
        /// <summary>
        /// Состояние Издателя.
        /// </summary>
        public int State { get; set; } = -0;

        /// <summary>
        /// Список подписчиков.
        /// </summary>
        private List<IObserver> _observers = new List<IObserver>();

        /// <summary>
        /// Подписка.
        /// </summary>
        public void Attach(IObserver observer)
        {
            Console.WriteLine("Произошла подписка.");
            _observers.Add(observer);
        }

        /// <summary>
        /// Отписка.
        /// </summary>
        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
            Console.WriteLine("Произошла отписка.");
        }

        /// <summary>
        /// Уведомление.
        /// </summary>
        public void Notify()
        {
            Console.WriteLine("Выслано уведомление.");

            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

        /// <summary>
        /// Бизнес-логика.
        /// </summary>
        public void SomeBusinessLogic()
        {
            State = new Random().Next(0, 10);

            Thread.Sleep(15);

            Console.WriteLine("\nСостояние изменилось на: " + State);
            Notify();
        }
    }
}