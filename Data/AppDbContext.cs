using Microsoft.EntityFrameworkCore;
using WAppAgroma.Models;

namespace WAppAgroma.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Produit> Produit { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Commande> Commandes { get; set; }
        public DbSet<CommandeDetail> CommandeDetails { get; set; }
        public DbSet<Fournisseur> Fournisseurs { get; set; }
        public DbSet<Employe> Employes { get; set; }
    }
}
