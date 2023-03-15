using cafe_try_two.Models;
using System.Collections.Generic;

namespace cafe_try_two.Repositories
{
    public interface IOrdersRepo
    {
        List<Orders> GetAllOrders();
        string AddnewOrder(Orders orders);

        //Items GetOderById(int id);        
        //List<Items> GetItemseByGender(string Gender);
        //string UpdateOrder(Items Items);
        //string DeleteOrder(int Custid);
    }
}
