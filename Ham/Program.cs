using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ham
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            int count = 0;
            for (int i = 0; i <=n; i++)
            {
                count++;
            }
            Console.WriteLine("Chuong trinh da chay {0} lan", count);
            Console.ReadLine();
        }
    }
}
