using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace cleancode.ui.Models
{
    public partial class WorldContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite(@"Filename=/Users/tonymause/Work/repos/cleancode/cleancode.ui/world.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>(entity =>
            {
                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasColumnType("char(3)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.District)
                    .IsRequired()
                    .HasColumnType("char(20)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("char(35)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Population)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.HasOne(d => d.CountryCodeNavigation).WithMany(p => p.City).HasForeignKey(d => d.CountryCode).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code).HasColumnType("char(3)");

                entity.Property(e => e.Capital)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Code2)
                    .IsRequired()
                    .HasColumnType("char(2)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Continent)
                    .IsRequired()
                    .HasColumnType("char(15)")
                    .HasDefaultValueSql("'Asia'");

                entity.Property(e => e.GNP)
                    .HasColumnType("float(10,2)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.GNPOld)
                    .HasColumnType("float(10,2)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.GovernmentForm)
                    .IsRequired()
                    .HasColumnType("char(45)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.HeadOfState)
                    .HasColumnType("char(60)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IndepYear)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.LifeExpectancy)
                    .HasColumnType("float(3,1)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.LocalName)
                    .IsRequired()
                    .HasColumnType("char(45)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("char(52)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Population)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Region)
                    .IsRequired()
                    .HasColumnType("char(26)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SurfaceArea)
                    .HasColumnType("float(10,2)")
                    .HasDefaultValueSql("'0.00'");
            });

            modelBuilder.Entity<CountryLanguage>(entity =>
            {
                entity.HasKey(e => new { e.CountryCode, e.Language });

                entity.Property(e => e.CountryCode)
                    .HasColumnType("char(3)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Language)
                    .HasColumnType("char(30)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IsOfficial)
                    .IsRequired()
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("'F'");

                entity.Property(e => e.Percentage)
                    .HasColumnType("float(4,1)")
                    .HasDefaultValueSql("'0.0'");

                entity.HasOne(d => d.CountryCodeNavigation).WithMany(p => p.CountryLanguage).HasForeignKey(d => d.CountryCode).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Stop>(entity =>
            {
                entity.Property(e => e.Arrival).IsRequired();

                entity.HasOne(d => d.Trip).WithMany(p => p.Stop).HasForeignKey(d => d.TripId);
            });

            modelBuilder.Entity<Trip>(entity =>
            {
                entity.Property(e => e.Created).IsRequired();
            });

            modelBuilder.Entity<__EFMigrationsHistory>(entity =>
            {
                entity.HasKey(e => e.MigrationId);

                entity.Property(e => e.ProductVersion).IsRequired();
            });
        }

        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<CountryLanguage> CountryLanguage { get; set; }
        public virtual DbSet<Stop> Stop { get; set; }
        public virtual DbSet<Trip> Trip { get; set; }
        public virtual DbSet<__EFMigrationsHistory> __EFMigrationsHistory { get; set; }

        // Unable to generate entity type for table 'ContinentTable'. Please see the warning messages.
        // Unable to generate entity type for table 'TrueFalseTable'. Please see the warning messages.
    }
}