using BulkyBookWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyBookWeb.Data
{
    //treba nainstalovat EF Core
    public class ApplicationDbContext : DbContext
    {
        // ctor a 2xTab
        //dostanem nejake options a tie dam base classe
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //teraz pridam classu aby z nej vytvorilo tabulku
        public DbSet<Category> Categories { get; set; }
    }
}
