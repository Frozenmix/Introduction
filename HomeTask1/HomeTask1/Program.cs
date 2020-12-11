using System;

namespace HomeTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! Today is [{DateTime.Now.ToString("dd.MM.yyyy")}]");
        }
    }
}
