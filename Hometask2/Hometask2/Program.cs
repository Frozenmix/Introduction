using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите минимальную температуру за сутки");
            var lowestTemp = Console.ReadLine();
            Console.WriteLine("Введите максимальную температуру за сутки");
            var highestTemp = Console.ReadLine();
            int a = Convert.ToInt32(highestTemp);
            int b = Convert.ToInt32(lowestTemp);
            if (b > a) {
                Console.WriteLine("Минимальная температура НЕ может быть выше максимальной");
                return;
            }         
            double averageTemp = (a + b)/2;            
            Console.WriteLine("Средняя температура за сутки "  +  averageTemp);
            return;
        }
    }
}
