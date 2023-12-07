using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webShopSolution.Data.Entities
{
    public class Cart
    {
        public long Id { set; get; }
        public long ProductId { set; get; }
        public int Quantity { set; get; }
        public decimal Price { set; get; }

        public Guid UserId { get; set; }

        public Product Product { get; set; }

        public DateTime DateCreated { get; set; }

        //public AppUser AppUser { get; set; }
    }
}
