using Volo.Abp.Settings;

namespace ItemOrder.Settings;

public class ItemOrderSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ItemOrderSettings.MySetting1));
    }
}
