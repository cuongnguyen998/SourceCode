using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int tong = 0;
            double tongPhanSo=0;
            do
            {
                Console.Clear();
                Console.Write("Nhap so n = ");
                bool isInt = int.TryParse(Console.ReadLine(), out n);
                if (isInt==false || n<=0)
                {
                    continue;
                }
                for (int i = 1; i <= n; i++)
                {
                    tong += i;
                    Console.Write("{0} + ", i);
                }
                Console.WriteLine(" = {0}", tong);
                for (double j = 1; j <= n; j++)
                {
                    tongPhanSo += (1 / j);
                    Console.Write("{0} + ", 1 / j);
                }
                Console.WriteLine(" = {0}", tongPhanSo);
                Console.Write("Muon tinh nua khong? Yes or No? ");
                string check = Console.ReadLine();
                if (check == "Yes")
                {
                    continue;
                }
                else
                    break;
            } while (true);
            Console.ReadLine();
        }
    }
}
