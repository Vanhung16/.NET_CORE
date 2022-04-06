using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenVanHung_2019605562_proj51
{
    class ThiSinhA
    {
        public int soBD { get; set; }
        public string hoTen { get; set; }
        public String  diaChi { get; set; }
        public float toan { get; set; }
        public float ly { get; set; }
        public float hoa { get; set; }
        public float diemUuTien { get; set; }
        public float tongDiem { get; set; }

        public ThiSinhA()
        {
        }

        public void nhapTT()
        {
            Console.Write("Nhap so bao danh: ");
            soBD = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ho ten: ");
            hoTen = Console.ReadLine();
            Console.WriteLine("Nhap dia chi: ");
            diaChi = Console.ReadLine();
            Console.WriteLine("Nhap diem toan: ");
            toan = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem ly: ");
            ly = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem hoa: ");
            hoa = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem uu tien: ");
            diemUuTien = float.Parse(Console.ReadLine());
            tongDiem = toan + ly + hoa + diemUuTien;
        }
        public static void inTieuDe()
        {
            Console.WriteLine("{0,-5}{1,20}{2,20}{3,5}{4,5}{5,5}{6,10}{7,10}", "so bao danh", 
                "ho ten", "dia chi", "toan", "ly", "ho", "diem uu tien", "tong diem");

        }
        public void xuattt()
        {
            Console.WriteLine("{0,-5}{1,20}{2,20}{3,5}{4,5}{5,5}{6,10}{7,10}",soBD,hoTen,
                diaChi,toan,ly,hoa,diemUuTien,tongDiem);
        }

   
    }
}
