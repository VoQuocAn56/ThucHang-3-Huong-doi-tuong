﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau3BaiThucHanh3
{
    class SalesEmployee:SalariedEmployee
    {
        private double commission;
        private double sales;

        public SalesEmployee(string name, int year, int month, int day, double salary, double commission, double sales)
            : base(name,year, month, day, salary)
        {
            this.commission = commission;
            this.sales = sales;
        }

        public override string DisplayStat()
        {
            return base.DisplayStat() + "\n" + string.Format("commission: {0} \nsales:{1}", commission, sales); 
        }
    }
}
