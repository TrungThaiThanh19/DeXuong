using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeXuong
{
    internal class SinhVienSerVice
    {
        List<SinhVien> danhSachSinhVien = new List<SinhVien>();


        public SinhVienSerVice()
        {
            danhSachSinhVien = new List<SinhVien>();
        }

        public void ThemSinhvien()
        {
            int tieptuc = -1;
            do
            {
                Console.WriteLine("Nhap ten sinh vien : ");
                string ten = Console.ReadLine();
                Console.WriteLine("Ma Sinh Vien : ");
                string maSinhVien = Console.ReadLine();
                Console.WriteLine("Nhap nam sinh: ");
                int namSinh = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap diem cua sinh vien: ");
                double diem = double.Parse(Console.ReadLine());
                SinhVien sinhVien = new SinhVien(maSinhVien, ten, namSinh, diem);
                this.danhSachSinhVien.Add(sinhVien);

                Console.WriteLine("Ban co muon nhap nua khong (1-co/2-khong)");
                tieptuc = int.Parse(Console.ReadLine());
            } while (tieptuc == 1);
        }
        public void XuatDanhSach()
        {
            foreach (SinhVien sv in this.danhSachSinhVien)
            {
                sv.InThongTin();
            }
        }
        public void XuatdanhsachcacsinhvienduoctangvevipHappyBee()
        {
            foreach (SinhVien sinhVien in danhSachSinhVien)
            {
                if (sinhVien.Diem >= 8)
                {
                    sinhVien.InThongTin();
                    Console.WriteLine("-----------------------");
                }
            }
        }
    }
}
