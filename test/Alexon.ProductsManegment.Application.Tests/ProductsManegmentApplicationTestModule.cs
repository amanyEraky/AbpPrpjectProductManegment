using Volo.Abp.Modularity;

namespace Alexon.ProductsManegment;

[DependsOn(
    typeof(ProductsManegmentApplicationModule),
    typeof(ProductsManegmentDomainTestModule)
)]
public class ProductsManegmentApplicationTestModule : AbpModule
{

}
