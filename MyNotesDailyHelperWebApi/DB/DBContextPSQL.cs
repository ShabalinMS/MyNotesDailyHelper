using Microsoft.EntityFrameworkCore;
using MyNotesDailyHelperWebApi.Model;

namespace MyNotesDailyHelperWebApi.DB
{
    public class DBContextPSQL : DbContext
    {
        public DbSet<ContactModel> Contact { get; set; }
        public DbSet<WeightModel> Weight { get; set; }
        public DBContextPSQL()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=MyWeight;Username=postgres;Password=postgres");
        }
    }
}
