using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RelationshipsTask.Data;
using RelationshipsTask.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RelationshipsTask.Controllers
{
    [Route("api/[controller]/[action]")]
    public class AuthorController : Controller
    {
        private readonly ApplicationDbContext _dB;
        // GET: api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Author>>> Get()
        {
            var authors = await _dB.Authors.ToListAsync();
            if (authors == null)
                return NotFound();
            return Ok(authors);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public async Task<ActionResult<Author>> Post(Author author)
        {
            await _dB.Authors.AddAsync(author);
            await _dB.SaveChangesAsync();
            return Ok(author);
        }

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

