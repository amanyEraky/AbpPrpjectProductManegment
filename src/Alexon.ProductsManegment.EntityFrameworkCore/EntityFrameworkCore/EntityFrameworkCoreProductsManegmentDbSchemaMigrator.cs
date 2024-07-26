using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Alexon.ProductsManegment.Data;
using Volo.Abp.DependencyInjection;

namespace Alexon.ProductsManegment.EntityFrameworkCore;

public class EntityFrameworkCoreProductsManegmentDbSchemaMigrator
    : IProductsManegmentDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreProductsManegmentDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the ProductsManegmentDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<ProductsManegmentDbContext>()
            .Database
            .MigrateAsync();
    }
}
