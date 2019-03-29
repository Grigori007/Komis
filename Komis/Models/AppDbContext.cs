using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Komis.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser> 
    {                                                          
        
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; } 
        public DbSet<Opinion> Opinions { get; set; }
    }
}
