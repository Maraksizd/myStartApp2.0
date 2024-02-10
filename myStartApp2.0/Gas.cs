using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myStartApp2._0
{
    internal class Gas : Service
    {
        private const string GasName = "Gas";
        private const string GasUnitsType = "m^3";
        public Gas(double unitPrice, string company)
        {
            ServiceName = GasName;
            UnitPrice = unitPrice;
            UnitType = GasUnitsType;
            Company = company;
        }
    }
}
