namespace AbstractFactoryPattern
{
    /// <summary>
    /// Фабрика видео файлов, гарантирующая совместимость полученных продуктов.
    /// </summary>
    class ConcreteFactoryVideo : IAbstractFactory
    {
        public IAbstractHighQuality CreateHighQuality()
        {
            return new ConcreteHighQualityVideo();
        }

        public IAbstractLowQuality CreateLowQuality()
        {
            return new ConcreteLowQualityVideo();
        }
    }

    /// <summary>
    /// Фабрика аудиофайлов, гарантирующая совместимость полученных продуктов.
    /// </summary>
    class ConcreteFactoryAudio : IAbstractFactory
    {
        public IAbstractHighQuality CreateHighQuality()
        {
            return new ConcreteHighQualityAudio();
        }

        public IAbstractLowQuality CreateLowQuality()
        {
            return new ConcreteLowQualityAudio();
        }
    }
}