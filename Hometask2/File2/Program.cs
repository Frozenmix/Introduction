using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File2
{
    class Program
    { 
        enum Month {
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December,
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the current month's number");
            var Aquirednumber = Console.ReadLine();
            int a = Convert.ToInt32(Aquirednumber);
            Month month = (Month)a;
            Console.WriteLine("It's " + month);    
        }
    }
}
