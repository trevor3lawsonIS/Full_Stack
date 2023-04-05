using Microsoft.EntityFrameworkCore;

namespace full_stack_API.Data
{
    public class FoodDbContext : DbContext
    {
        public FoodDbContext (DbContextOptions<FoodDbContext> options) : base(options) { }
        public DbSet<MarriottFood> Foods { get; set; }
    }
}
