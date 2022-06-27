using System;
using System.Collections.Generic;

namespace NguyenVanHung_2019605562_proj61
{
    class Program
    {
        static List<Student> list = new List<Student>();
        static int choose;

        public static void findById()
        {
            Console.Write("Nhap id can tim: ");
            int id = int.Parse(Console.ReadLine());
            Student x = null;
            foreach (Student item in list)
            {
                if(item.id.CompareTo(id) == 0)
                {
                    x = item;
                }
            }
            if(x != null)
            {
                Console.WriteLine("Thong tin: ");
                x.output();
            }
            else
            {
                Console.WriteLine("ma id khong ton tai");
            }
        }
        public static void findByaAddress()
        {
            Console.Write("Nhap adress can tim: ");
            string address = Console.ReadLine();
            Student x = null;
            foreach (Student item in list)
            {
                if (item.address.CompareTo(address) == 0)
                {
                    x = item;
                }
            }
            if (x != null)
            {
                Console.WriteLine("Thong tin: ");
                x.output();
            }
            else
            {
                Console.WriteLine("dia chi khong ton tai");
            }
        }
        public static void removeById()
        {
            Console.Write("Nhap id can xoa: ");
            int id = int.Parse(Console.ReadLine());
            Student x = null;
            foreach (Student item in list)
            {
                if (item.id.CompareTo(id) == 0)
                {
                    x = item;
                }
            }
            if (x != null)
            {
                list.Remove(x);
                Console.WriteLine("thanh cong ");
            }
            else
            {
                Console.WriteLine("ma id khong ton tai");
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\t\t\t\t==== Menu ====");
                Console.WriteLine("\t\t\t1. Them mot sinh vien");
                Console.WriteLine("\t\t\t2. Hien thi danh sach sinh vien");
                Console.WriteLine("\t\t\t3. Tim kiem sinh vien theo id");
                Console.WriteLine("\t\t\t4. Tim kiem sinh vien theo address");
                Console.WriteLine("\t\t\t5. Xoa mot sinh vien theo id");
                Console.WriteLine("\t\t\t6. Ket thuc chuong trinh\n");
                Console.Write("Nhap lua chon menu: ");
                choose = int.Parse(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        Student x = new Student();
                        x.input();
                        list.Add(x);
                        break;
                    case 2:
                        Student.Title();
                        foreach (var item in list)
                        {
                            item.output();
                        }
                        break;
                    case 3:
                        findById();
                        break;
                    case 4:
                        findByaAddress();
                         break;
                    case 5:
                        removeById();
                        break;
                    case 6:
                        return;


                }
            }
        }
    }
}
