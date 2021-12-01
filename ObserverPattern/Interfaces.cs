namespace ObserverPattern
{
    /// <summary>
    /// Интерфейс Наблюдателя.
    /// </summary>
    public interface IObserver
    {
        void Update(ISubject subject);
    }

    /// <summary>
    /// Интерфейс методов Издателя.
    /// </summary>
    public interface ISubject
    {
        void Attach(IObserver observer);

        void Detach(IObserver observer);

        void Notify();
    }
}