using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3
{
    class Program
    {
        static void Main(string[] args)
        {
            string userline = Console.ReadLine();
            for (int i = userline.Length-1; i >= 0; i--)
            {
                Console.Write(userline[i]); 
            }
        }
    }
}
