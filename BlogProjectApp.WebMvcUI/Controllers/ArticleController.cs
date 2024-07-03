using Microsoft.AspNetCore.Mvc;

namespace BlogProjectApp.WebMvcUI.Controllers
{
	public class ArticleController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
