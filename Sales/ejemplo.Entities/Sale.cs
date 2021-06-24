using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo.Entities
{
    public class Sale : Entity
    {
        public DateTime Fecha { get; set; }
        public decimal? Total { get; set; }

        public int ? IdCustomer { get; set; }

        public virtual ICollection<SaleDetail> SaleDetails { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
