using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeXuong
{
    internal class SinhVien
    {
        private string maSinhVien {  get; set; }    
        private string ten {  get; set; }
        private int namSinh { get; set; }
        private double diem { get; set;}
        public int Diem { get; internal set; }

        public SinhVien()
        {
            
        }

        public SinhVien(string maSinhVien, string ten, int namSinh, double diem)
        {
            this.maSinhVien = maSinhVien;
            this.ten = ten;
            this.namSinh = namSinh;
            this.diem = diem;
        }

        public virtual void InThongTin() 
        {
            Console.WriteLine($"Ten {this.ten} - MaSinhVien {this.maSinhVien} - Nam Sinh {this.namSinh} - Diem {this.diem}");
        }
    }
}
