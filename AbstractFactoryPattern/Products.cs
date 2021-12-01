namespace AbstractFactoryPattern
{
    /// <summary>
    /// Конкретный продукт А фабрики 1.
    /// </summary>
    class ConcreteProductA1 : IAbstractProductA
    {
        public string UsefulFunctionA()
        {
            return "Продукт А фабрики 1.";
        }
    }

    /// <summary>
    /// Конкретный продукт А фабрики 2.
    /// </summary>
    class ConcreteProductA2 : IAbstractProductA
    {
        public string UsefulFunctionA()
        {
            return "Продукт А фабрики 2.";
        }
    }

    /// <summary>
    /// Конкретный продукт В фабрики 1.
    /// </summary>
    class ConcreteProductB1 : IAbstractProductB
    {
        public string UsefulFunctionB()
        {
            return "Продукт В фабрики 1.";
        }

        /// <summary>
        /// Взаимодействие продукта В фабрики 1 с продуктом А.
        /// </summary>
        public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
        {
            var result = collaborator.UsefulFunctionA();

            return $"Продукт В фабрики 1 взаимодействует с: {result}";
        }
    }

    /// <summary>
    /// Конкретный продукт В фабрики 2.
    /// </summary>
    class ConcreteProductB2 : IAbstractProductB
    {
        public string UsefulFunctionB()
        {
            return "Продукт В фабрики 2.";
        }

        /// <summary>
        /// Взаимодействие продукта В фабрики 2 с продуктом А.
        /// </summary>
        public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
        {
            var result = collaborator.UsefulFunctionA();

            return $"Продукт В фабрики 2 взаимодействует с: {result}";
        }
    }
}