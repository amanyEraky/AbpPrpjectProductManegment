using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Alexon.ProductsManegment.Pages;

public class Index_Tests : ProductsManegmentWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
