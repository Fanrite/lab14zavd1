using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hlp;

namespace lab14
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0, b = 300;
            int n = 1, m = 1;
            bool flag = true;
            while (flag)
            {
                string output = "\n", vih, rezult = "";
                Console.Write("Введіть кількість рядків:");
                n = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введіть кількість стоібців:");
                m = Convert.ToInt32(Console.ReadLine());

                double[,] arr = new double[n, m];
                Hp.Gen(arr, n, m, a, b);
                Hp.Printer(arr, n, m, ref output);
                Hp.Maxpos(arr, n, m, ref rezult);

                Console.WriteLine(output);
                Console.WriteLine(rezult);

                Console.Write("Бажаєте повторити?(Y/N):");
                vih = Console.ReadLine();
                if (vih != "y" && vih != "Y") flag = false;
            }

        }
    }
}
