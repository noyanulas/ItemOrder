using ItemOrder.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ItemOrder;

[DependsOn(
    typeof(ItemOrderEntityFrameworkCoreTestModule)
    )]
public class ItemOrderDomainTestModule : AbpModule
{

}
