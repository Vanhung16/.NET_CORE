using System;
using System.Collections.Generic;

namespace NguyenVanHung_2019605562_proj63
{
    class Program
    {
        static int choose;
        static List<Course> ds = new List<Course>();
        public static void nhap()
        {
            Course x = new Course();
            x.InputCourse();
            ds.Add(x);
        }
        public static void hienthi()
        {
            foreach(Course item in ds)
            {
                Console.WriteLine("--------------Thong tin khoa hoc--------------");
                item.DisplayCourseAndStudents();
            }
        }
        public static void findById()
        {
            Console.Write("Nhap ma khoa hoc can tim\n---------->");
            string CourseId = Console.ReadLine();

            foreach(Course item in ds)
            {
                if(item.Equals(CourseId) != null)
                {
                    item.DisplayCourseAndStudents();
                }
            }
        }

        public static void findStudentByStudentId()
        {
            Console.Write("Nhap ma sinh vien\n------>");
            string id = Console.ReadLine();
            Student x = null;
            foreach (Course item in ds)
            {
                foreach (var item2 in item.listStd) 
                {
                    if(item2.Equals(id) != null)
                    {
                        x = item2;
                    }
                }
            }
            if (x != null)
            {
                Console.WriteLine("{0,-5}{1,-10}{2,10}", "Sid", "name", "mark");
                Console.WriteLine(x.ToString());
            }
            else
            {
                Console.WriteLine("Khong tim thay sinh vien");
            }
        }
        public static void removeStudent()
        {
            Console.Write("Nhap ma khoa hoc can xoa\n------>");
            string courseId = Console.ReadLine();
            Course x = null;
            foreach(Course item in ds)
            {
                if(item.Equals(courseId) != null)
                {
                    x = item;
                }
            }
            if(x != null)
            {
                ds.Remove(x);
                Console.WriteLine("xoa thanh cong");
            }
            else
            {
                Console.WriteLine("Khong co ma khoa hoc nay trong ds");
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\t\tNhap lua chon chuc nang");
                Console.WriteLine("\t\t1.Nhap 1 khoa hoc");
                Console.WriteLine("\t\t2.Hien thi khoa hoc");
                Console.WriteLine("\t\t3.Tim kiem khoa hoc");
                Console.WriteLine("\t\t4.Tim kiem sinh vien");
                Console.WriteLine("\t\t5.Xoa 1 khoa hoc");
                Console.WriteLine("\t\t6.Ket thuc chuong trinh");
                Console.WriteLine("Nhap lua chon: ");
                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        nhap();
                        break;
                    case 2:
                        hienthi();
                        break;
                    case 3:
                        findById();
                        break;
                    case 4:
                        findStudentByStudentId();
                        break;
                    case 5:
                        removeStudent();
                        break;
                    case 6:
                        return;
                }
            }
        }
    }
}
