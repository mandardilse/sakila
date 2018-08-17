using System.Collections.Generic;
using sakila.models.Db;

namespace sakila.services.Domain
{
	public interface IActorService
	{
		IEnumerable<Actor> GetAllActors();
	}
}