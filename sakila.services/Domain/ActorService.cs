using System.Collections.Generic;
using System.Linq;
using sakila.core.Db;
using sakila.models.Db;

namespace sakila.services.Domain
{
	public class ActorService : IActorService
	{
		private readonly IUnitOfWork _uow;

		public ActorService(IUnitOfWork uow)
		{
			_uow = uow;
		}

		public IEnumerable<Actor> GetAllActors()
		{
			var repository = _uow.GetRepository<Actor>();
			return repository.EntityDbSet.ToList();
		}
	}
}