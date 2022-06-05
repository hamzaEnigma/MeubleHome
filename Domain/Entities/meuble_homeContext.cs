using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Domain.Entities
{
    public partial class meuble_homeContext : DbContext
    {
        public meuble_homeContext()
        {
        }

        public meuble_homeContext(DbContextOptions<meuble_homeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        public virtual DbSet<ProductProduct> ProductProducts { get; set; }
        public virtual DbSet<SalesCommand> SalesCommands { get; set; }
        public virtual DbSet<SalesCommandDetail> SalesCommandDetails { get; set; }
        public virtual DbSet<TiersAdress> TiersAdresses { get; set; }
        public virtual DbSet<TiersTier> TiersTiers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=meuble_home;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "French_CI_AS");

            modelBuilder.Entity<ProductCategory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Product_Category");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(300)
                    .IsFixedLength(true);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.IdProduit).HasColumnName("Id_produit");

                entity.Property(e => e.Nom)
                    .HasMaxLength(100)
                    .IsFixedLength(true);

                entity.Property(e => e.UpdatedOnDate).HasColumnType("datetime");

                entity.HasOne(d => d.IdProduitNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdProduit)
                    .HasConstraintName("FK_Product_Category_Product_Product");
            });

            modelBuilder.Entity<ProductProduct>(entity =>
            {
                entity.ToTable("Product_Product");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(300)
                    .IsFixedLength(true);

                entity.Property(e => e.Nom)
                    .HasMaxLength(100)
                    .IsFixedLength(true);

                entity.Property(e => e.Prix).HasColumnName("prix");

                entity.Property(e => e.Reference)
                    .HasMaxLength(100)
                    .HasColumnName("reference")
                    .IsFixedLength(true);

                entity.Property(e => e.Stock).HasColumnName("stock");

                entity.Property(e => e.UpdatedOnDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SalesCommand>(entity =>
            {
                entity.ToTable("Sales_Command");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.DateCommande)
                    .HasColumnType("datetime")
                    .HasColumnName("date_commande");

                entity.Property(e => e.IdTiers).HasColumnName("Id_Tiers");

                entity.Property(e => e.Reference)
                    .HasMaxLength(100)
                    .HasColumnName("reference")
                    .IsFixedLength(true);

                entity.Property(e => e.Remise).HasColumnName("remise");

                entity.Property(e => e.UpdatedOnDate).HasColumnType("datetime");

                entity.HasOne(d => d.IdTiersNavigation)
                    .WithMany(p => p.SalesCommands)
                    .HasForeignKey(d => d.IdTiers)
                    .HasConstraintName("FK_Sales_Command_Tiers_tiers");
            });

            modelBuilder.Entity<SalesCommandDetail>(entity =>
            {
                entity.ToTable("Sales_CommandDetail");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.IdCommand).HasColumnName("Id_Command");

                entity.Property(e => e.IdProduct).HasColumnName("Id_Product");

                entity.Property(e => e.PrixUnitaire).HasColumnName("prix_unitaire");

                entity.Property(e => e.Quantite).HasColumnName("quantite");

                entity.Property(e => e.UpdatedOnDate).HasColumnType("datetime");

                entity.HasOne(d => d.IdCommandNavigation)
                    .WithMany(p => p.SalesCommandDetails)
                    .HasForeignKey(d => d.IdCommand)
                    .HasConstraintName("FK_Sales_CommandDetail_Sales_Command");

                entity.HasOne(d => d.IdProductNavigation)
                    .WithMany(p => p.SalesCommandDetails)
                    .HasForeignKey(d => d.IdProduct)
                    .HasConstraintName("FK_Sales_CommandDetail_Product_Product");
            });

            modelBuilder.Entity<TiersAdress>(entity =>
            {
                entity.ToTable("Tiers_Adress");

                entity.Property(e => e.Adresse)
                    .HasMaxLength(100)
                    .IsFixedLength(true);

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.IdTiers).HasColumnName("Id_Tiers");

                entity.Property(e => e.UpdatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.Ville)
                    .HasMaxLength(100)
                    .HasColumnName("ville")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdTiersNavigation)
                    .WithMany(p => p.TiersAdresses)
                    .HasForeignKey(d => d.IdTiers)
                    .HasConstraintName("FK_Tiers_Adress_Tiers_tiers");
            });

            modelBuilder.Entity<TiersTier>(entity =>
            {
                entity.ToTable("Tiers_tiers");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.Nom)
                    .HasMaxLength(100)
                    .IsFixedLength(true);

                entity.Property(e => e.Prenom)
                    .HasMaxLength(100)
                    .HasColumnName("prenom")
                    .IsFixedLength(true);

                entity.Property(e => e.Telephone).HasColumnName("telephone");

                entity.Property(e => e.UpdatedOnDate).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
