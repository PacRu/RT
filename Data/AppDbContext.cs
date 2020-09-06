using Microsoft.EntityFrameworkCore;

namespace Web.Data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext( DbContextOptions<AppDbContext> options )
			: base(options)
		{
		}
	}
}
