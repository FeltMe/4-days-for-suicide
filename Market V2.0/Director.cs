using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Market_V2._0
{
    class Director
    {
        public int IndCode = 1111;
        public List<Product> NeedToBuy = new List<Product>();
        public Supplier supplier = new Supplier();

        public void SetListToBuy(List<Product> temp, int code)
        {
            if (this.IndCode == code)
            {
                this.NeedToBuy = temp;
            }
            else
            {
                Console.WriteLine("Eror Pin");
                Thread.Sleep(1000);
            } 
        }

    }
}
