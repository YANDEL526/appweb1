using appweb1.model;
using Microsoft.EntityFrameworkCore;

namespace appweb1.data
{
    public class AppDbContext:DbContext
    {
         public AppDbContext(DbContextOptions<AppDbContext> options):base(options){}

         public DbSet<Cliente> Clientes {get ; set;}              
    }
}





