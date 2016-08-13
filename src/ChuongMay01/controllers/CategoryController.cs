using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChuongMay01.models;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ChuongMay01.controllers
{
    [Route("api/[controller]")]
    public class CategoryController : Controller
    {
        private ChuongMayDBContext _context;

        public CategoryController(ChuongMayDBContext context)
        {
            _context = context;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Category> Get()
        {
            return (_context.Category.ToList());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public IActionResult Post([FromBody]Category category)
        {
                _context.Category.Add(category);
                _context.SaveChanges();
                return new ObjectResult(category);
        }

        /*// POST api/values
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category cat)
        {
            _context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT Category ON");
            //if (ModelState.IsValid)
            //{
                _context.Category.Add(cat);
                _context.SaveChanges();
                return new ObjectResult(cat);
            //}

            //return BadRequest();
        }*/

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
