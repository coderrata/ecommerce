using Microsoft.EntityFrameworkCore;
namespace ecommerce.Models   
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) {}
        public DbSet<User> Users {get;set;}
        public DbSet<CPU> CPUs {get;set;}
        public DbSet<GPU> GPUs {get;set;}
        public DbSet<Motherboard> Motherboards {get;set;}
        public DbSet<Ram> Rams {get;set;}
        public DbSet<PowerSupply> PowerSupplies {get;set;}
    }
}