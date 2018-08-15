using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using sakila.models.config;

namespace sakila.web.Controllers
{
	[Route("api/[controller]")]
	public class ActorController : Controller
	{
		private readonly IOptions<ApplicationSettings> _options;
		public ActorController(IOptions<ApplicationSettings> options)
		{
			_options = options;
		}

		[HttpGet]
		public ActionResult Get()
		{
			return Ok(true);
		}
	}
}