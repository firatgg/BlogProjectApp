using AutoMapper;
using BlogProjectApp.Entity.Entities;
using BlogProjectApp.Entity.Services;
using BlogProjectApp.Entity.UnitOfWorks;
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
		private readonly IUnitOfWork _uow;
		private readonly IMapper _mapper;

		public ArticleService(IUnitOfWork uow, IMapper mapper)
		{
			_uow = uow;
			_mapper = mapper;
		}

		public async Task<IEnumerable<ArticleViewModel>> GetAll()
		{
			//_uow.GetRepository<Article>(); =>Reoısitory<Artşcle> a karşılık gelir
			var list = await _uow.GetRepository<Article>().GetAllAsync();
			return _mapper.Map<List<ArticleViewModel>>(list);
		}

		public Task Add(ArticleViewModel model)
		{
			throw new NotImplementedException();
		}

		public Task<ArticleViewModel> Get(int id)
		{
			throw new NotImplementedException();
		}

		
	}
}
