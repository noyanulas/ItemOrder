using ItemOrder.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ItemOrder.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ItemOrderController : AbpControllerBase
{
    protected ItemOrderController()
    {
        LocalizationResource = typeof(ItemOrderResource);
    }
}
