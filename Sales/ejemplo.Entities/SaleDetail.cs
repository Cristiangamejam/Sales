using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo.Entities
{
    public class SaleDetail : Entity
    {
        public long IdSale { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }
        public long IdProduct { get; set; }
        public virtual Product Product { get; set; }
        public virtual Sale Sale { get; set; }

    }
}
