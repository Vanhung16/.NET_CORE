using System;
using System.Collections.Generic;

namespace De02
{
    class Program
    {
        static List<Candidate> list = new List<Candidate>();
        static int choose;
        public static Boolean checkID(string id)
        {
            foreach (Candidate item in list)
            {
                if (item.id == id)
                {
                    return true;
                }
            }
            return false;
        }
        public static void addNew()
        {
            Candidate x = new Candidate();
          
                x.Input();
                if (!checkID(x.id))
                {
                    list.Add(x);
                }
                else
                {
                    Console.WriteLine("Id da ton tai");
                }
            
        }
        public static void view()
        {
            Candidate.inTD();
            foreach (Candidate item in list)
            {
                item.Output();
            }
        }
        public static void sortByTotal() {
            list.Sort();
            Console.WriteLine("danh sach thi sinh sau khi sap xep theo diem");
            view();
        }
        public static void ViewTSDO()
        {
            Console.WriteLine("Nhap diem san: ");
            float mark = float.Parse(Console.ReadLine());
            int count = 0;
            Candidate.inTD();
            foreach (Candidate item in list)
            {
                if(item.Total() >= mark)
                {
                    item.Output();
                    count++;
                }
            }
            if(count == 0)
            {
                Console.WriteLine("------->Khong thi sinh nao thi do");
            }
        }
        public static void viewKVTS()
        {
            Console.WriteLine("Nhap khu vuc: ");
            int kv = int.Parse(Console.ReadLine());
            int count = 0;
            Console.WriteLine("------Danh sach thi sinh cung khu vuc"+kv);
            Candidate.inTD();
            foreach (Candidate item in list)
            {
                if(item.address == kv)
                {
                    item.Output();
                    count++;
                }
            }
            if(count == 0)
            {
                Console.WriteLine("------->Khong co thi sinh nao trong khu vuc nay!");
            }
        }
        public static void viewBySBD()
        {
            Console.WriteLine("Nhap sbd: ");
            string sbd = Console.ReadLine();
            int count = 0;
            
            Candidate.inTD();
            foreach (Candidate item in list)
            {
                if (string.Compare(item.id, sbd) == 0)
                {
                    item.Output();
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("------->Khong co thi sinh mang sbd nhu v!");
            }
        }
        public static void removeByid()
        {
            Console.WriteLine("Nhap sbd: ");
            string sbd = Console.ReadLine();
            int count = 0;

            Candidate.inTD();
            Candidate x = null;
            foreach (Candidate item in list)
            {
                if (string.Compare(item.id, sbd) == 0)
                {
                    x = item;
                    count++;
                }
            }

            if (count == 0)
            {
                Console.WriteLine("------->Khong co thi sinh mang sbd nhu v!");
            }
            else
            {
                list.Remove(x);
                Console.WriteLine("xoa thanh cong");
            }
        }
        static void Main(string[] args)
        {
            while (choose < 9)
            {
                Console.WriteLine("\t\tMenu");
                Console.WriteLine("\t\t1.Them 1 thi sinh");
                Console.WriteLine("\t\t2.Hien thi danh sach");
                Console.WriteLine("\t\t3.Hien thi danh sach theo thu tu diem thi");
                Console.WriteLine("\t\t4.Hien thi thi sinh thi do");
                Console.WriteLine("\t\t5.Hien thi danh sach co cung khu vuc");
                Console.WriteLine("\t\t6.hien thi thong tin theo sbd");
                Console.WriteLine("\t\t7.xoa thi sinh khoi danh sach");
                Console.WriteLine("\t\t8. Ket thuc chuong trinh");
                Console.Write("\n----------->");
                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1: addNew(); break;
                    case 2: view(); break;
                    case 3: sortByTotal(); break;
                    case 4: ViewTSDO(); break;
                    case 5: viewKVTS(); break;
                    case 6: viewBySBD(); break;
                    case 7: removeByid(); break;
                    case 8: return;
                    default: return;
                }
            }
        }
    }
}
