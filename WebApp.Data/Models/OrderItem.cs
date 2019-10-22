using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class OrderItem
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int Price { get; set; }
        public Product Product { get; set; }
        public Cart Cart { get; set; }

    }
}
