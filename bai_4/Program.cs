using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bai_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n;
            do
            {
                Console.Clear();
                Console.WriteLine("1.Tính diện tích và chu vi hình tròn.");
                Console.WriteLine("2.Tính diện tích và chu vi hình chữ nhật.");
                Console.WriteLine("3.Tính diện tích và chu vi hình vuông.");
                Console.WriteLine("4.Kết thúc chương trình.");
                Console.WriteLine("---------------------------");
                Console.Write("Please choose [1-4]: ");
                n = int.Parse(Console.ReadLine());
                if (n == 1)
                {
                    tinhDienTichVaChuViHinhTron();
                }
                else if (n == 2)
                {
                    tinhDienTichVaChuViHinhChuNhat();
                }
                else if (n == 3)
                {
                    tinhDienTichVaChuViHinhVuong();
                }
                else if (n == 4)
                {
                    Console.WriteLine("Press any key to continue...");
                    break;
                }
                else
                {
                    continue;
                }
                Console.Write("Muốn tính tiếp không? Yes or No? ");
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
        static void tinhDienTichVaChuViHinhTron()
        {
            Console.Write("Mời bạn nhập bán kính: ");
            double banKinh = double.Parse(Console.ReadLine());
            double chuVi = 2 * banKinh * Math.PI;
            double dienTich = banKinh * banKinh * Math.PI;
            Console.WriteLine("Chu vi hình tròn là {0} và diện tích là {1}", chuVi, dienTich);
        }
        static void tinhDienTichVaChuViHinhChuNhat()
        {
            do
            {
                Console.Clear();
                Console.Write("Moi ban nhap chieu dai: ");
                double chieuDai = double.Parse(Console.ReadLine());
                Console.Write("Moi ban nhap chieu rong: ");
                double chieuRong = double.Parse(Console.ReadLine());
                double chuVi = (chieuDai + chieuRong) * 2;
                double dienTich = chieuDai * chieuRong;
                if (chieuDai > chieuRong)
                {
                    Console.WriteLine("Chu vi hinh chu nhat la {0} va dien tich hinh chu nhat la {1}", chuVi, dienTich);
                    break;
                }
                else
                {
                    Console.WriteLine("Nhap sai roi, muon nhap lai khong? Yes or No");
                    string check = Console.ReadLine();
                    if (check == "yes")
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
            } while (true);
           
        }
            
        static void tinhDienTichVaChuViHinhVuong()
        {
            Console.Write("Moi ban nhap chieu dai canh hinh vuong: ");
            double canh = double.Parse(Console.ReadLine());
            double chuVi = 4 * canh;
            double dienTich = canh * canh;
            Console.WriteLine("Chu vi hinh vuong la {0} va dien tich hinh vuong la {1}", chuVi, dienTich);
        }
    }
}
