using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace CustomIdentityApp.Data
{
	public class AppDbContext : IdentityDbContext<IdentityUser>
	{
	}
}
