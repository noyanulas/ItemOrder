using Volo.Abp.Modularity;

namespace ItemOrder;

[DependsOn(
    typeof(ItemOrderApplicationModule),
    typeof(ItemOrderDomainTestModule)
    )]
public class ItemOrderApplicationTestModule : AbpModule
{

}
