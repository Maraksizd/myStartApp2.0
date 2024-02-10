using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myStartApp2._0
{
    internal class Electricity : Service
    {
        private const string ElectricityName = "Electricity";
        private const string ElectricityUnitsType = "kW*h";
        public Electricity(double unitPrice, string company)
        {
            ServiceName = ElectricityName;
            UnitPrice = unitPrice;
            UnitType = ElectricityUnitsType;
            Company = company;
        }
    }
}
