using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            var a = Console.ReadLine();
            int b = Convert.ToInt32(a);
            int c = b % 2;
            if (c > 0)
                Console.WriteLine("Это нечётное число");
            else
                Console.WriteLine("Это чётное число");
        }
    }
}
