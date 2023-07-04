using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TestDojo.Mocking;

[ApiController]
public class OrderController : ControllerBase
{
    private readonly ILogger _logger;
    private readonly IRepository _repository;

    public OrderController(ILogger logger, IRepository repository)
    {
        _logger = logger;
        _repository = repository;
    }
    
    [HttpPost]
    [Route("api/order")]
    public IActionResult Post(Order order)
    {
        _logger.LogInformation("Order received: {Order}", order);
        
        if (order.Quantity > _repository.InventoryAvailable(order.ProductId))
        {
            _logger.LogError("{FunctionName}: Quantity is too high", nameof(Post));
            return BadRequest("Quantity is too high");
        }
        
        // process order
        
        return Ok();
    }
}

public interface IRepository
{
    int InventoryAvailable(string productId);
    void Save(Order order);
}