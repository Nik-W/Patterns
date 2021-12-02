using System;
using System.Threading;

namespace IoС_DI_Pattern
{
    /// <summary>
    /// Алгоритм вычисления хеш-функции 1.
    /// </summary>
    public class Algorithm1 : IAlgorithm
    {
        /// <inheritdoc />
        public bool Hash()
        {
            var guid = Guid.NewGuid();
            Thread.Sleep(1000);
            var hash = guid.GetHashCode();
            return hash <= 10000;
        }

        /// <summary>
        /// Приведение объекта к строке.
        /// </summary>
        /// <returns>Имя алгоритма.</returns>
        public override string ToString()
        {
            return nameof(Algorithm1);
        }
    }

    /// <summary>
    /// Алгоритм вычисления хеш-функции 2.
    /// </summary>
    public class Algorithm2 : IAlgorithm
    {
        /// <inheritdoc />
        public bool Hash()
        {
            var guid = Guid.NewGuid();
            Thread.Sleep(1000);
            var hash = guid.GetHashCode();
            return hash <= 50000;
        }

        /// <summary>
        /// Приведение объекта к строке.
        /// </summary>
        /// <returns>Имя алгоритма.</returns>
        public override string ToString()
        {
            return nameof(Algorithm2);
        }
    }
}