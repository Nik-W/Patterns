using System;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Клиентский код.
            Contact contact = new Contact();
            Account account = new Account();
            new ConcreteMediator(contact, account);

            contact.DoA();
            Console.WriteLine();
            account.DoD();
            Console.ReadLine();
        }
    }
}
