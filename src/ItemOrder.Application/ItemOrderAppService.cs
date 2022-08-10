using System;
using System.Collections.Generic;
using System.Text;
using ItemOrder.Localization;
using Volo.Abp.Application.Services;

namespace ItemOrder;

/* Inherit your application services from this class.
 */
public abstract class ItemOrderAppService : ApplicationService
{
    protected ItemOrderAppService()
    {
        LocalizationResource = typeof(ItemOrderResource);
    }
}
