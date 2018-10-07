using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_V2._0
{
    class Market
    {
        const int AgeLimit = 18;
        Dictionary<string, List<Product>> AllProducts = new Dictionary<string, List<Product>>();
       
        public void AddNewProducts(List<Product> temp, string name)
        {
            AllProducts.Add(name, temp);
        }
    }
}
