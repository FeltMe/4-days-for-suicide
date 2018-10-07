using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_V2._0
{
    class Firm
    {
        public string FirmName { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }

        public Firm()
        {
            Price = Randomise.Random.NextDouble() * 10000;
        }

        public void SetCount(int Count)
        {
            this.Count = Count;
        }

        public double PriceForWholesale()
        {
            if (Count < 10)
            {
                return Price;
            }
            else if (Count >= 10 && Count <= 100)
            {
                return Price * 0.9;
            }
            else if (Count > 100 && Count <= 1000)
            {
                return Price * 0.8;
            }
            else return Price * 0.7;
        }

        public override string ToString()
        {
            return $"Firm Name = {FirmName}, Curent Count = {Count}, Curent price = {Price}$";
        }

    }
}
