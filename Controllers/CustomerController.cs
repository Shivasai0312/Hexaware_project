using cafe_try_two.Models;
using cafe_try_two.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace cafe_try_two.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        private readonly DBContext _context;
        public CustomerController(DBContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customers>>> GetCustomers()
        {
            return await _context.Customers.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Customers>> GetCustomersById(int id)
        {
            var customers = await _context.Customers.FindAsync(id);
            if (customers == null)
            {
                return NotFound();
            }
            return customers;
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomers(int id, Customers customers)
        {
            if(id!=customers.ID)
            {
                return BadRequest();
            }
            _context.Entry(customers).State=EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch(DbUpdateConcurrencyException)
            {
                if (customers.ID==0)
                    return NotFound();
                else
                    throw;
            }
            return NoContent();
        }
        [HttpPost]
        public async Task<ActionResult<Customers>> PostCustomers(Customers customers)
        {
            _context.Customers.Add(customers);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetCustomers", new { id = customers.ID }, customers);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<Customers>> DeleteCustomer(int id)
        {
            var customers = await _context.Customers.FindAsync(id);
            if(customers==null)
            {
                return NotFound();
            }
            _context.Customers.Remove(customers);
            await _context.SaveChangesAsync();
            return customers;
        }
        //private readonly ICustomerRepo Repositories = null;
        //public CustomerController(ICustomerRepo repo)
        //{
        //    Repositories = repo;
        //}
        //[HttpGet]
        //public ActionResult<List<Customers>> Get()
        //{
        //    List<Customers> Customers = Repositories.GetAllCustomers();
        //    if (Customers.Count > 0)
        //    {
        //        return Customers;

        //    }
        //    else
        //    {
        //        return NotFound();
        //    }
        //}
        //[Route("{id:int}")]
        //[HttpGet]
        //public ActionResult<Customers> Get(int id)
        //{
        //    Customers Customers = Repositories.GetCustomersById(id);
        //    if (Customers != null)
        //    {
        //        return Customers;
        //    }
        //    else
        //    {
        //        return NotFound();
        //    }
        //}
        ////[Route("{location:alpha}")]
        ////[HttpGet]
        ////public ActionResult<List<Customers>> Get(string gender)
        ////{
        ////    List<Customers> Customers = Repositories.GetCustomersByGender(gender);
        ////    if (Customers.Count > 0)
        ////    {
        ////        return Customers;
        ////    }
        ////    else
        ////    {
        ////        return NotFound();
        ////    }
        ////}
        //[HttpPost]
        //public string Post(Customers Customers)
        //{
        //    string Response = Repositories.AddnewCustomers(Customers);
        //    return Response;
        //}
        //[HttpPut]
        //public string Put(Customers Customers)
        //{
        //    string Response = Repositories.UpdateCustomers(Customers);
        //    return Response;
        //}
        //[HttpDelete]
        //public string Delete(int id)
        //{
        //    string Response = Repositories.DeleteCustomers(id);
        //    return Response;
        //}
    }
}

