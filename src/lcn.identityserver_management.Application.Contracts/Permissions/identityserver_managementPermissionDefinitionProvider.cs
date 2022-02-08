using lcn.identityserver_management.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace lcn.identityserver_management.Permissions
{
    public class identityserver_managementPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(identityserver_managementPermissions.GroupName, L("Permission:identityserver_management"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<identityserver_managementResource>(name);
        }
    }
}