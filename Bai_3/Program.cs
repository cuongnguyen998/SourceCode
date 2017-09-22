using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Nhap N = ");
                n = int.Parse(Console.ReadLine());
                /*bool isInt = int.TryParse(Console.ReadLine(), out n);
                if (isInt==false)
                {
                    continue;
                }*/
                if (n<=0)
                {
                    continue;
                }
                else
                {
                    for (int i = 2; i < n; i++)
                    {
                        if (n % i == 0)
                        {
                            Console.WriteLine("So {0} khong la so nguyen to.", n);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("So {0} la so nguyen to", n);
                            break;
                        }
                    }
                    Console.Write("Muon kiem tra nua khong? Yes or No? ");
                    string Kt = Console.ReadLine();
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
