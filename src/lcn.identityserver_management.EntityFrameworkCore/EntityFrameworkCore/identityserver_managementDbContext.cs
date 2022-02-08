using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace lcn.identityserver_management.EntityFrameworkCore
{
    [ConnectionStringName(identityserver_managementDbProperties.ConnectionStringName)]
    public class identityserver_managementDbContext : AbpDbContext<identityserver_managementDbContext>, Iidentityserver_managementDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */

        public identityserver_managementDbContext(DbContextOptions<identityserver_managementDbContext> options)
            : base(options)
        {

        }

    
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Configureidentityserver_management();
        }
    }
}