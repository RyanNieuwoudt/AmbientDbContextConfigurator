using EntityFramework.DbContextScope.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AmbientDbContextConfigurator
{
	public abstract class ConfiguringDbContext : DbContext, IDbContext
	{
		protected ConfiguringDbContext()
		{
		}

		protected ConfiguringDbContext(DbContextOptions options) : base(options)
		{
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				AmbientDbContextConfigurator.Current?.Configure(optionsBuilder);
			}
		}
	}
}