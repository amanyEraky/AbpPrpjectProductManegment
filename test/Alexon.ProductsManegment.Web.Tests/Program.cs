using Microsoft.AspNetCore.Builder;
using Alexon.ProductsManegment;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<ProductsManegmentWebTestModule>();

public partial class Program
{
}
