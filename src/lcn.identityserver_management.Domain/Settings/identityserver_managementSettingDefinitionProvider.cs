using Volo.Abp.Settings;

namespace lcn.identityserver_management.Settings
{
    public class identityserver_managementSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            /* Define module settings here.
             * Use names from identityserver_managementSettings class.
             */

            //添加到配置里面
            context.Add(
            new SettingDefinition(Settings.identityserver_managementSettings.SampleName, "默认样本1名称")//这里添加了一个配置和默认值，这样配置了就能用了
            );
        }
    }
}