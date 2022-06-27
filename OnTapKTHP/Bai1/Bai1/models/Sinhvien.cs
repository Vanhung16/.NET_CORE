using System;
using System.Collections.Generic;

#nullable disable

namespace Bai1.models
{
    public partial class Sinhvien
    {
        public int Masv { get; set; }
        public string Hoten { get; set; }
        public string Diachi { get; set; }
        public byte? Diem { get; set; }
        public int? Malop { get; set; }
        public string Anh { get; set; }

        public Sinhvien(int masv, string hoten, string diachi, byte? diem, int? malop)
        {
            Masv = masv;
            Hoten = hoten;
            Diachi = diachi;
            Diem = diem;
            Malop = malop;
            
        }

        public virtual Lophoc MalopNavigation { get; set; }
    }
}
