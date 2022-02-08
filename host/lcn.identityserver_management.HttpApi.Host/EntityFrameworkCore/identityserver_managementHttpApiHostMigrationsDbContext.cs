using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace lcn.identityserver_management.EntityFrameworkCore
{
    public class identityserver_managementHttpApiHostMigrationsDbContext : AbpDbContext<identityserver_managementHttpApiHostMigrationsDbContext>
    {
        public identityserver_managementHttpApiHostMigrationsDbContext(DbContextOptions<identityserver_managementHttpApiHostMigrationsDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configureidentityserver_management();
        }
    }
}
