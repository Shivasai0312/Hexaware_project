using System.Collections.Generic;

namespace cafe_try_two.Models
{
    public class Bill
    {
        public int BillId { get; set; }
        public string CustId { get; set;}
        public decimal TotalAmount { get; set; }
        public ICollection<Customers> Customers { get; set; }
    }
}
