using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Alexon.ProductsManegment.DALModules
{
    public class ProductCategory : BasicAggregateRoot<int>
    {
        public required string CategoryName { get; set; }
       // public virtual Product Product { get; set; }

    }
}
