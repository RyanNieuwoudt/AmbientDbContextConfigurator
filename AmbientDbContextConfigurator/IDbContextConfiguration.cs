using System;
using Microsoft.EntityFrameworkCore;

namespace AmbientDbContextConfigurator
{
	public interface IDbContextConfiguration
	{
		public Action<DbContextOptionsBuilder> Configure { get; }
	}
}