using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ItemOrder.Data;
using Volo.Abp.DependencyInjection;

namespace ItemOrder.EntityFrameworkCore;

public class EntityFrameworkCoreItemOrderDbSchemaMigrator
    : IItemOrderDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreItemOrderDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the ItemOrderDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<ItemOrderDbContext>()
            .Database
            .MigrateAsync();
    }
}
