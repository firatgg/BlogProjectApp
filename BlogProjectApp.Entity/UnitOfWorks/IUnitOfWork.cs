using BlogProjectApp.Entity.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProjectApp.Entity.UnitOfWorks
{
	public interface IUnitOfWork :IDisposable
	{
		IRepository<T> GetRepository<T>() where T : class,new();
		void Commit();

		Task CommitAsync();
	}
}
