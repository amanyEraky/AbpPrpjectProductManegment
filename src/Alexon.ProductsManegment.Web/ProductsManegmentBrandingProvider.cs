using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Alexon.ProductsManegment.Web;

[Dependency(ReplaceServices = true)]
public class ProductsManegmentBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ProductsManegment";
}
