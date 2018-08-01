using System.Linq;
using System.Threading.Tasks;

namespace sakila.services.Repository
{
	public interface IGenericRepository<T> where T : class
	{
		IQueryable<T> GetAll();
		Task<T> GetById(int id);
		Task Create(T entity);
		Task Update(int id, T entity);
		Task Delete(int id);
	}
}