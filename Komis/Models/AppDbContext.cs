using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

// ta klasa jest posrednikiem miedzy kodem a baza danych
namespace Komis.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser> // IdentityUser to klasa ktora okesla podstawowe dane ktore bedzie przechowywal uzytkownik np. email, haslo, nr telefonu itp. Klasa ta dziedziczy z DbContext
    {                                                           // Trzeba ja zarejestrowac w kontenerze serwisow w klasie Startup.cs
        // z pomoca base(options) wywolujemy konkretny konstruktor, z wielu dostepnych, konstruktorow DbContext
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; } // przekazuje klase Car jako parametr do bazy danych
        public DbSet<Opinion> Opinions { get; set; }
    }
}
