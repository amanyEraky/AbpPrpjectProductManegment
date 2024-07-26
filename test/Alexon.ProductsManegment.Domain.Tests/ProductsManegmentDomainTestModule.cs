using Volo.Abp.Modularity;

namespace Alexon.ProductsManegment;

[DependsOn(
    typeof(ProductsManegmentDomainModule),
    typeof(ProductsManegmentTestBaseModule)
)]
public class ProductsManegmentDomainTestModule : AbpModule
{

}
