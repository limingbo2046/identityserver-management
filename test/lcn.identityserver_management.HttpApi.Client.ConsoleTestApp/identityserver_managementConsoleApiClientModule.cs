using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace lcn.identityserver_management
{
    [DependsOn(
        typeof(identityserver_managementHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class identityserver_managementConsoleApiClientModule : AbpModule
    {
        
    }
}
