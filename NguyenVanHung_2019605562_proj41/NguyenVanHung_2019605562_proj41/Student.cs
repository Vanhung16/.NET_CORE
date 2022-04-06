using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenVanHung_2019605562_proj41
{
    class Student
    {
        private string id { get; set; }
        private string  name { get; set; }
        private int mark { get; set; }
        private int scholarship
        { 
            get {
                if(mark > 8) { return 500; }
                else if(mark >= 7) { return 300; }
                else { return 0; }
            }
        }

        public Student() { }
        public Student(string id, string name, int mark)
        {
            this.id = id;
            this.name = name;
            this.mark = mark;
        }
        public Student(string id)
        {
            this.id = id;
        }
        public override string ToString()
        {
            return string.Format("{0,-8}{1,-15}{2,-15}{3,20}", id, name, mark, scholarship);
        }
    }
}
