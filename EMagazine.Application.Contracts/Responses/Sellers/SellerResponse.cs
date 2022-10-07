using EMagazine.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMagazine.Application.Contracts.Responses.Sellers
{
    public class SellerResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }


        public ICollection<Car> Cars { get; set; }
        public ICollection<SellerCustomers> SellerCustomers { get; set; }
    }
}
