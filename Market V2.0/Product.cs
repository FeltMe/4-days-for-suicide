using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_V2._0
{
    class Product : Type
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public Type type = new Type();
        public int AgeLimiter { get; set; }
    }
}
