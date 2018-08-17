using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace sakila.core.Db
{
	public class GenericRepository<TContext, TEntity> : IGenericRepository<TEntity>
	where TContext : DbContext, new()
	where TEntity : class
	{
		private TContext _dbContext;
		public GenericRepository(TContext context)
		{
			_dbContext = context;
		}

		public IQueryable<TEntity> EntityDbSet
		{
			get
			{
				IQueryable<TEntity> query = _dbContext.Set<TEntity>();
				return query;
			}
		}

		public void Add(TEntity entity)
		{
			_dbContext.Set<TEntity>().Add(entity);
		}

		public void Delete(TEntity entity)
		{
			_dbContext.Set<TEntity>().Remove(entity);
		}

		public TEntity Find(Expression<Func<TEntity, bool>> predicate)
		{
			return _dbContext.Set<TEntity>().FirstOrDefault(predicate);
		}

		public TEntity FindByKeys(params object[] keyValues)
		{
			return _dbContext.Set<TEntity>().Find(keyValues);
		}
		public void SaveChanges()
		{
			_dbContext.SaveChanges();
		}

		public async Task SaveChangesAsync()
		{
			await _dbContext.SaveChangesAsync();
		}

		public void Update(TEntity entity)
		{
			//_dbContext.Set<TEntity>().State = EntityState.Modified;
		}

		public void UpdateWithEntity(TEntity existingEntity, TEntity modifiedEntity)
		{
			_dbContext.Entry(existingEntity).State = EntityState.Modified;
			_dbContext.Entry(existingEntity).CurrentValues.SetValues(modifiedEntity);
		}
	}
}