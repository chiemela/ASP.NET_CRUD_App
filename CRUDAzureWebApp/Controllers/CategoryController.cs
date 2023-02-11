using Microsoft.AspNetCore.Mvc;

namespace CRUDAzureWebApp.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
