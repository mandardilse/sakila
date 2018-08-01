using System.Linq;
using System.Threading.Tasks;

namespace sakila.services.Repository
{
	public class GenericRepository<T> : IGenericRepository<T> where T : class
	{
		public Task Create(T entity)
		{
			throw new System.NotImplementedException();
		}

		public Task Delete(int id)
		{
			throw new System.NotImplementedException();
		}

		public IQueryable<T> GetAll()
		{
			throw new System.NotImplementedException();
		}

		public Task<T> GetById(int id)
		{
			throw new System.NotImplementedException();
		}

		public Task Update(int id, T entity)
		{
			throw new System.NotImplementedException();
		}
	}
}