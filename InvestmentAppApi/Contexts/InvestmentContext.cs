using System.Data.Entity.Infrastructure;
using ASP.NETCoreWebApplication.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;


namespace ASP.NETCoreWebApplication.Contexts
{
    public class InvestmentContext:DbContext
    {
        public InvestmentContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Investment> Investments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Investment>().HasData(
                new Investment
                {
                    InvestmentId = 1, Username = "John", 
                    Amount = 1000, Duration = 5 , InvestmentReturns = 1000 * 5 * 0.3
                }, 
                new Investment
                {
                    InvestmentId = 2, Username = "Mike", 
                    Amount = 2000, Duration = 10 , InvestmentReturns = 2000 * 10 * 0.3
                },new Investment
                {
                    InvestmentId = 3, Username = "Martha", 
                    Amount = 4500, Duration = 6 , InvestmentReturns = 4500 * 6 * 0.3
                },new Investment
                {
                    InvestmentId = 4, Username = "Janet", 
                    Amount = 7500, Duration = 3 , InvestmentReturns = 7500 * 3 * 0.3
                },new Investment
                {
                    InvestmentId = 5, Username = "Ron", 
                    Amount = 1400, Duration = 7 ,InvestmentReturns = 1400 * 7 * 0.3
                }
            );

        }
    }
    
}