using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_V2._0
{
    class Type : Firm
    {
        public string TypeProduct { get; set; }

        public override string ToString()
        {
            return $"Type product = {TypeProduct}";
        }
    }
}
