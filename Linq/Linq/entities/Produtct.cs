using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.entities
{
    internal class Produtct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Category Category { get; set; }

        public override string ToString()
        {
            return 
                Id + " , " 
                + " Nome " + Name + " , " 
                + " Preco " + Price.ToString("F2") + " , " 
                + Category.Name + " , "
                + " Category "  + Category.Tier;
        }
    }
}
