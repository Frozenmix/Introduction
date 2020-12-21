using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[5, 5];

            matrix[2, 2] = 1;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                
                Console.Write(matrix[i,i]+" ");

            }
        }
    }
}