using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Employee
    {
        public string eid { get; set; }
        public string name { get; set; }
        public string gender { get; set; }
        public int salary { get; set; }
        public string language { get; set; }
        public Employee()
        {

        }
        public Employee(string eid, string name, string gender, int salary, string language)
        {
            this.eid = eid;
            this.name = name;
            this.gender = gender;
            this.salary = salary;
            this.language = language;
        }
    }
}
