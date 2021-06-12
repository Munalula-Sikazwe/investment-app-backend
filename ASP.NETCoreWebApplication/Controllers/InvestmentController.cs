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
        public IActionResult GetInvestments()
        {
            return Ok(db.Investments.ToList());
        } 
        [HttpGet("{id}")]
        public IActionResult GetInvestment(int id)
        {
            return Ok(db.Investments.ToList());
        } 
        [HttpPost()]
        public IActionResult PostInvestment( [FromBody]Investment investment)
        {
            double returns = investment.Amount * investment.Duration * 0.30;
            return Ok(returns);
            
        }

      
       
    }
}