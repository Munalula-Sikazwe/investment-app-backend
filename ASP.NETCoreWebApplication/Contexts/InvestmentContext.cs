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
                    Amount = 1000, Duration = 5 
                }, 
                new Investment
                {
                    InvestmentId = 2, Username = "Mike", 
                    Amount = 2000, Duration = 10 
                },new Investment
                {
                    InvestmentId = 3, Username = "Martha", 
                    Amount = 4500, Duration = 6 
                },new Investment
                {
                    InvestmentId = 4, Username = "Janet", 
                    Amount = 7500, Duration = 3 
                },new Investment
                {
                    InvestmentId = 5, Username = "Ron", 
                    Amount = 1400, Duration = 7 ,
                }
            );

        }
    }
    
}