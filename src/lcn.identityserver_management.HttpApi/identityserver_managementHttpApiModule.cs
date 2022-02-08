using Localization.Resources.AbpUi;
using lcn.identityserver_management.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace lcn.identityserver_management
{
    [DependsOn(
        typeof(identityserver_managementApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class identityserver_managementHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(identityserver_managementHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<identityserver_managementResource>()
                    .AddBaseTypes(typeof(AbpUiResource));
            });
        }
    }
}
