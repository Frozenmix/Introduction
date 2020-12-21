using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[,] battleField = new bool[10, 10];
            battleField[1, 1] = true;
            battleField[2, 1] = true;

            battleField[1, 3] = true;
            battleField[1, 4] = true;
            battleField[1, 5] = true;

            battleField[4, 2] = true;

            battleField[3, 4] = true;
            battleField[4, 4] = true;

            battleField[2, 7] = true;
            battleField[3, 7] = true;
            battleField[4, 7] = true;

            battleField[2, 9] = true;

            battleField[6, 2] = true;
            battleField[6, 3] = true;
            battleField[6, 4] = true;
            battleField[6, 5] = true;

            battleField[8, 0] = true;
            battleField[9, 0] = true;

            battleField[8, 3] = true;

            battleField[9, 7] = true;
            for (int i = 0; i < battleField.GetLength(0); i++)
            {
                for (int j = 0; j < battleField.GetLength(1); j++)
                    Console.Write(battleField[i, j] ? "X" : "O");
                Console.WriteLine(string.Empty);
            }
                
        }
    }
}
