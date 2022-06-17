using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }

        public Product()
        {

        }

        public Product(string name, double unitPrice, int quantity)
        {
            this.Name = name;
            this.UnitPrice = unitPrice;
            this.Quantity = quantity;
        }
        public double Total()
        {
            return UnitPrice *= Quantity;
        }
    }
}
