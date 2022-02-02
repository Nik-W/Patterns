using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ContactAdaptee contactAdaptee = new ContactAdaptee();
            ITarget target = new Adapter(contactAdaptee);

            Console.WriteLine(contactAdaptee.GetSpecificRequest());
            Console.WriteLine(target.GetRequest());

            Console.ReadLine();
        }
    }
}
