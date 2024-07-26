using Alexon.ProductsManegment.Samples;
using Xunit;

namespace Alexon.ProductsManegment.EntityFrameworkCore.Applications;

[Collection(ProductsManegmentTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<ProductsManegmentEntityFrameworkCoreTestModule>
{

}
