using Alexon.ProductsManegment.DALModules;
using Alexon.ProductsManegment.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Alexon.ProductsManegment.Services
{
    public class ProductCategoryService : ApplicationService, IProductCategoryAppService
    {
        private readonly IRepository<ProductCategory, int> _ProductCategoryRepository;

        public ProductCategoryService(IRepository<ProductCategory, int> ProductCategoryRepository)
        {
            _ProductCategoryRepository = ProductCategoryRepository;
        }


        public async Task<ProductCategoryDTO> CreateAsync(ProductCategoryDTO ProductCategoryDto)
        {
            var item = await _ProductCategoryRepository.InsertAsync(
                new ProductCategory
                {
                 
                    CategoryName = ProductCategoryDto.CategoryName,
                }
            );

            return new ProductCategoryDTO
            {
                Id = item.Id,
             CategoryName = item.CategoryName
            };
        }
  public async Task DeleteAsync(int id)
        {
            try
            {
                await _ProductCategoryRepository.DeleteAsync(id);

            }
            catch (Exception)
            {

                throw;
            }
         
        }

        public async Task<List<ProductCategoryDTO>> GetListAsync()
        {
            var items = await _ProductCategoryRepository.GetListAsync();
            return items
                .Select(item => new ProductCategoryDTO
                {
                    Id = item.Id,
                   CategoryName= item.CategoryName
                }).ToList();
        }

        public async Task<ProductCategoryDTO?> GetSingleAsync(int id)
        {

            var item = await _ProductCategoryRepository.GetAsync(id);
            return  new ProductCategoryDTO
            {
                  Id = item.Id,
                 CategoryName   =item.CategoryName
              };

        }
    }
}
