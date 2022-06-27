using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De1
{
    public class Employee
    {
        public string name { get; set; }
        public string typeNV { get; set; }
        public string birthday { get; set; }
        public double money { get; set; }

        public Employee() { }

        public Employee(string name, string typeNV, string birthday, double money)
        {
            this.name = name;
            this.typeNV = typeNV;
            this.birthday = birthday;
            this.money = money;
        }
    }
}
