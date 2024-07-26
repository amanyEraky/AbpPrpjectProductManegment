using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.AuditLogging;
using Volo.Abp.Domain.Entities;
using Volo.Abp.ExceptionHandling;

namespace Alexon.ProductsManegment.DALModules
{
    public class ProductItem: BasicAggregateRoot<int>
    {


     
        public required string Name { get; set; }
        public string? Description { get; set; }

    
    
        public required decimal Price { get; set; }
       //public ICollection<ProductCategory> CategoryIds { get; set; } = new List<ProductCategory>();
        public  required List<int> CategoryIds { get; set; } //= new List<int>();
    }
    public class Product : BasicAggregateRoot<int>
    {



        public required string Name { get; set; }
        public string? Description { get; set; }



        public required decimal Price { get; set; }
        //public ICollection<ProductCategory> CategoryIds { get; set; } = new List<ProductCategory>();
        public required List<int> CategoryIds { get; set; } //= new List<int>();
    }
}
