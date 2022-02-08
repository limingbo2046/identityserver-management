using Volo.Abp.Modularity;
using Volo.Abp.Localization;
using lcn.identityserver_management.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Validation;
using Volo.Abp.Validation.Localization;
using Volo.Abp.VirtualFileSystem;

namespace lcn.identityserver_management
{
    [DependsOn(
        typeof(AbpValidationModule)
    )]
    public class identityserver_managementDomainSharedModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<identityserver_managementDomainSharedModule>();
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Add<identityserver_managementResource>("en")
                    .AddBaseTypes(typeof(AbpValidationResource))
                    .AddVirtualJson("/Localization/identityserver_management");
            });

            Configure<AbpExceptionLocalizationOptions>(options =>
            {
                options.MapCodeNamespace("identityserver_management", typeof(identityserver_managementResource));
            });
        }
    }
}
