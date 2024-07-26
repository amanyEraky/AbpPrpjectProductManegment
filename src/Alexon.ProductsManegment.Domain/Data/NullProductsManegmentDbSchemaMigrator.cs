using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Alexon.ProductsManegment.Data;

/* This is used if database provider does't define
 * IProductsManegmentDbSchemaMigrator implementation.
 */
public class NullProductsManegmentDbSchemaMigrator : IProductsManegmentDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
