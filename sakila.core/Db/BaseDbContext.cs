using Microsoft.EntityFrameworkCore;

namespace sakila.core.Db
{
	public class BaseDbContext<T> : DbContext where T : DbContext
	{
		/*
		protected override void OnModelCreating()
		{
			ModelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
			ModelBuilder.Conventions.Remove<DecimalPropertyConvention>();
			ModelBuilder.Conventions.Add(new DecimalPropertyConvention(28,8));
		}
		 */
	}
}