using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] telBook = new string[5, 2];
            telBook[0, 0] = "Anton";
            telBook[0, 1] = "89659536598";
            telBook[1, 0] = "Aleksei";
            telBook[1, 1] = "89515468798";
            telBook[2, 0] = "Gennadij";
            telBook[2, 1] = "123lo@yandex.ru";
            telBook[3, 0] = "Evgenij";
            telBook[3, 1] = "89555463212";
            telBook[4, 0] = "Roman";
            telBook[4, 1] = "romeo32@yahoo.com";
            for (int i = 0; i < telBook.GetLength(0); i++)
            {
                Console.WriteLine(telBook[i, 0] + " " + telBook[i, 1]);
            }
        }
    }
}
