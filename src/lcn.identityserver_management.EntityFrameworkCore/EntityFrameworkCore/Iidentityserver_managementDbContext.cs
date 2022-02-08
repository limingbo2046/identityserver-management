using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace lcn.identityserver_management.EntityFrameworkCore
{
    [ConnectionStringName(identityserver_managementDbProperties.ConnectionStringName)]
    public interface Iidentityserver_managementDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}