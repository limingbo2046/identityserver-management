using lcn.identityserver_management.Localization;
using Volo.Abp.Application.Services;

namespace lcn.identityserver_management
{
    public abstract class identityserver_managementAppService : ApplicationService
    {
        protected identityserver_managementAppService()
        {
            LocalizationResource = typeof(identityserver_managementResource);
            ObjectMapperContext = typeof(identityserver_managementApplicationModule);
        }
    }
}
