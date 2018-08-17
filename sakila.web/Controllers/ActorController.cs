using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using sakila.models.config;
using sakila.models.Db;
using sakila.services.Domain;

namespace sakila.web.Controllers
{
	[Route("api/[controller]")]
	public class ActorController : Controller
	{
		private readonly IOptions<ApplicationSettings> _options;
		private IActorService _actorService;

		public ActorController(IOptions<ApplicationSettings> options, IActorService actorService)
		{
			_options = options;
			_actorService = actorService;
		}

		[HttpGet]
		public IEnumerable<Actor> Get()
		{
			var result = _actorService.GetAllActors();
			return result;
		}
	}
}