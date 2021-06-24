using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo.Entities
{
    public class Product : Entity
    {
        public decimal Price { get; set; }
        public string Description { get; set; }
        public decimal? Coste { get; set; }

        public virtual ICollection<SaleDetail> SaleDetails { get; set; }
    }
}
