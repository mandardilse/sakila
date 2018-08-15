using Microsoft.EntityFrameworkCore;

namespace sakila.core.Db
{
	public class BaseDbContext<T> : DbContext where T : DbContext
	{

	}
}