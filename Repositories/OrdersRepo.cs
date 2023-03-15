using cafe_try_two.Models;
using System.Collections.Generic;
using System.Linq;

namespace cafe_try_two.Repositories
{
    public class OrdersRepo : IOrdersRepo
    {
        private DBContext context;
        public OrdersRepo(DBContext _context)
        {
            context = _context;
        }
        public string AddnewOrder(Orders orders)
        {
            int count = context.Items.Count();
            context.Orders.Add(orders);
            context.SaveChanges();
            int newCount = context.Orders.Count();
            if (newCount > count)
            {
                return "Record inserted successfully";
            }
            else
                return "oops something went wrong while inserting the record"; 
        }

        public List<Orders> GetAllOrders()
        {
            return context.Orders.ToList();
        }

       
    }
}
