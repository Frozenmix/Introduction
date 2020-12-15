using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File4
{
    class Program
    {
        enum Month
        {
            January=1,
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
            var aquirednumber = Console.ReadLine();
            Console.WriteLine("Enter today's lowest temperature");
            var lowestTemp = Console.ReadLine();
            Console.WriteLine("Enter today's highest temperature");
            var highestTemp = Console.ReadLine();
            int c = Convert.ToInt32(highestTemp);
            int d = Convert.ToInt32(lowestTemp);
            double averageTemp = (c + d) / 2;
            int a = Convert.ToInt32(aquirednumber);
            int b = Convert.ToInt32(averageTemp);
            Month month = (Month)a;
            Console.WriteLine("It's " + month);
            Console.WriteLine("Today's average temperature is " + b);
            switch (month)
            {
                case Month.December:
                case Month.January:
                case Month.February:
                    if (b > 0)
                        Console.WriteLine("Rainy Winter");
                    break;

            }

                
            

        }
    }
}
