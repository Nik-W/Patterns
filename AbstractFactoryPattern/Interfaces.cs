namespace AbstractFactoryPattern
{
    /// <summary>
    /// Интерфейс абстрактной Фабрики объявляет набор методов, которые возвращают различные абстрактные продукты.
    /// </summary>
    public interface IAbstractFactory
    {
        IAbstractHighQuality CreateHighQuality();

        IAbstractLowQuality CreateLowQuality();
    }

    /// <summary>
    /// Базовый интерфейс высококачественных файлов.
    /// </summary>
    public interface IAbstractHighQuality
    {
        string UsefulFunctionHighQuality();
    }

    /// <summary>
    /// Базовый интерфейс низкокачественных файлов.
    /// </summary>
    public interface IAbstractLowQuality
    {
        string UsefulFunctionLowQuality();

        string AnotherUsefulFunction(IAbstractHighQuality collaborator);
    }
}