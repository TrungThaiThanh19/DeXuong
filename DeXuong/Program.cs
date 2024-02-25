using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DeXuong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            int chon = -1;
            SinhVienSerVice danhSachSinhVien = new SinhVienSerVice();
            do
            {
                Console.WriteLine("Quan ly sinh vien tham gia HappyBee");
                Console.WriteLine("1.Nhap danh sach doi tuong");
                Console.WriteLine("2.Xuat anh sach doi tuong");
                Console.WriteLine("3.Xuat danh sach cac sinh vien duoc tang ve vip HappyBee");
                Console.WriteLine("4.Xoa nhung sinh vien khong duoc tham gia HappyBee neukhong duoc tang");
                Console.WriteLine("0.Thoat");
                Console.WriteLine("Xin moi ban nhap lua chon : ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        danhSachSinhVien.ThemSinhvien();
                        break;
                    case 2:
                        danhSachSinhVien.XuatDanhSach();
                        break;
                    case 3:

                        break;
                    case 4:
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Ban nhap sai lua chon chuc nang roi. Moi ban chon lai chuc nang");
                        break;
                }
            } while (chon != 0);
        }
    }
}
