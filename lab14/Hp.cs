using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hlp
{
    class Hp
    {
        public static void Gen (double[,] arr, int n, int m, double a, double b)
        {
            Random ran = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    arr[i, j] = a + ran.NextDouble() * (b - a);
        }

        public static void Printer(double[,] arr, int n, int m, ref string output)
        {
            for (int i = 0; i < n; i++)
            {
                output += "|";
                for (int j = 0; j < m; j++)
                    output += $"{arr[i, j]}|";
                output += "\n\n";
            }
        }

        public static void Maxpos (double[,] arr, int n, int m, ref string rezult)
        {
            double buf = 0;
            int indxi = 0, indxj = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    if (arr[i,j] > buf)
                    {
                        buf = arr[i, j];
                        indxi = i;
                        indxj = j;
                    }

            rezult += $"Максимальний: arr[{indxi},{indxj}] = {buf}";
        }
    }
}
