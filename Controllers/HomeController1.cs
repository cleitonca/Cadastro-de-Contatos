using Microsoft.AspNetCore.Mvc;

namespace CadastroDeContatos.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
