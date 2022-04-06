using System;
using System.Collections.Generic;

namespace NguyenVanHung_2019605562_proj61
{
    class Program
    {
        static List<Student> list = new List<Student>();
        static int choose;

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
                        Console.Write("Nhap id can tim: ");
                        int id = int.Parse(Console.ReadLine());
                        foreach (var item in list) 
                        {
                            if(item. == id)
                            {

                            }
                        }
                        break;

                }
            }
        }
    }
}
