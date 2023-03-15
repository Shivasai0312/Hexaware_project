using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace cafe_try_two.Models
{
    public class Orders
    {
        [Key]
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int ItemId { get; set; }
        public decimal  Price { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public ICollection<Customers> Customers { get; set; }
        public ICollection<Items> Items { get; set; }

    }
}
