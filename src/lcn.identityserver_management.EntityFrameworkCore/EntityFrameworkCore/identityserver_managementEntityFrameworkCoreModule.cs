using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Dapper;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace lcn.identityserver_management.EntityFrameworkCore
{
    [DependsOn(
        typeof(identityserver_managementDomainModule),
        typeof(AbpEntityFrameworkCoreModule)
    )]

    [DependsOn(typeof(AbpDapperModule))]
    public class identityserver_managementEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<identityserver_managementDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
                options.AddDefaultRepositories(includeAllEntities: true);//该配置是为继承Entity的类添加仓存注入
            });
        }
    }
}