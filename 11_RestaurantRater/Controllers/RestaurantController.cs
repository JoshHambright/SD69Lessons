using _11_RestaurantRater.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;

namespace _11_RestaurantRater.Controllers
{
    public class RestaurantController : ApiController
    {
        private readonly RestaurantDbContext _context = new RestaurantDbContext();

        // Create

        //POST
        [HttpPost]
        public async Task<IHttpActionResult> PostRestaurant(Restaurant model)
        {
            if (ModelState.IsValid)
            {
                _context.Restaurants.Add(model);
                await _context.SaveChangesAsync();

                return Ok();
            }

            return BadRequest(ModelState);

        }

        //Read

        //GET ALL
        [HttpGet]
        public async Task<IHttpActionResult> Get()
        {
            List<Restaurant> restaurants = await _context.Restaurants.ToListAsync();
            return Ok(restaurants);
        }

        //GET BY ID
        [HttpGet]
        public async Task<IHttpActionResult> GetById(int id)
        {
            Restaurant restaurant = await _context.Restaurants.FindAsync(id);

            if (restaurant != null)
            {
                return Ok(restaurant);
            }

            return NotFound(); //404
        }

        //Update

        //Delete
        [HttpDelete]
        public async Task<IHttpActionResult> DeleteRestaurantById(int id)
        {
            Restaurant restaurant = await _context.Restaurants.FindAsync(id);

            if (restaurant == null)
            {
                return NotFound(); //404
            }

            _context.Restaurants.Remove(restaurant);

            if(await _context.SaveChangesAsync() == 1)
            {
                return Ok(); // 200
            }

            return InternalServerError(); //500

        }
    }
}