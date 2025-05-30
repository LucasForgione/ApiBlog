using ApiBlog.Modelos;
using Microsoft.EntityFrameworkCore;

namespace ApiBlog.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {            
        }

        //Agregar los modelos
        public DbSet<Post> Post {  get; set; }
        public DbSet<Usuario> Usuario { get; set; }
    }
    //es un comentario de prueba
    //y este es un comentario desde HUB
}
