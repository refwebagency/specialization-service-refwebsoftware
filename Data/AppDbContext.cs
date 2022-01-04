using SpecializationService.Models;
using Microsoft.EntityFrameworkCore;

namespace SpecializationService.Data
{
    public class AppDbContext : DbContext
    {
        // Pont entre notre bdd et notre model 
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}

        //On set le model avec le nom de la bdd
        public DbSet<Specialization> Specialization { get; set; }
    }
}