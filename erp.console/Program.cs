using erp.domain.Abstractions;

public class Program
{
    private readonly IProductRepository _productRepository;

    public Program(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.ReadKey();
    }

    public async Task Execute()
    {
        var products = await _productRepository.GetAll();
        foreach (var product in products)
        {
            Console.WriteLine(product.Name);
        }
    }
}