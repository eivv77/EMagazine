using EMagazine.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMagazine.Domain.Entities
{
    public class Car : BaseEntity
    {
        public string FullName { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }


        public int SellerId { get; set; }
        public Seller Seller { get; set; }
    }
}
