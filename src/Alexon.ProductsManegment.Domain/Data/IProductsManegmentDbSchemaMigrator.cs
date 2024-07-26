using System.Threading.Tasks;

namespace Alexon.ProductsManegment.Data;

public interface IProductsManegmentDbSchemaMigrator
{
    Task MigrateAsync();
}
