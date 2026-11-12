using Microsoft.EntityFrameworkCore;
using LocationVoitures.Web.Models;

namespace LocationVoitures.Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Table 1 : Segments & Catégories de véhicules
        public DbSet<CategoryVoiture> CategoriesVoitures { get; set; }

        // Table 2 : Flotte de véhicules en location
        public DbSet<Voiture> Voitures { get; set; }
    }
}