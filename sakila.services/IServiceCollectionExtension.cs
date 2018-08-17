using Microsoft.Extensions.DependencyInjection;
using sakila.services.Domain;

namespace sakila.services
{
	public static class IServiceCollectionExtension
	{
		public static IServiceCollection AddServiceModule(this IServiceCollection services)
		{
			services.AddTransient<IActorService, ActorService>();
			return services;
		}
	}
}