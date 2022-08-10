using ItemOrder.Localization;
using Volo.Abp.AspNetCore.Components;

namespace ItemOrder.Blazor;

public abstract class ItemOrderComponentBase : AbpComponentBase
{
    protected ItemOrderComponentBase()
    {
        LocalizationResource = typeof(ItemOrderResource);
    }
}
