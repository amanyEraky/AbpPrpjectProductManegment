using Alexon.ProductsManegment.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Alexon.ProductsManegment
{
    public interface IProductCategoryAppService : IApplicationService
    {
        Task<List<ProductCategoryDTO>> GetListAsync();
        Task<ProductCategoryDTO> GetSingleAsync(int id);
        Task<ProductCategoryDTO?> CreateAsync(ProductCategoryDTO productCategoryDTO);
        Task DeleteAsync(int id);
    }
}
