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
	public class CategoryService : ICategoryService
	{
		private readonly IUnitOfWork _uow;
		private readonly IMapper _mapper;
		public CategoryService(IUnitOfWork uow, IMapper mapper)
		{
			_uow = uow;
			_mapper = mapper;
		}

		public async Task<IEnumerable<CategoryViewModel>> GetAll()
		{
			var list = await _uow.GetRepository<Category>().GetAllAsync();
			return _mapper.Map<List<CategoryViewModel>>(list);
		}
	}
}
