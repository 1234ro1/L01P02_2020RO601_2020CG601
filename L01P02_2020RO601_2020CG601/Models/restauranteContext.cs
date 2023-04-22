using Microsoft.EntityFrameworkCore;
namespace L01P02_2020RO601_2020CG601.Models
{
    public class restauranteContext : DbContext
    {
        public restauranteContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<pedidos> pedidos { get; set; }
        public DbSet<platos> platos { get; set; }
        public DbSet<motoristas> motoristas { get; set; }
        public DbSet<clientes> clientes { get; set; }
    }
}
