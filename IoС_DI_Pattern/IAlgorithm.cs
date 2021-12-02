namespace IoС_DI_Pattern
{
    /// <summary>
    /// Базовый интерфейс криптоалгорима хеш-функции.
    /// </summary>
    public interface IAlgorithm
    {
        /// <summary>
        /// Вычисление нового хеша.
        /// </summary>
        /// <returns>Успешность нахождения хеша.</returns>
        bool Hash();
    }
}