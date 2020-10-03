using System;
using Modifiers;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Base modifierBase = new Base();
            modifierBase.PublicDemo();

            Console.ReadLine();
        }
    }
}
