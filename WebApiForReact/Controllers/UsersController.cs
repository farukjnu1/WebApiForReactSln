using Microsoft.AspNetCore.Mvc;
using WebApiForReact.EF;

namespace WebApiForReact.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        public UsersController()
        {
        }

        // GET: api/<SalesController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            ReactjsDbContext _context = new ReactjsDbContext();
            var list = _context.Users.ToList();
            return list;
        }

        // GET api/<SalesController>/5
        [HttpGet("{id}")]
        public User? Get(int id)
        {
            ReactjsDbContext _context = new ReactjsDbContext();
            var model = _context.Users.Where(x => x.Id == id).FirstOrDefault();
            return model;
        }

        // POST api/<SalesController>
        [HttpPost]
        public void Post([FromBody] User model)
        {
            ReactjsDbContext _context = new ReactjsDbContext();
            _context.Users.Add(model);
            _context.SaveChanges();
        }

        // PUT api/<SalesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] User model)
        {
            ReactjsDbContext _context = new ReactjsDbContext();
            var oUser = _context.Users.Where(x => x.Id == id).FirstOrDefault();
            if (oUser != null) 
            {
                oUser.Name = model.Name;
                _context.SaveChanges();
            }
        }

        // DELETE api/<SalesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            ReactjsDbContext _context = new ReactjsDbContext();
            var oUser = _context.Users.Where(x => x.Id == id).FirstOrDefault();
            if (oUser != null)
            {
                _context.Users.Remove(oUser);
                _context.SaveChanges();
            }
        }

    }
}
