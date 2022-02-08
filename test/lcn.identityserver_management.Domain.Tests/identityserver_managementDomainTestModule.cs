using lcn.identityserver_management.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace lcn.identityserver_management
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(identityserver_managementEntityFrameworkCoreTestModule)
        )]
    public class identityserver_managementDomainTestModule : AbpModule
    {
        
    }
}
