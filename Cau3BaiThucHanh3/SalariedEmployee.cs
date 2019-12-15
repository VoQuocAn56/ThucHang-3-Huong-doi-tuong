using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau3BaiThucHanh3
{
    class SalariedEmployee:Employee
    {
        private double salary;

        public SalariedEmployee(string name, int year, int month, int day, double salary)
         : base(name, year, month, day)
        {
            this.salary = salary;
        }

        public override string DisplayStat()
        {
            return base.DisplayStat() + "\n"+ string.Format("salary: {0}", salary);
        }


    }
}
