using Alexon.ProductsManegment.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Alexon.ProductsManegment.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ProductsManegmentController : AbpControllerBase
{
    protected ProductsManegmentController()
    {
        LocalizationResource = typeof(ProductsManegmentResource);
    }
}
