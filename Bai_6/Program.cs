using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            do
            {
                Console.Clear();
                TinhTienDien();                
                Console.Write("Muốn tính nữa không? Yes or No? ");
                string check = Console.ReadLine();
                if (check == "Yes")
                    continue;
                else
                    break;
            } while (true);
            //Console.ReadLine();
        }
        /// <summary>
        /// Hàm tính tiền điện
        /// </summary>
        static void TinhTienDien()
        {
            string name;
            double index1, index2, minor, price;
            Console.Write("Nhập họ và tên khách hàng: ");
            name = Console.ReadLine();            
            Console.Write("Nhập chỉ số điện tháng trước: ");
            index1 = double.Parse(Console.ReadLine());
            Console.Write("Nhập chỉ số điện tháng này: ");
            index2 = double.Parse(Console.ReadLine());
            minor = index2 - index1;                       
            if ((index1 >= 0) && (index1 <= index2))
            {
                Console.WriteLine("Khách hàng {0} ", name);
                Console.WriteLine("Tổng điện đã sử dụng: {0} KWH", minor);
                if (minor >= 0 && minor <= 50)
                {
                    price = minor * 1388;
                }
                else if (minor >= 51 && minor <= 100)
                {
                    price = (50 * 1388) + ((minor - 50) * 1433);
                    Console.WriteLine("Giá của 50 KWH đầu tiên  : {0} VND", 50 * 1338);
                    Console.WriteLine("Giá của {0} KWH tiếp theo: {1} VND", minor - 50, (minor - 50) * 1433);
                }
                else if (minor >= 101 && minor <= 200)
                {
                    price = (50 * 1388) + (50 * 1433) + ((minor - 100) * 1660);
                    Console.WriteLine("Giá của 50 KWH đầu tiên  : {0} VND", 50 * 1338);
                    Console.WriteLine("Giá của 50 KWH tiếp theo : {0} VND", 50 * 1433);
                    Console.WriteLine("Giá của {0} KWH tiếp theo: {1} VND", minor - 100, (minor - 100) * 1660);
                }
                else
                {
                    price = (50 * 1388) + (50 * 1433) + (100 * 1660) + ((minor - 200) * 2082);
                    Console.WriteLine("Giá của 50 KWH đầu tiên  : {0} VND", 50 * 1338);
                    Console.WriteLine("Giá của 50 KWH tiếp theo : {0} VND", 50 * 1433);
                    Console.WriteLine("Giá của 100 KWH tiếp theo: {0} VND", 100 * 1660);
                    Console.WriteLine("Giá của {0} KWH tiếp theo: {1} VND", minor - 200, (minor - 200) * 2082);
                }
                price += ((price * 10) / 100);
                //Console.WriteLine("Ban da su dung {0} KWH", minor);
                Console.WriteLine("Tổng tiền cần phải trả là: {0} VND", price);
            }
            else
            {
                Console.WriteLine("Dữ liệu không phù hợp. Nhập lại đi!");                
            }

        }
    }
}
