using System;
using System.Collections.Generic;

namespace sakila.models.Db
{
	public partial class Category
	{
		public Category()
		{
			FilmCategory = new HashSet<FilmCategory>();
		}

		public byte CategoryId { get; set; }
		public string Name { get; set; }
		public DateTime LastUpdate { get; set; }

		public ICollection<FilmCategory> FilmCategory { get; set; }
	}
}
