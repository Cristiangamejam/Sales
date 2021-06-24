using ejemplo.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejemplo.Webapi.Request
{
    public class SalesRequest
    {
        
        public decimal Total { get; set; }

        public List<SaleDetailRequest> oSaleDetailRequests { get; set; }

        public SalesRequest()
        {
            oSaleDetailRequests = new List<SaleDetailRequest>();
        }
    }

    public class SaleDetailRequest
    {
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }
        public long IdProduct { get; set; }
    }
 
}
