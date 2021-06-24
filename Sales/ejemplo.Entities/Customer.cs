using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo.Entities
{
    public class Customer : Entity
    {
        public string Name { get; set; }

        public ICollection<Sale> Sales { get; set; }
    }
}
