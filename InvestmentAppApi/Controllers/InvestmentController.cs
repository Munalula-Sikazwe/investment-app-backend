using System.Linq;
using ASP.NETCoreWebApplication.Contexts;
using ASP.NETCoreWebApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NETCoreWebApplication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InvestmentController : Controller
    {
        private readonly InvestmentContext db;

        public InvestmentController(InvestmentContext db)
        {
            this.db = db;
            
        }
        // GET
        [HttpGet()]
        [Route("/")]
        public IActionResult GetHome()
        {
            return Ok("This is the investment api homepage please use the valid endpoints");
        } 
        [HttpGet()]
        public IActionResult GetInvestments()
        {
            return Ok(db.Investments.ToList());
        } 
        [HttpGet("{id}")]
        public IActionResult GetInvestment([FromRoute]int id)
        {
            var Investment = db.Investments.Find(id);
            if (Investment == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(Investment);
            }
        } 
        [HttpPost()]
        public IActionResult PostInvestment( [FromBody]Investment investment)
        {
            investment.InvestmentReturns = investment.Amount * investment.Duration * 0.30;
            db.Investments.Add(investment);
            db.SaveChanges();
            return Ok(investment.InvestmentReturns);
            
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteInvestment( [FromRoute]int id)
        {
            var investment = db.Investments.Find(id);
            if (investment == null) return NotFound();
            else
            {
                db.Investments.Remove(investment);
                db.SaveChanges();
            }
   
            return Ok(db.Investments.ToList());
            
        }

      
       
    }
}