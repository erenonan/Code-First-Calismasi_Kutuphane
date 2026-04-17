using Microsoft.EntityFrameworkCore;

namespace Code_First_Calismasi.Models
{
    public class KitapContext : DbContext
    {
        public KitapContext(DbContextOptions<KitapContext>options) : base(options) 
        { 
        }

        public DbSet<Kitap> Kitaplar    { get; set; }
    }
}
