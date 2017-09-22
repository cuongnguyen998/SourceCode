using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai_tap
{
    class Program
    {
        static void Main(string[] args)
        {
            int tich, n;
            do
            {
                Console.Write("Nhap n = ");
                n = int.Parse(Console.ReadLine());
                //bool isInt = int.TryParse(Console.ReadLine(), out n);
                if (n < 1 || n > 9)
                {
                    continue;
                }
                else
                {
                    for (int i = 1; i <= 9; i++)
                    {
                        tich = i * n;
                        Console.WriteLine("{0} * {1} = {2}", n, i, tich);
                    }
                    Console.Write("Muon tinh nua khong? Yes or No? ");
                    string Kt=Console.ReadLine();
                    if (Kt=="No")
                    {
                        break;
                    }

                }
            } while (true);
           
            Console.ReadLine();
        }
    }
}
