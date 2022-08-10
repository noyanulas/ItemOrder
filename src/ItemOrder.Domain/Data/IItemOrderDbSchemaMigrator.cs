using System.Threading.Tasks;

namespace ItemOrder.Data;

public interface IItemOrderDbSchemaMigrator
{
    Task MigrateAsync();
}
