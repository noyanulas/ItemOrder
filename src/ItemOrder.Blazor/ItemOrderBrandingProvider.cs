using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace ItemOrder.Blazor;

[Dependency(ReplaceServices = true)]
public class ItemOrderBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ItemOrder";
}
