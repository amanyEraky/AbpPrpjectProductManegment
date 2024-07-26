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
    public class ProductService : ApplicationService, IProductAppService
    {
        private readonly IRepository<ProductItem, int> _ProductRepository;

        public ProductService(IRepository<ProductItem, int> productRepository)
        {
            _ProductRepository = productRepository;
        }

       
        public async Task<ProductDto?> CreateAsync(ProductDto productDto)
        {
            var item = await _ProductRepository.InsertAsync(
                new ProductItem
                {

                    Name = productDto.Name,
                    Description = productDto.Description,
                    Price = productDto.Price,
                    CategoryIds = productDto.CategoryIds//.Select(cat => new ProductCategory { CategoryName = cat.CategoryName }).ToList()
                }
            );

            return new ProductDto
            {
                Id = item.Id,
                Name = item.Name,
                Description = item.Description,
                Price = item.Price,
                CategoryIds = item.CategoryIds//.Select(cat => new ProductCategoryDTO { CategoryName = cat.CategoryName, Id = cat.Id }).ToList()
            };
        }

        public async Task<ProductDto> UpdateAsync(ProductDto productDto)
        {



            ProductItem? _Product = _ProductRepository.GetListAsync().Result.Where(c => c.Id == productDto.Id).FirstOrDefault();


            if (_Product == null)
                return await CreateAsync(productDto);
            else
            {
                _Product.Name = productDto.Name;
                _Product.Description = productDto.Description;
                _Product.Price = productDto.Price;
                _Product.CategoryIds = productDto.CategoryIds;//.Select(cat => new ProductCategory{ CategoryName = cat.CategoryName }).ToList();
                var item = await _ProductRepository.UpdateAsync(_Product);

                return new ProductDto
                {
                    Id = item.Id,
                    Name = item.Name,
                    Description = item.Description,
                    Price = item.Price,
                    CategoryIds = item.CategoryIds//.Select(cat => new ProductCategoryDTO { CategoryName = cat.CategoryName, Id = cat.Id }).ToList()
                };
            }
        }
        public async Task DeleteAsync(int id)
        {
            try
            {
                await _ProductRepository.DeleteAsync(id);

            }
            catch (Exception)
            {

                throw;
            }
         
        }

        public async Task<List<ProductDto>> GetListAsync()
        {
            var items = await _ProductRepository.GetListAsync();
            return items
                .Select(item => new ProductDto
                {
                    Id = item.Id,
                    Name = item.Name,
                    Description = item.Description,
                    Price = item.Price,
                    CategoryIds = item.CategoryIds//.Select(cat => new ProductCategoryDTO { CategoryName = cat.CategoryName, Id = cat.Id }).ToList()
                }).ToList();
        }

        public async Task<ProductDto?> GetSingleAsync(int id)
        {

            var item = await _ProductRepository.GetAsync(id);
            return new ProductDto
              {
                  Id = item.Id,
                  Name = item.Name,
                  Description = item.Description,
                  Price = item.Price,
                  CategoryIds =  item.CategoryIds//.Select(cat=>new ProductCategoryDTO { CategoryName=cat.CategoryName,Id=cat.Id}).ToList(),
              };

        }
    }
}
