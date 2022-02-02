namespace AbstractFactoryPattern
{
    /// <summary>
    /// Высококачественный видеофайл.
    /// </summary>
    class ConcreteHighQualityVideo : IAbstractHighQuality
    {
        public string UsefulFunctionHighQuality()
        {
            return "Высококачественный видеофайл.";
        }
    }

    /// <summary>
    /// Высококачественный аудиофайл.
    /// </summary>
    class ConcreteHighQualityAudio : IAbstractHighQuality
    {
        public string UsefulFunctionHighQuality()
        {
            return "Высококачественный аудиофайл.";
        }
    }

    /// <summary>
    /// Низкокачественный видеофайл.
    /// </summary>
    class ConcreteLowQualityVideo : IAbstractLowQuality
    {
        public string UsefulFunctionLowQuality()
        {
            return "Низкокачественный видеофайл.";
        }

        /// <summary>
        /// Взаимодействие видеофайлов.
        /// </summary>
        public string AnotherUsefulFunction(IAbstractHighQuality collaborator)
        {
            var result = collaborator.UsefulFunctionHighQuality();

            return $"Низкокачественный видеофайл взаимодействует с: {result}";
        }
    }

    /// <summary>
    /// Низкокачественный аудиофайл.
    /// </summary>
    class ConcreteLowQualityAudio : IAbstractLowQuality
    {
        public string UsefulFunctionLowQuality()
        {
            return "Низкокачественный аудиофайл.";
        }

        /// <summary>
        /// Взаимодействие аудиофайлов.
        /// </summary>
        public string AnotherUsefulFunction(IAbstractHighQuality collaborator)
        {
            var result = collaborator.UsefulFunctionHighQuality();

            return $"Низкокачественный аудиофайл взаимодействует с: {result}";
        }
    }
}