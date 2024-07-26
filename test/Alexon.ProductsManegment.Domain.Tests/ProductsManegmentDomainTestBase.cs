using Volo.Abp.Modularity;

namespace Alexon.ProductsManegment;

/* Inherit from this class for your domain layer tests. */
public abstract class ProductsManegmentDomainTestBase<TStartupModule> : ProductsManegmentTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
