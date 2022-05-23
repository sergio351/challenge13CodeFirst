using Challenge13CodeFirst.Datos;
using Challenge13CodeFirst.Models;

namespace Challenge13CodeFirst.Repository
{
    public class ProductoRepository : GenericRepository<Producto>
    {

        public ProductoRepository(ApplicationDbContext dbcontext) : base(dbcontext)
        {
        }

        public void agregar(Producto producto)
        {
            Add(producto);
            save();
        }

    }
}
