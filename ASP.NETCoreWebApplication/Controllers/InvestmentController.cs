using ASP.NETCoreWebApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NETCoreWebApplication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InvestmentController : Controller
    {
        // GET
        [HttpGet("{name}")]
        public IActionResult GetInvestment( [FromRoute]Investment investment)
        {
            return Ok($"returning all investments from {investment.Username}");
        } 
        [HttpPost()]
        public IActionResult PostInvestment( [FromBody]Investment investment)
        {
            double returns = investment.Amount * investment.Duration * 0.30;
            return Ok($"The investment by {investment.Username} of {investment.Amount} will generate {returns} interest");
            
        }

      
       
    }
}