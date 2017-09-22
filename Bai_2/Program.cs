using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int count = 0;
            do
            {
                Console.Write("Nhap so n = ");
                n = int.Parse(Console.ReadLine());
                if (n<=0)
                {
                    continue;
                }
                else
                {
                    for (int i = 2; i < n; i++)
                    {
                        if (n%i==0)
                        {
                            Console.Write("{0}, ", i);
                            count++;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine("So {0} co {1} uoc so.", n, count);
                    break;
                }
            } while (true);
            Console.ReadLine();
        }
    }
}
