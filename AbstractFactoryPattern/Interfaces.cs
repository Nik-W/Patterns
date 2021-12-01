namespace AbstractFactoryPattern
{
    /// <summary>
    /// Интерфейс абстрактной Фабрики объявляет набор методов, которые возвращают различные абстрактные продукты.
    /// </summary>
    public interface IAbstractFactory
    {
        IAbstractProductA CreateProductA();

        IAbstractProductB CreateProductB();
    }

    /// <summary>
    /// Базовый интерфейс продукта А.
    /// </summary>
    public interface IAbstractProductA
    {
        string UsefulFunctionA();
    }

    /// <summary>
    /// Базовый интерфейс продукта В.
    /// </summary>
    public interface IAbstractProductB
    {
        string UsefulFunctionB();

        string AnotherUsefulFunctionB(IAbstractProductA collaborator);
    }
}