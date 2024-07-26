using Alexon.ProductsManegment.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Alexon.ProductsManegment.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ProductsManegmentEntityFrameworkCoreModule),
    typeof(ProductsManegmentApplicationContractsModule)
    )]
public class ProductsManegmentDbMigratorModule : AbpModule
{
}
