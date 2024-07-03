using BlogProjectApp.DataAccess.Contexts;
using BlogProjectApp.Entity.Services;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;

namespace BlogProjectApp.WebMvcUI.Controllers
{
	public class ArticleController : Controller
	{
		private readonly IArticleService _articleService;

		public ArticleController(IArticleService articleService)
		{
			_articleService = articleService;
		}

		public async Task<ActionResult> Index(int? id)
		{
			var list=await _articleService.GetAll();

			if (id!=null)
			{
				list = list.Where(x => x.CategoryId == id).ToList();
			}
			return View(list);
		}
	}
}
