using Microsoft.Extensions.DependencyInjection;
using sakila.core.Db;

namespace sakila.core
{
	public static class IServiceCollectionExtension
	{
		public static IServiceCollection AddCoreModule(this IServiceCollection services)
		{
			services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<,>));
			services.AddTransient(typeof(IUnitOfWork), typeof(UnitOfWork<>));
			return services;
		}
	}
}