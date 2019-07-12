using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IdentityServer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ParentsController : ControllerBase
    {
        // GET: api/Parents
        [HttpGet]
        public IEnumerable<string> Get()
        {
            string id = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            switch (id)
            {
                case "514":
                    return new string[] { "Bob's dad", "Bob's mom" };

                case "515":
                    return new string[] { "Jill's dad", "Jill's mom" };

                default:
                    return new string[] { "Unknown user" };
            }
        }

        // GET: api/Parents/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Parents
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Parents/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
