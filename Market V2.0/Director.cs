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
        public string NameProduct { get; set; }
        Market Market = new Market();
        public int CurentMoney { get; set; }
        public int TotalPrice { get; set; }
        public int IndCode = 1111;
        public List<Product> NeedToBuy = new List<Product>();
        public Supplier supplier = new Supplier();

        public Director()
        {
            
        }

        private void Add(string name, List<Product> temp)
        {
            Market.AddNewProducts(temp, name);
        }
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
        public void TotalPricesToBuy()
        {
            foreach (var item in NeedToBuy)
            {
                TotalPrice += item.Price;
            }
        }
        public bool AddProducts(int pin)
        {
            if (pin == IndCode)
            {
                if (TotalPrice > CurentMoney)
                {
                    Console.WriteLine("Not Inaf Money to buy all products");
                    Thread.Sleep(1000);
                    return false;
                }
                else
                {
                    CurentMoney -= TotalPrice;
                    Add(NameProduct, NeedToBuy);
                    return true;
                }
            }
            else
            {
                Console.WriteLine("Eror Pin");
                return false;

            }

        }
    }
}
