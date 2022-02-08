using Volo.Abp.Reflection;

namespace lcn.identityserver_management.Permissions
{
    public class identityserver_managementPermissions
    {
        public const string GroupName = "identityserver_management";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(identityserver_managementPermissions));
        }
    }
}