using Microsoft.AspNetCore.Mvc;
using lcn.identityserver_management.Localization;
using Volo.Abp;
using Volo.Abp.AspNetCore.Mvc;

namespace lcn.identityserver_management
{
    //[Area(ControllerConst.ModuleName)]
    //[RemoteService(Name = ControllerConst.ModuleName)]
    //[Route(ControllerConst.ModuleName)]//该路由会放在url的第一位
    [RemoteService]
    public abstract class identityserver_managementController : AbpController
    {
        protected identityserver_managementController()
        {
            LocalizationResource = typeof(identityserver_managementResource);
        }
    }

    public static class ControllerConst
    {
        public const string ModuleName = "identityserver_management";//模块的缩写，用在版本号的前面，不再使用api前缀
    }
}
