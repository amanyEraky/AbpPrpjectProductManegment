using Alexon.ProductsManegment.Samples;
using Xunit;

namespace Alexon.ProductsManegment.EntityFrameworkCore.Domains;

[Collection(ProductsManegmentTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<ProductsManegmentEntityFrameworkCoreTestModule>
{

}
