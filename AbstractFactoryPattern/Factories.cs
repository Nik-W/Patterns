namespace AbstractFactoryPattern
{
    /// <summary>
    /// Конкретная фабрика 1, гарантирующая совместимость полученных продуктов.
    /// </summary>
    class ConcreteFactory1 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA1();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB1();
        }
    }

    /// <summary>
    /// Конкретная фабрика 1, гарантирующая совместимость полученных продуктов.
    /// </summary>
    class ConcreteFactory2 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA2();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB2();
        }
    }
}