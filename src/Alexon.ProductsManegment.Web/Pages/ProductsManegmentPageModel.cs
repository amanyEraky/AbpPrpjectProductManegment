using Alexon.ProductsManegment.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Alexon.ProductsManegment.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class ProductsManegmentPageModel : AbpPageModel
{
    protected ProductsManegmentPageModel()
    {
        LocalizationResourceType = typeof(ProductsManegmentResource);
    }
}
