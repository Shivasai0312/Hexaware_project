using cafe_try_two.Models;
using System.Collections.Generic;

namespace cafe_try_two.Repositories
{
    public interface ICustomerRepo
    {
        
            List<Customers> GetAllCustomers();
        Customers GetCustomersById(int id);
            //List<Customers> GetCustomerseByGender(string Gender);
            string AddnewCustomers(Customers customers);
            string UpdateCustomers(Customers customers);
            string DeleteCustomers(int Custid);

        
    }
}
