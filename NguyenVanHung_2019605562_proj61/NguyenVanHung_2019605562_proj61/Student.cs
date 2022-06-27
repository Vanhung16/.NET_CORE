using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenVanHung_2019605562_proj61
{
    class Student:Person,IComparable
    {
        public byte maths { get; set; }
        public byte physics { get; set; }

        public Student()
        {
        }

        public Student(int id, string name, string address, byte maths, byte physics):base(id, name, address)
        {
            this.maths = maths;
            this.physics = physics;
        }

        public override void input()
        {
            base.input();
            Console.WriteLine("Nhap diem toan: ");
            maths = byte.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem ly: ");
            physics = byte.Parse(Console.ReadLine());
        }

        public override void output()
        {
            base.output();
            Console.WriteLine("{0,15}{1,15}{2,15}",maths, physics, Total());
        }
        public byte Total()
        {
            return (byte)(maths + physics);
        }
        public static void Title()
        {
            Person.Title();
            Console.WriteLine("{0,15}{1,15}{2,15}", "maths", "Physics", "Total point");

        }

        public int CompareTo(object obj)
        {
            Student x = (Student)obj;
            return this.id.CompareTo(x.id);
        }
    }
    class findById : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return x.id.CompareTo(y.id);
        }
    }
}
