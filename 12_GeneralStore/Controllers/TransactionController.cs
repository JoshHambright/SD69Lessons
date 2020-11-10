using _12_GeneralStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace _12_GeneralStore.Controllers
{
    public class TransactionController : ApiController
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        //Create
        [HttpPost]
        public async Task<IHttpActionResult> Create(Transaction transaction)
        {
            if (ModelState.IsValid)
            {
                Product product = transaction.Product;

                _context.Transactions.Add(transaction);
                await _context.SaveChangesAsync();
                return Ok(); //200
            }
            return BadRequest(ModelState); //400
        }

        //Read
        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            List<Transaction> transactions = await _context.Transactions.ToListAsync();
            return Ok(transactions); //200
        }
    }
}
