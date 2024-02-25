using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeXuong
{
    internal class SinhVienUD : SinhVien
    {
        private int kiHoc {  get; set; }

        public SinhVienUD()
        {
            
        }

        public SinhVienUD(string maSinhVien, string ten, int namSinh, double diem, int hocKy) : base( maSinhVien, ten, namSinh, diem)
        {
            this.kiHoc = kiHoc;
        }

        public override void InThongTin()
        {
            base.InThongTin();
            Console.WriteLine($"Hoc ky {this.kiHoc}");
        }
    }
}
