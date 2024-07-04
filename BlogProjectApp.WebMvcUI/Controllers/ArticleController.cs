using BlogProjectApp.DataAccess.Contexts;
using BlogProjectApp.Entity.Services;
using BlogProjectApp.Entity.ViewModels;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;

namespace BlogProjectApp.WebMvcUI.Controllers
{
	public class ArticleController : Controller
	{
		private readonly IArticleService _articleService;
		private readonly ICommentService _commentService;
		private readonly IAccountService _accountService;

		public ArticleController(IArticleService articleService, ICommentService commentService, IAccountService accountService)
		{
			_articleService = articleService;
			_commentService = commentService;
			_accountService = accountService;
		}

		public async Task<IActionResult> Index(int? id, string? search)
		{
			var list=await _articleService.GetAll();

			if (id!=null)
			{
				list = list.Where(x => x.CategoryId == id).ToList();
			}

			if(search!=null)
			{
				list = list.Where(a => a.Title.ToLower().Contains(search.ToLower().Trim())).ToList();
			}

			return View(list);
		}

		public async Task<IActionResult> Details(int id)
		{
			ViewBag.Comments = await _commentService.GetAllByArticleId(id);
			var model = await _articleService.Get(id);
			return View(model);
		}
		public async Task<IActionResult> CreateComment(string message, int id)
		{
			var user = await _accountService.Find(User.Identity.Name);
			CommentViewModel model = new()
			{
				ArticleId = id,
				Content = message,
			};
			await _commentService.Add(model);
			return RedirectToAction("Index");
		}
	}
}
