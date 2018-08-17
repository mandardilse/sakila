﻿using System;
using System.Collections.Generic;

namespace sakila.models.Db
{
	public partial class Language
	{
		public Language()
		{
			FilmLanguage = new HashSet<Film>();
			FilmOriginalLanguage = new HashSet<Film>();
		}

		public byte LanguageId { get; set; }
		public string Name { get; set; }
		public DateTime LastUpdate { get; set; }

		public ICollection<Film> FilmLanguage { get; set; }
		public ICollection<Film> FilmOriginalLanguage { get; set; }
	}
}
