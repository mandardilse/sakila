using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sakila.models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using sakila.models.db;

namespace sakila.web.Controllers
{
	[Route("api/[controller]")]
	public class MenuController : Controller
	{
		private readonly sakilaContext _db;

		public MenuController()
		{
			_db = new sakilaContext();
		}
		[HttpGet]
		public async Task<ActionResult<IEnumerable<Menu>>> Get()
		{
			return await _db.Menu.Where(m => m.MenuActive.Equals(true)).ToListAsync();
		}

	}
}