using Microsoft.AspNetCore.Mvc;
using WebApiForReact.EF;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiForReact.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaleDetailsController : ControllerBase
    {
        public SaleDetailsController()
        {
        }

        // GET: api/<SalesController>
        [HttpGet]
        public IEnumerable<SaleDetail> Get()
        {
            ReactjsDbContext _context = new ReactjsDbContext();
            var list = _context.SaleDetails.ToList();
            return list;
        }

        // GET api/<SalesController>/5
        /*[HttpGet("{id}")]
        public SaleDetail? Get(int id)
        {
            ReactjsDbContext _context = new ReactjsDbContext();
            var model = _context.SaleDetails.Where(x => x.SaleId == id).FirstOrDefault();
            return model;
        }*/

        // GET api/<SalesController>/5
        [HttpGet("{id}")]
        public List<SaleDetail>? Get(int id)
        {
            ReactjsDbContext _context = new ReactjsDbContext();
            var list = _context.SaleDetails.Where(x => x.SaleId == id).ToList();
            return list;
        }

        // POST api/<SalesController>
        [HttpPost]
        public void Post([FromBody] SaleDetail model)
        {
            ReactjsDbContext _context = new ReactjsDbContext();
            _context.SaleDetails.Add(model);
            _context.SaveChanges();
        }

        // PUT api/<SalesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] SaleDetail model)
        {
            ReactjsDbContext _context = new ReactjsDbContext();
            var oSaleDetail = _context.SaleDetails.Where(x => x.SaleDetailId == id).FirstOrDefault();
            if (oSaleDetail != null)
            {
                oSaleDetail.TotalPrice = model.TotalPrice;
                oSaleDetail.UnitPrice = model.UnitPrice;
                oSaleDetail.Quantity = model.Quantity;
                oSaleDetail.Particular = model.Particular;
                oSaleDetail.SaleId = model.SaleId;
                _context.SaveChanges();
            }
        }

        // DELETE api/<SalesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            ReactjsDbContext _context = new ReactjsDbContext();
            var oSaleDetail = _context.SaleDetails.Where(x => x.SaleDetailId == id).FirstOrDefault();
            if (oSaleDetail != null)
            {
                _context.SaleDetails.Remove(oSaleDetail);
                _context.SaveChanges();
            }
        }

    }
}
