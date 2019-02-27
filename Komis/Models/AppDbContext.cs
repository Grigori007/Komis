using Microsoft.EntityFrameworkCore;

//klasa jest posrednikiem miedzy kodem a baza danych
namespace Komis.Models
{
    public class AppDbContext : DbContext
    {
        // z pomoca base(options) wywolujemy konkretny konstruktor, z wielu dostepnych, konstruktorow DbContext
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; } // przekazuje klase Car jako parametr do bazy danych
    }
}
