using Alexon.ProductsManegment.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Alexon.ProductsManegment
{
    public interface IProductAppService : IApplicationService
    {
        Task<List<ProductDto>> GetListAsync();
        Task<ProductDto> GetSingleAsync(int id);
        Task<ProductDto?> CreateAsync(ProductDto productDto);
        Task DeleteAsync(int id);
    }
}
