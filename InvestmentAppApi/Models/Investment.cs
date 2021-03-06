using Microsoft.AspNetCore.Mvc;

namespace ASP.NETCoreWebApplication.Models
{
    public class Investment
    {
        public int InvestmentId { get; set; }
        
        public double InvestmentReturns { get; set; }
        public int Duration { get; set; } 
        public int Amount { get; set; }
        [FromRoute(Name = "name")]
        public string Username { get; set; }
    }
}