using ItemOrder.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace ItemOrder.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ItemOrderEntityFrameworkCoreModule),
    typeof(ItemOrderApplicationContractsModule)
    )]
public class ItemOrderDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
