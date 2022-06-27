using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenVanHung_2019605562_proj63
{
    class Course
    {
        public string courseid { get; set; }
        public string coursename { get; set; }
        public int fee { get; set; }
        public List<Student> listStd { get; set; }

        public Course()
        {
            List<Student> li = new List<Student>();
        }
        public void InputCourse()
        {
            Console.Write("Nhap id khoa hoc: ");
            courseid = Console.ReadLine();
            Console.WriteLine("Nhap ten khoa hoc: ");
            coursename = Console.ReadLine();
            Console.WriteLine("Nhap phi khoa hoc: ");
            fee = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so sinh vien");
            int number = int.Parse(Console.ReadLine());
            listStd = new List<Student>();
            for(int i = 0; i < number; i++)
            {
                Student x = new Student();
                x.InputStudent();
                listStd.Add(x);
            }
          
        }
        public void DisplayCourseAndStudents()
        {
            Console.WriteLine("course id: " + courseid);
            Console.WriteLine("course name: " + coursename);
            Console.WriteLine("course fee: " + fee);
            Console.WriteLine("{0,-5}{1,-10}{2,10}","Sid","name","mark");
            foreach(Student item in listStd)
            {
                Console.WriteLine(item.ToString());
            }

        }
        public List<Student> getAllStudent => listStd;

        public override bool Equals(object obj)
        {
            return obj is Course course &&
                   courseid == course.courseid &&
                   coursename == course.coursename &&
                   fee == course.fee &&
                   EqualityComparer<List<Student>>.Default.Equals(listStd, course.listStd);
        }
        public Course Equals(string id)
        {
            Course x = null;
            if (this.courseid.CompareTo(id) == 0)
            {
                x = this;
            }
            return x;
        }
    }
}
