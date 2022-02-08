using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace lcn.identityserver_management
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(identityserver_managementDomainSharedModule)
    )]
    public class identityserver_managementDomainModule : AbpModule
    {

    }
}
