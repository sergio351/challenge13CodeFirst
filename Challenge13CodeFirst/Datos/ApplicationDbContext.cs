using Challenge13CodeFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace Challenge13CodeFirst.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options): base(options)
        {
                
        }
        //usar los modelos 
        public DbSet<Producto> Producto { get; set; }
    }
}
