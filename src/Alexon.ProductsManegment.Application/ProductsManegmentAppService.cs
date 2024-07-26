using System;
using System.Collections.Generic;
using System.Text;
using Alexon.ProductsManegment.Localization;
using Volo.Abp.Application.Services;

namespace Alexon.ProductsManegment;

/* Inherit your application services from this class.
 */
public abstract class ProductsManegmentAppService : ApplicationService
{
    protected ProductsManegmentAppService()
    {
        LocalizationResource = typeof(ProductsManegmentResource);
    }
}
