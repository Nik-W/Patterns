﻿using System;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Клиентский код.
            Component1 component1 = new Component1();
            Component2 component2 = new Component2();
            new ConcreteMediator(component1, component2);

            component1.DoA();
            Console.WriteLine();
            component2.DoD();
            Console.ReadLine();
        }
    }
}
