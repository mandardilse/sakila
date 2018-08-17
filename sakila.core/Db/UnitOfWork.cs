using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace sakila.core.Db
{
	public class UnitOfWork<TContext> : IDisposable, IUnitOfWork where TContext : DbContext, new()
	{
		private Dictionary<string, IRepository> _repository;
		private readonly TContext _dbContext;
		//private IDbTransaction _transaction;

		public UnitOfWork()
		{
			_dbContext = new TContext();
		}

		public IGenericRepository<TEntity> GetRepository<TEntity>() where TEntity : class
		{
			if (_repository == null)
				_repository = new Dictionary<string, IRepository>();

			var repositoryName = typeof(TEntity).Name;
			if (!_repository.ContainsKey(repositoryName))
			{
				var repositoryType = typeof(GenericRepository<,>);
				var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(TContext), typeof(TEntity)), _dbContext);
				_repository.Add(repositoryName, repositoryInstance as IRepository);
			}
			return (IGenericRepository<TEntity>)_repository[repositoryName];
		}

		/*
		public void BeginTransaction()
		{
			var _objectContext = ((IObjectContextAdaptor)_dbContext).ObjectContext;
			if (_objectContext.Connection.State != ConnectionState.Open)
			{
				_objectContext.Connection.Open();
				if (_transaction != null)
				{
					_transaction.Dispose();
				}
				_transaction = objectContext.Connection.BeginTransaction();
			}
		}
        */
		/*
		public void CommitTransaction()
		{
			_transaction.Commit();
		}
        */
		/*
		public void RollbackTranscation()
		{
			_transaction.Rollback();
		}
        */
		private bool disposed = false;
		protected virtual void Dispose(bool disposing)
		{
			if (!disposed)
			{
				if (disposing)
				{
					_dbContext.Dispose();
				}
			}
			disposing = true;
		}
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		public void SaveChanges()
		{
			_dbContext.SaveChanges();
		}

		public void SaveChangesAsync()
		{
			_dbContext.SaveChangesAsync();
		}
	}
}