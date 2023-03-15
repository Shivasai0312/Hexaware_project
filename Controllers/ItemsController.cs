using cafe_try_two.Models;
using cafe_try_two.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace cafe_try_two.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly IMenuRepo Repositories = null;
        public  ItemsController(IMenuRepo repo)
        {
            Repositories = repo;
        }
        [HttpGet]
        public ActionResult<List<Items>> Get()
        {
            List<Items> Items = Repositories.GetAllItems();
            if (Items.Count > 0)
            {
                return Items;

            }
            else
            {
                return NotFound();
            }
        }
        [Route("{id:int}")]
        [HttpGet]
        public ActionResult<Items> Get(int id)
        {
            Items Items = Repositories.GetItemsById(id);
            if (Items != null)
            {
                return Items;
            }
            else
            {
                return NotFound();
            }
        }
        //[Route("{location:alpha}")]
        //[HttpGet]
        //public ActionResult<List<Items>> Get(string gender)
        //{
        //    List<Items> Items = Repositories.GetItemsByGender(gender);
        //    if (Items.Count > 0)
        //    {
        //        return Items;
        //    }
        //    else
        //    {
        //        return NotFound();
        //    }
        //}
        [HttpPost]
        public string Post(Items Items)
        {
            string Response = Repositories.AddnewItems(Items);
            return Response;
        }
        [HttpPut]
        public string Put(Items Items)
        {
            string Response = Repositories.UpdateItems(Items);
            return Response;
        }
        [HttpDelete]
        public string Delete(int id)
        {
            string Response = Repositories.DeleteItems(id);
            return Response;
        }
    }
}
