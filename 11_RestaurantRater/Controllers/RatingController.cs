using _11_RestaurantRater.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace _11_RestaurantRater.Controllers
{
    public class RatingController : ApiController
    {
        private readonly RestaurantDbContext _context = new RestaurantDbContext();
        //Create
        [HttpPost]
        public async Task<IHttpActionResult> PostRating(Rating rating)
        {
            if (ModelState.IsValid)
            {
                Restaurant restaurant = await _context.Restaurants.FindAsync(rating.RestaurantId);
                if (restaurant == null) { return BadRequest("There was no restaurant with that ID"); }
                _context.Ratings.Add(rating);
                await _context.SaveChangesAsync();
                return Ok();
            }
            return BadRequest(ModelState);
        }

        //Read
        //GetAll
        [HttpGet]
        public async Task<IHttpActionResult> Get()
        {
            List<RatingWithoutRestaurant> ratings = await _context.Ratings
                .Select(r => new RatingWithoutRestaurant()
                {
                    Id = r.Id,
                    FoodScore = r.FoodScore,
                    CleanlinessScore = r.CleanlinessScore,
                    EnvironmentScore = r.EnvironmentScore,
                    RestaurantId = r.RestaurantId,
                    RestaurantName = r.Restaurant.Name
                }).ToListAsync();

            return Ok(ratings);
        }
        //Get by Restaurant
        [HttpGet]
        public async Task<IHttpActionResult> Get(int id)
        {

            List<Rating> ratings = await _context.Ratings.Where(
                r => r.RestaurantId == id)
                .ToListAsync();
            return Ok(ratings);
        }

        ////GetByID
        //[HttpGet]
        //public async Task<IHttpActionResult> GetById(int id)
        //{
        //    Rating rating = await _context.Ratings.FindAsync(id);

        //    if (rating != null)
        //    {
        //        return Ok(rating);
        //    }
        //    return NotFound();//404
        //}

        //Update
        [HttpPut]
        public async Task<IHttpActionResult> UpdateRating([FromUri] int id, [FromBody] Rating model)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); } //400 
            Rating rating = await _context.Ratings.FindAsync(id);
            
            if(rating == null) { return NotFound(); } //404

            rating.FoodScore = model.FoodScore;
            rating.EnvironmentScore = model.EnvironmentScore;
            rating.CleanlinessScore = model.CleanlinessScore;
            rating.RestaurantId = model.RestaurantId;

            if (await _context.SaveChangesAsync() == 1) { return Ok(); } //200 Success
            return InternalServerError(); //500
        }

        //Delete
        [HttpDelete]
        public async Task<IHttpActionResult> DeleteRatingById(int id)
        {
            Rating rating = await _context.Ratings.FindAsync(id);
            if (rating == null) { return NotFound();  } //404

            _context.Ratings.Remove(rating);

            if(await _context.SaveChangesAsync() == 1) { return Ok(); } //200

            return InternalServerError(); //500
        }
    }
}
