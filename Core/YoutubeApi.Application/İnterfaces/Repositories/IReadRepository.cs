using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using YoutubeApi.Domein.Commen;

namespace YoutubeApi.Application.İnterfaces.Repositories
{
	public interface IReadRepository<T> where T : class, IEntityBase, new()
	{
		Task<IList<T>> GetAllAsync(Expression<Func<T, bool>>? predicate = null, 
			Func<IQueryable<T>,IIncludableQueryable<T, object>>? include = null,
			Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
			bool enableTracking = false);

		Task<IList<T>> GetAllAsyncByPagingAsync(Expression<Func<T, bool>>? predicate = null,
			Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null,
			Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
			bool enableTracking = false, int currentPage = 1, int pageSize = 3); // Burada 1. sayfadaki ilk 3 veriyi alaca

		Task<T> GetAsync(Expression<Func<T, bool>> predicate, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null,
			Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, 
			bool enableTracking = false);

		IQueryable<T> Find(Expression<Func<T, bool>> predicate, bool enableTracking = false);

		Task<int> CountAsync(Expression<Func<T, bool>>? predicate = null);
	
	}
}
