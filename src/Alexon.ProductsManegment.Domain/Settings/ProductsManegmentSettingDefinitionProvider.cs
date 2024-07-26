using Volo.Abp.Settings;

namespace Alexon.ProductsManegment.Settings;

public class ProductsManegmentSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ProductsManegmentSettings.MySetting1));
    }
}
