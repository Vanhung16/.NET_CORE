using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenVanHung_2019605562
{
    public class CongNhan
    {
        public CongNhan()
        {
        }

        public string name { get; set; }
        public string gender { get; set; }
        public int numberDate { get; set; }
        public int salary { get; set; }
        public float bonus { get; set; }
        public CongNhan(string name, string gender, int numberDate, int salary)
        {
            this.name = name;
            this.gender = gender;
            this.numberDate = numberDate;
            this.salary = salary;
            if(numberDate > 27)
            {
                bonus = (float)(0.1 * salary);
            }
            else
            {
                bonus = 0;
            }
        }

        public override bool Equals(object obj)
        {
            return obj is CongNhan nhan &&
                   name == nhan.name;
        }

        public override string ToString()
        {
            return name + "-" + gender + "-" + numberDate + "-" + salary + "-" + bonus;
        }
    }
}
