using Volo.Abp.Modularity;

namespace lcn.identityserver_management
{
    [DependsOn(
        typeof(identityserver_managementApplicationModule),
        typeof(identityserver_managementDomainTestModule)
        )]
    public class identityserver_managementApplicationTestModule : AbpModule
    {

    }
}
