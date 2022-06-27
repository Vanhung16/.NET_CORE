using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenVanHung_2019605562_proj63
{
    class Student
    {
        public int studentid { get; set; }
        public string  name { get; set; }
        public string mark { get; set; }

        public Student Equals(int studentId)
        {
            if (this.studentid.CompareTo(studentId)==0){
                return this;
            }
            return null;
        }

        public void InputStudent()
        {
            Console.Write("Nhap student Id: ");
            studentid = int.Parse(Console.ReadLine());
            Console.Write("Nhap ten: ");
            name = Console.ReadLine();
            Console.Write("Nhap mark: ");
            mark = Console.ReadLine();
            

        }
        public override string ToString()
        {
            return string.Format("{0,5}{1,-10}{2,10}", studentid, name, mark);
        }

    }
}
