using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace lcn.identityserver_management
{
    [DependsOn(
        typeof(identityserver_managementDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class identityserver_managementApplicationContractsModule : AbpModule
    {

    }
}
