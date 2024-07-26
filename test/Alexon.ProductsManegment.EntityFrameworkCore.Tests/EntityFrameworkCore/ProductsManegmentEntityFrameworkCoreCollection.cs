using Xunit;

namespace Alexon.ProductsManegment.EntityFrameworkCore;

[CollectionDefinition(ProductsManegmentTestConsts.CollectionDefinitionName)]
public class ProductsManegmentEntityFrameworkCoreCollection : ICollectionFixture<ProductsManegmentEntityFrameworkCoreFixture>
{

}
