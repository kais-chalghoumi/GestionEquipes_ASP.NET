using GestionEquipes.ApplicationCore.Domain;
using GestionEquipes.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEquipes.Infrastructure
{
    public class GestionEquipesContext: DbContext
    {
        public DbSet<Equipe> Equipe { get; set; }
        public DbSet<Contrat> Contrat { get; set; }
        public DbSet<Entraineur> Entraineur { get; set; }
        public DbSet<Joueur> Joueur { get; set; }
        public DbSet<Membre> Membre { get; set; }
        public DbSet<Trophee> Trophee { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=GestionEquipes;Integrated Security=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ContratConfiguration());
            modelBuilder.Entity<Membre>()
                        .HasDiscriminator<string>("Type")
                        .HasValue<Entraineur>("E")
                        .HasValue<Joueur>("J")
                        .HasValue<Membre>("M");
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
        }

    }
}