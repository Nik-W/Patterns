using System;

namespace SingletonPattern
{
    /// <summary>
    /// Класс, реализующий паттерн Одиночка, гарантирующий, что для класса будет создан только один единственный экземпляр.
    /// </summary>
    public class Singleton
    {
        /// <summary>
        /// Основной объект, в котором будет храниться уникальный экземпляр класса. 
        /// </summary>
        private static Singleton _instance;

        /// <summary>
        /// Какие-либо хранимые данные.
        /// </summary>
        private string _data;

        /// <summary>
        /// Данные, используемые в классе.
        /// </summary>
        public string Data => _data;

        /// <summary>
        /// Защищенный конструктор для инициализации единственного экземпляра класса.
        /// </summary>
        /// <param name="data">Данные, используемые в классе.</param>
        private Singleton(string data)
        {
            _data = data;
        }

        /// <summary>
        /// Получить экземпляр класса.
        /// </summary>
        /// <param name="data">Инициализирующие данные класса.</param>
        /// <returns>Уникальный экземпляр класса.</returns>
        public static Singleton GetInstance(string data)
        {
            if (_instance == null)
            {
                _instance = new Singleton(data);
            }
            return _instance;
        }
    }
}