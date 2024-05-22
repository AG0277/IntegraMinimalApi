using Microsoft.EntityFrameworkCore;

namespace IntegraMinimalApi
{
    public class MinimalApiDb : DbContext
    {
        public MinimalApiDb(DbContextOptions<MinimalApiDb> options ):base(options){ }
        public DbSet<AppUser> AppUsers => Set <AppUser>();

    }
}
