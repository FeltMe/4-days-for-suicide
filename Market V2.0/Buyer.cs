using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_V2._0
{
    class Buyer
    {
        public int CurentMoney { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        List<Product> products = new List<Product>();
        public int CardMoney { get; set; }
        public int CardPass = 1111;

        public int ReturnCurentMoney()
        {
            return CurentMoney;
        }
        public int ReturnAge()
        {
            return Age;
        }
    }
}
