using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ItemOrder.Data;

/* This is used if database provider does't define
 * IItemOrderDbSchemaMigrator implementation.
 */
public class NullItemOrderDbSchemaMigrator : IItemOrderDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
