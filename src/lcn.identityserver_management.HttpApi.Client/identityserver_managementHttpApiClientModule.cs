using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace lcn.identityserver_management
{
    [DependsOn(
        typeof(identityserver_managementApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class identityserver_managementHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "identityserver_management";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(identityserver_managementApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
