using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMagazine.Domain.Entities
{
    public class SellerCustomers
    {
        public int SellerId { get; set; }
        public Seller Seller { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

    }
}
