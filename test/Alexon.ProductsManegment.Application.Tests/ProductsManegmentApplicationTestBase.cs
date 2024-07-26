using Volo.Abp.Modularity;

namespace Alexon.ProductsManegment;

public abstract class ProductsManegmentApplicationTestBase<TStartupModule> : ProductsManegmentTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
