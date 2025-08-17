using Microsoft.AspNetCore.Mvc;
using WebApiForReact.EF;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiForReact.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        public SalesController()
        {
        }

        // GET: api/<SalesController>
        [HttpGet]
        public IEnumerable<Sale> Get()
        {
            ReactjsDbContext _context = new ReactjsDbContext();
            var list = _context.Sales.ToList();
            return list;
        }

        // GET api/<SalesController>/5
        [HttpGet("{id}")]
        public Sale? Get(int id)
        {
            ReactjsDbContext _context = new ReactjsDbContext();
            var model = _context.Sales.Where(x => x.SaleId == id).FirstOrDefault();
            return model;
        }

        // POST api/<SalesController>
        [HttpPost]
        public void Post([FromBody] Sale model)
        {
            ReactjsDbContext _context = new ReactjsDbContext();
            _context.Sales.Add(model);
            _context.SaveChanges();
        }

        // PUT api/<SalesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Sale model)
        {
            ReactjsDbContext _context = new ReactjsDbContext();
            var oSale = _context.Sales.Where(x => x.SaleId == id).FirstOrDefault();
            if (oSale != null)
            {
                oSale.CustomerName = model.CustomerName;
                oSale.Description = model.Description;
                oSale.Date = model.Date;
                _context.SaveChanges();
            }
        }

        // DELETE api/<SalesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            ReactjsDbContext _context = new ReactjsDbContext();
            var oSale = _context.Sales.Where(x => x.SaleId == id).FirstOrDefault();
            if (oSale != null)
            {
                _context.Sales.Remove(oSale);
                _context.SaveChanges();
            }
        }

    }
}
