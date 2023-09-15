using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers;

[ApiController]
[Route("/api/[controller]/[action]")]
public class TransportationController : Controller
{ 
    public Task<IActionResult> Index()
    {
        throw new NotImplementedException();
    }
}