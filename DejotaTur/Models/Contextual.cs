using Microsoft.EntityFrameworkCore;

namespace DejotaTur.Models
{
    public class Contextual : DbContext
    {
        public Contextual(DbContextOptions<Contextual> options) : base(options)
        {

        }
        public DbSet<Destinos> Dests { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
    }
}