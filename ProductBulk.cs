using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitters
{
    internal class ProductBulk : Product
    {
        public ProductBulk(string name, double proteins, double carbons, double fats) : base(name, proteins, carbons, fats)
        {
        }
    }
}
