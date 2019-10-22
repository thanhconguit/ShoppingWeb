
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public User User { get; set; }
        public virtual List<OrderItem> OrderItems { get; set; }
        public int TotalPrice { get; set; }

    }
}
