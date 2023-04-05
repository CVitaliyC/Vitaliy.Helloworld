using System;
using System.Threading;

namespace Vitaliy.Helloworld
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello, C#");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Hello, Dude");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Hello, Liza");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Hello, World");
            Thread.Sleep(2000);
            Console.Clear();
            Console.ReadLine();
        }
    }
}