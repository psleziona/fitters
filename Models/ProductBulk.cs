using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitters.Models
{
    internal class ProductBulk : Product, ICalorieCounter
    {
        private int capacity;
        private ProductUnit unit;
        public ProductBulk(string name, double proteins, double carbons, double fats, int capacity, ProductUnit unit) : base(name, proteins, carbons, fats)
        {
            this.unit = unit;
            this.capacity = capacity;
        }
    }
}
