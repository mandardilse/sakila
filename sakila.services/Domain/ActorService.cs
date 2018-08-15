using sakila.core.Db;

namespace sakila.services.Domain
{
	public class ActorService
	{
		private readonly IUnitOfWork _uow;

		public ActorService(IUnitOfWork uow)
		{
			_uow = uow;
		}
	}
}