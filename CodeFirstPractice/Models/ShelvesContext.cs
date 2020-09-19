using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeFirstPractice.Models
{
    public partial class ShelvesContext : DbContext
    {
        public ShelvesContext()
        {

        }

        public ShelvesContext(DbContextOptions<ShelvesContext> options) : base (options)
        {

        }
        public DbSet<Shelves> MultiShelves { get; set; }

        // Write a program that will take in a shelf name and add it to the database. For example, CreateShelf(“Games Shelf”) or AddShelf(“Movies Shelf”).

        public void CreateShelf(string input)
        {

            //Check against database for no repeat shelf.

            if (MultiShelves.Any(x => x.Name == input))
            {
                Console.WriteLine("This shelf has already been added, please enter another shelf.");
            }
            else
            {
                MultiShelves.Add(new Shelves() { Name = input });
                SaveChanges();
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            // If we aren't already configured.
            if (!optionsBuilder.IsConfigured)
            {
                // Initialize the connection to a MySQL server.
                // Use Entity Framework to create a database called “code_first_practice” using your models.
                optionsBuilder.UseMySql("server=localhost;port=3306;user=root;database=code_first_practice", x => x.ServerVersion("10.4.14-MariaDB")); 
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //will add model creation here
            modelBuilder.Entity<Shelves>(entity =>
            {
            entity.Property(e => e.Name)
                .HasCharSet("utf8mb4")
                .HasCollation("utf8mb4_general_ci");

                entity.HasIndex(e => e.ShelfMaterialID)
                    .HasName("FK_" + nameof(Shelves) + "_" + nameof(ShelfMaterials)); //second problem switcheroo of shelfmaterials shelves

                entity.HasOne(child => child.ShelfMaterials)
                    .WithMany(parent => parent.Shelves)
                    .HasForeignKey(child => child.ShelfMaterialID) //First problem is reference here 
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_" + nameof(Shelves) + "_" + nameof(ShelfMaterials));// change in constraint as well Tammy Setpember 18, 2020 with Bo
                // 'ShelfMaterials' cannot be used as a property on entity type 'Shelves' because it is configured as a navigation.
                // accidentally do database update but actually should be migration first
                // migration remove
                // addm migration secondmigration
                // update database 
            });

            modelBuilder.Entity<ShelfMaterials>(entity =>
            {
                entity.Property(e => e.MaterialName)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            //Call the partial method in case we add some stuff into another file later
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
