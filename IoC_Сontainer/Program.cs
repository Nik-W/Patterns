using System;
using LightInject;

namespace IoC_Сontainer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создание контейнера.
            var container = new ServiceContainer();

            //Регистрация служб.
            container.Register<IAccount, Account>();
            container.Register<IContact, Contact>();

            //Получить экземпляр службы Контрагента.
            var account = container.GetInstance<IAccount>();
            account.NewCase();

            //Получить экземпляр службы Контакта.
            var contact = container.GetInstance<IContact>();
            contact.CallOwner();
        }
    }

    /// <summary>
    /// Интерфейс Контрагента.
    /// </summary>
    public interface IAccount
    {
        void NewCase();
    }

    /// <summary>
    /// Класс Контрагента.
    /// </summary>
    public class Account : IAccount
    {
        /// <summary>
        /// Ответственный в Контрагенте.
        /// </summary>
        public IContact Owner { get; set; }

        /// <summary>
        /// Создание нового обращения.
        /// </summary>
        public void NewCase()
        {
            Owner.CallOwner();
            Console.WriteLine("Обращение к Контрагенту.");
        }
    }

    /// <summary>
    /// Интерфейс Контакта.
    /// </summary>
    public interface IContact
    {
        void CallOwner();
    }

    /// <summary>
    /// Класс Контакта.
    /// </summary>
    public class Contact : IContact
    {
        /// <summary>
        /// Вызов Контакта как отвественного.
        /// </summary>
        public void CallOwner()
        {
            Console.WriteLine("Ответственный вызван.");
        }
    }
}
