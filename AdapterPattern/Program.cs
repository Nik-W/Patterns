using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Adaptee adaptee = new Adaptee();
            ITarget target = new Adapter(adaptee);

            Console.WriteLine(adaptee.GetSpecificRequest());
            Console.WriteLine(target.GetRequest());

            Console.ReadLine();
        }
    }
}
