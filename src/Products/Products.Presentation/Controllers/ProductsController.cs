using Microsoft.AspNetCore.Mvc;

namespace Products.Presentation.Controllers;

[Route("/products")]
[ApiController]
public class ProductsController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetProducts()
    {
        throw new NotImplementedException();
    }
}