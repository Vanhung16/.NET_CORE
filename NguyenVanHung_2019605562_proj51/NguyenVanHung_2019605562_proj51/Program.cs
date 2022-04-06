using System;
using System.Collections.Generic;

namespace NguyenVanHung_2019605562_proj51
{
    class Program
    {
        static int choose;
        static List<ThiSinhA> list = new List<ThiSinhA>();

        public static void nhapthongtin()
        {
            ThiSinhA x = new ThiSinhA();
            x.nhapTT();
            list.Add(x);
        }
        public static void xuatds()
        {
            ThiSinhA.inTieuDe();
            foreach(ThiSinhA item in list)
            {
                item.xuattt();
            }
        }
        public static void viewByTotalPoit()
        {
            float diem = float.Parse(Console.ReadLine());
            ThiSinhA.inTieuDe();
            foreach(ThiSinhA item in list)
            {
                if(item.tongDiem >= diem)
                {
                    item.xuattt();
                }
            }

        }
        public static void viewByAddress()
        {
            Console.WriteLine("\t\t\tNhap dia chi can hien thi\n");
            string address = Console.ReadLine();
            ThiSinhA.inTieuDe();
            foreach(ThiSinhA item in list)
            {
                if(item.diaChi.CompareTo(address) == 0)
                {
                    item.xuattt();
                }
            }
        }
        
        public static void findBySBD()
        {
            Console.WriteLine("Nhap so bao danh can tim");
            int sbd = int.Parse(Console.ReadLine());
            ThiSinhA x = null ;
            foreach(ThiSinhA item in list)
            {
                if(item.soBD == sbd)
                {
                    x = item;
                }
            }
            if(x == null)
            {
                Console.WriteLine("khong co sbd nay trong list");
            }
            else
            {
                ThiSinhA.inTieuDe();
                x.xuattt();
            }
        }
        static void Main(string[] args)
        {
            while(choose>0 || choose < 7)
            {
                Console.WriteLine("\t\t\tNhap lua chon cua ban");
                Console.WriteLine("\t\t1. Nhap thong tin 1 thi sinh");
                Console.WriteLine("\t\t2. Hien thi danh sach cac thi sinh");
                Console.WriteLine("\t\t3. hien thi cac sinh vien theo tong diem");
                Console.WriteLine("\t\t4. hien thi cac sinh vien theo dia chi");
                Console.WriteLine("\t\t5. Tim kiem theo so bao danh");
                Console.WriteLine("\t\t6. thoat khoi chuong trinh");
                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        nhapthongtin();
                        break;
                    case 2:
                        xuatds();
                        break;
                    case 3:
                        viewByTotalPoit();
                        break;
                    case 4:
                        viewByAddress();
                        break;
                    case 5:
                        findBySBD();
                        break;
                    case 6:
                        return;
                }
            }
        }
    }
}
