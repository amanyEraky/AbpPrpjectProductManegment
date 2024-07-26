using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alexon.ProductsManegment.DTO
{
    public class ProductDto
    {
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "you should set name")]
        public required string Name { get; set; }
        public string? Description { get; set; }


        [Range(0.0, (double)Decimal.MaxValue, ErrorMessage = "You should set Positive value")]
        public required decimal Price { get; set; }
        // [RuleCriteria("TestClass-Languages", DefaultContexts.Save, "CategoryIds.Count > 0", CustomMessageTemplate = "Must add at least one Category.")]
        [MinLength(1, ErrorMessage = "You should add at least one Category")]
        public  List<int> CategoryIds { get; set; } = new List<int>();
       // public  ICollection<ProductCategoryDTO> CategoryIds { get; set; } = new List<ProductCategoryDTO>();

    }

}
