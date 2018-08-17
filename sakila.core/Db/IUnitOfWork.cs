using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace sakila.core.Db
{
	public interface IUnitOfWork
	{
		void SaveChanges();
		void SaveChangesAsync();
		//void BeginTransaction();
		//void CommitTransaction();
		//void RollbackTransaction();
		IGenericRepository<TEntity> GetRepository<TEntity>() where TEntity : class;
		//IEnumerable<TModel> ExecuteSqlQuery<TModel>(string sql, params object[] parameters);
		//int ExecuteSqlCommand(string sql, params object[] parameters);
		//List<TResult> ExecuteStoreProcedure<TResult>(string procedureName, Dictionary<string, object> inputParameters, Dictionary<string, object> outputParameters = null);
	}
}