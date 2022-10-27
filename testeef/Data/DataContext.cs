using testeef.Models;
using Microsoft.OpenApi;
using Microsoft.AspNetCore;
using Microsoft.EntityFrameworkCore;



namespace testeef.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions opt) : base(opt){

        }
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Category> Categories {get; set; } = null!;

        

    }
}