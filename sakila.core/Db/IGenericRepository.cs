using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace sakila.core.Db
{
	public interface IGenericRepository<T> : IRepository where T : class
	{
		IQueryable<T> EntityDbSet { get; }
		T Find(Expression<Func<T, bool>> predicate);
		T FindByKeys(params object[] keyValues);
		void UpdateWithEntity(T existingEntity, T modifiedEntity);
		void Add(T entity);
		void Delete(T entity);
		void Update(T entity);
		void SaveChanges();
		Task SaveChangesAsync();
	}
}