using Microsoft.EntityFrameworkCore;
namespace L01P02_2020RO601_2020CG601.Models
{
    public class restauranteContext : DbContext
    {
        public restauranteContext(DbContextOptions options) : base(options)
        {
        }
    }
}
