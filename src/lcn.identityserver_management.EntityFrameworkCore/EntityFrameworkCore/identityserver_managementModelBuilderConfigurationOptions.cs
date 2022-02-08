using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace lcn.identityserver_management.EntityFrameworkCore
{
    public class identityserver_managementModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public identityserver_managementModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}