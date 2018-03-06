using InternetBanking.Core.Domain.User;
using System.Data.Entity;

namespace InternetBanking.Data
{
	public class CrudContext : DbContext
	{
		public CrudContext():base()
		{

		}
		public DbSet<User> Users { get; set; }
	}
}