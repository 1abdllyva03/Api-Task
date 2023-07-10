using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace api1.Models
{
    public partial class kompContext : DbContext
    {
        public kompContext()
        {
        }

        public kompContext(DbContextOptions<kompContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Alici> Alicis { get; set; }
        public virtual DbSet<Filial> Filials { get; set; }
        public virtual DbSet<Kateqoriya> Kateqoriyas { get; set; }
        public virtual DbSet<Marka> Markas { get; set; }
        public virtual DbSet<Mehsul> Mehsuls { get; set; }
        public virtual DbSet<Model> Models { get; set; }
        public virtual DbSet<Satici> Saticis { get; set; }
        public virtual DbSet<Satish> Satishes { get; set; }
        public virtual DbSet<Test> Tests { get; set; }
        public virtual DbSet<Test1> Tests1 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-FRFBIAD\n;Database=komp;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CI_AS");

            modelBuilder.Entity<Alici>(entity =>
            {
                entity.ToTable("Alici");

                entity.Property(e => e.AliciAd).HasMaxLength(50);

                entity.Property(e => e.AliciFin)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.AliciSoyad).HasMaxLength(50);

                entity.Property(e => e.AliciTelefon).HasMaxLength(13);

                entity.Property(e => e.AliciUnvan).HasMaxLength(100);
            });

            modelBuilder.Entity<Filial>(entity =>
            {
                entity.ToTable("Filial");

                entity.Property(e => e.FilialAd).HasMaxLength(50);
            });

            modelBuilder.Entity<Kateqoriya>(entity =>
            {
                entity.ToTable("Kateqoriya");

                entity.Property(e => e.Ad).HasMaxLength(50);
            });

            modelBuilder.Entity<Marka>(entity =>
            {
                entity.ToTable("Marka");

                entity.Property(e => e.Ad).HasMaxLength(50);
            });

            modelBuilder.Entity<Mehsul>(entity =>
            {
                entity.ToTable("Mehsul");

                entity.HasOne(d => d.Kateqoriya)
                    .WithMany(p => p.Mehsuls)
                    .HasForeignKey(d => d.KateqoriyaId)
                    .HasConstraintName("FK__Mehsul__Kateqori__32E0915F");

                entity.HasOne(d => d.Model)
                    .WithMany(p => p.Mehsuls)
                    .HasForeignKey(d => d.Modelid)
                    .HasConstraintName("FK__Mehsul__Modelid__31EC6D26");
            });

            modelBuilder.Entity<Model>(entity =>
            {
                entity.ToTable("Model");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.HasOne(d => d.Marka)
                    .WithMany(p => p.Models)
                    .HasForeignKey(d => d.MarkaId)
                    .HasConstraintName("FK__Model__MarkaId__2D27B809");
            });

            modelBuilder.Entity<Satici>(entity =>
            {
                entity.ToTable("Satici");

                entity.Property(e => e.SaticiAd).HasMaxLength(50);

                entity.Property(e => e.SaticiFin)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.SaticiSoyad).HasMaxLength(50);

                entity.Property(e => e.SaticiTevellud).HasColumnType("date");

                entity.Property(e => e.SaticiUnvan).HasMaxLength(100);

                entity.HasOne(d => d.FiliAl)
                    .WithMany(p => p.Saticis)
                    .HasForeignKey(d => d.FiliAlId)
                    .HasConstraintName("FK__Satici__FiliAlId__267ABA7A");
            });

            modelBuilder.Entity<Satish>(entity =>
            {
                entity.ToTable("Satish");

                entity.Property(e => e.SatilanTarix).HasColumnType("date");

                entity.HasOne(d => d.Alici)
                    .WithMany(p => p.Satishes)
                    .HasForeignKey(d => d.AliciId)
                    .HasConstraintName("FK__Satish__AliciId__35BCFE0A");

                entity.HasOne(d => d.Mehsul)
                    .WithMany(p => p.Satishes)
                    .HasForeignKey(d => d.MehsulId)
                    .HasConstraintName("FK__Satish__MehsulId__37A5467C");

                entity.HasOne(d => d.Satici)
                    .WithMany(p => p.Satishes)
                    .HasForeignKey(d => d.SaticiId)
                    .HasConstraintName("FK__Satish__SaticiId__36B12243");
            });

            modelBuilder.Entity<Test>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("test");

                entity.Property(e => e.SaticiAd).HasMaxLength(50);
            });

            modelBuilder.Entity<Test1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("tests");

                entity.Property(e => e.Maas).HasColumnName("maas");

                entity.Property(e => e.Pul).HasColumnName("pul");

                entity.Property(e => e.SaticiAd).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
