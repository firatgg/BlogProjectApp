using BlogProjectApp.Entity.Services;
using BlogProjectApp.Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProjectApp.Service.Services
{
	public class ArticleService : IArticleService
	{
		public Task Add(ArticleViewModel model)
		{
			throw new NotImplementedException();
		}

		public Task<ArticleViewModel> Get(int id)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<ArticleViewModel>> GetAll()
		{
			throw new NotImplementedException();
		}
	}
}
