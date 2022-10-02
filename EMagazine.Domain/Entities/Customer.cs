using EMagazine.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMagazine.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public ICollection<SellerCustomers> SellerCustomers { get; set; }
    }
}
