using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OperationsLib
{
    public class Printer
    {
        public string[,] Output(double[,] input)
        {
            string[,] output = new string[input.GetLength(0), input.GetLength(1)];

            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    output[i, j] += Convert.ToString(input[i, j]);
                }
            }

            return output;
        }

        public void WriteConsole(double[,] input)
        {
            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    Console.Write(input[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
