using Microsoft.AspNetCore.Mvc;

namespace ASP.NETCoreWebApplication.Controllers
{
    [ApiController]
    public class InvestmentController : Controller
    {
        // GET
        [HttpGet]
        [Route("api/investment-returns")]
        public IActionResult GetAll()
        {
            return Ok("returning all investments");
        }

        [HttpGet]
        [Route("api/investment-returns/{id}")]
        public IActionResult GetSingle(int id)
        {
            return Ok($"returning single investment #{id}.");
        }

        [HttpPost]
        [Route("api/investment-returns/")]
        public IActionResult PostSingle()
        {
            return Ok($"returning single investment .");
        }
    }
}