using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IComponent component = new Chat();
            component.SendMessage();
            Console.WriteLine();

            Decorator decoratorTelegram = new TelegramСhat(component);
            decoratorTelegram.SendMessage();
            Console.WriteLine();

            Decorator decoratorWhatsApp = new WhatsAppChat(component);
            decoratorWhatsApp.SendMessage();
            Console.WriteLine();

            Decorator decoratorAll = new WhatsAppChat(decoratorTelegram);
            decoratorAll.SendMessage();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
