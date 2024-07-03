using BlogProjectApp.Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProjectApp.Entity.Services
{
	public interface ICategoryService
	{
		Task<IEnumerable<CategoryViewModel>> GetAll();
	}
}
