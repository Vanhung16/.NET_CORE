using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De1
{
    class ThiSinhUT : ThiSinh, IComparable
    {
        public int khuVuc { get; set; }
        public float diemUuTien { get; set; }

        public Boolean checkID()
        {

        }
        public void nhapThongTin()
        {

            Console.Write("Nhap so bao danh: ");
            sbd = Console.ReadLine();
            Console.Write("Nhap ho ten: ");
            hoTen = Console.ReadLine();
            Console.Write("Nhap diem toan: ");
            diemToan = float.Parse(Console.ReadLine());
            Console.Write("Nhap diem Ly: ");
            diemLy = float.Parse(Console.ReadLine());
            Console.Write("Nhap diem Hoa: ");
            diemHoa = float.Parse(Console.ReadLine());
            Console.Write("Nhap khu vuc: ");
            try
            {
                int temp = int.Parse(Console.ReadLine());
                if (temp < 1 || temp > 3) throw new Exception("Khong co khu vuc nay!");
                khuVuc = temp;
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            if (khuVuc == 1)
            {
                diemUuTien = 0f;
            }
            if (khuVuc == 2)
            {
                diemUuTien = 0.5f;
            }
            if (khuVuc == 3)
            {
                diemUuTien = 1f;
            }

        }
        public void hienThi()
        {
            Console.WriteLine("{0,-5}{1,-10}{2,5}{3,5}{4,5}{5,5}{6,10}", sbd,
                hoTen, diemToan, diemLy, diemHoa, khuVuc, tongDiem());
        }

        public override float tongDiem()
        {
            return base.tongDiem() + diemUuTien;
        }

        public int CompareTo(object obj)
        {
            ThiSinhUT x = (ThiSinhUT)obj;
            return this.tongDiem().CompareTo(x.tongDiem());
        }
    }
}
