using static cafe_try_two.Repositories.CustomerRepo;
using System.Collections.Generic;
using cafe_try_two.Models;
using System.Linq;

namespace cafe_try_two.Repositories
{
    public class CustomerRepo:ICustomerRepo
    {
            private DBContext context;
            public CustomerRepo(DBContext _context)
            {
                context = _context;
            }  public string AddnewCustomers(Customers customers)
            {
                int count = context.Customers.Count();
                context.Customers.Add(customers);
                context.SaveChanges();
                int newCount = context.Customers.Count();
                if (newCount > count)
                {
                    return "Record inserted successfully";
                }
                else
                    return "oops something went wrong while inserting the record";
            }

            public string DeleteCustomers(int empid)
            {
            Customers emp = context.Customers.Find(empid);
                if (emp != null)
                {
                    context.Customers.Remove(emp);
                    context.SaveChanges();
                    return "Customers removed from Database";

                }
                else
                    return "Given Customers is not available";
            }

            public List<Customers> GetAllCustomers()
            {
                return context.Customers.ToList();
            }

        public Customers GetCustomersById(int id)
        {
            Customers customers= context.Customers.Find(id);
            return customers;
        }

        //public List<Customers> GetCustomersByGender(string gender)
        //{
        //    List<Customers> Customers = context.Customers.Where(d => d.Gender == gender).ToList();
        //    return Customers;
        //}

        public string UpdateCustomers(Customers Customers)
        {
            Customers updateCustomers = context.Customers.Find(Customers.ID);
            if (updateCustomers != null)
            {
                updateCustomers.Name = Customers.Name;
                
                context.Customers.Update(updateCustomers);
                context.SaveChanges();
                return "Customers details updated successfully";
            }
            else
            {
                return "Given Customers is not available to update";
            }
        }

        
    }
}

