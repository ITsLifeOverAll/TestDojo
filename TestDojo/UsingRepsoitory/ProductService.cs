namespace TestDojo.UsingRepsoitory;

public class ProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public Product[] GetAllProducts()
    {
        return _productRepository.GetAllProducts();
    }

    public Product GetProduct(string id)
    {
        try
        {
            var result =  _productRepository.GetProduct(id);
            return result;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}

public interface IProductRepository
{
    Product[] GetAllProducts();
    Task<Product> GetProductAsync(string id);
    Product GetProduct(string id);
    Task<Product[]> GetAllProductsAsync();
}

public class Product
{
    public string? Id { get; set; }
    public string? Name { get; set; }
}