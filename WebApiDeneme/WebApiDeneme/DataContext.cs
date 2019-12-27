using Microsoft.EntityFrameworkCore;

namespace WebApiDeneme
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            for (int i = 1; i <= 1000; i++)
            {
                modelBuilder.Entity<Models.Car>().HasData(new Models.Car()
                {
                    Id = i,
                    Name = "Arabanın Adı"+i,
                    Brand="Arabanın Modeli"+i,
                    Price=20000+i

                });

            }
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Models.Car> Cars { get; set; }
    }
}
