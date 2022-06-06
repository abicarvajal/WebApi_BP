using Microsoft.EntityFrameworkCore;

namespace APIVS.Models
{
    public class UsuarioContext:DbContext
    {
        public UsuarioContext(DbContextOptions<UsuarioContext> options) : base(options) { }
        public DbSet<Usuario> Usuarios { get; set; } = null!;
        public DbSet<Cuenta> Cuenta { get; set; } = null!;
    }
}
