using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace api1.Models
{
    public partial class newContext : DbContext
    {
        public newContext()
        {
        }

        public newContext(DbContextOptions<newContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Avan> Avans { get; set; }
        public virtual DbSet<Insan> Insans { get; set; }
        public virtual DbSet<Isci> Iscis { get; set; }
        public virtual DbSet<Logg> Loggs { get; set; }
        public virtual DbSet<Nomre> Nomres { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<Suallar> Suallars { get; set; }
        public virtual DbSet<Telebe> Telebes { get; set; }
        public virtual DbSet<Telebe1> Telebe1s { get; set; }
        public virtual DbSet<Telimci1> Telimci1s { get; set; }
        public virtual DbSet<User1> User1s { get; set; }
        public virtual DbSet<User2> User2s { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-FRFBIAD\n;Database=new;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CI_AS");

            modelBuilder.Entity<Avan>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Pul).HasColumnName("pul");

                entity.Property(e => e.Tarix)
                    .HasColumnType("date")
                    .HasColumnName("tarix");

                entity.HasOne(d => d.Isci)
                    .WithMany(p => p.Avans)
                    .HasForeignKey(d => d.IsciId)
                    .HasConstraintName("FK__Avans__IsciId__49C3F6B7");
            });

            modelBuilder.Entity<Insan>(entity =>
            {
                entity.ToTable("insan");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ad)
                    .HasMaxLength(20)
                    .HasColumnName("ad");
            });

            modelBuilder.Entity<Isci>(entity =>
            {
                entity.ToTable("Isci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ad)
                    .HasMaxLength(20)
                    .HasColumnName("ad");

                entity.Property(e => e.Maas).HasColumnName("maas");

                entity.Property(e => e.Soyad)
                    .HasMaxLength(20)
                    .HasColumnName("soyad");

                entity.Property(e => e.Vergi).HasColumnName("vergi");
            });

            modelBuilder.Entity<Logg>(entity =>
            {
                entity.ToTable("logg");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsciId).HasColumnName("isciId");

                entity.Property(e => e.Sebeb).HasColumnName("sebeb");

                entity.Property(e => e.Tarix)
                    .HasColumnType("date")
                    .HasColumnName("tarix");

                entity.HasOne(d => d.Isci)
                    .WithMany(p => p.Loggs)
                    .HasForeignKey(d => d.IsciId)
                    .HasConstraintName("FK__logg__isciId__45F365D3");
            });

            modelBuilder.Entity<Nomre>(entity =>
            {
                entity.ToTable("nomre");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.InsanId).HasColumnName("insanId");

                entity.Property(e => e.NomreAd)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("nomre_ad");

                entity.HasOne(d => d.Insan)
                    .WithMany(p => p.Nomres)
                    .HasForeignKey(d => d.InsanId)
                    .HasConstraintName("FK__nomre__insanId__412EB0B6");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.ToTable("status");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ad)
                    .HasMaxLength(20)
                    .HasColumnName("ad");
            });

            modelBuilder.Entity<Suallar>(entity =>
            {
                entity.ToTable("Suallar");
            });

            modelBuilder.Entity<Telebe>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Telebe");

                entity.Property(e => e.Ad)
                    .HasMaxLength(20)
                    .HasColumnName("ad");

                entity.Property(e => e.CixisBali).HasColumnName("cixis_bali");

                entity.Property(e => e.GirisBali).HasColumnName("giris_bali");

                entity.Property(e => e.Qiymet)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("qiymet")
                    .IsFixedLength(true);

                entity.Property(e => e.Soyad)
                    .HasMaxLength(20)
                    .HasColumnName("soyad");

                entity.Property(e => e.YekunBal).HasColumnName("yekun_bal");
            });

            modelBuilder.Entity<Telebe1>(entity =>
            {
                entity.ToTable("telebe1");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ad)
                    .HasMaxLength(20)
                    .HasColumnName("ad");
            });

            modelBuilder.Entity<Telimci1>(entity =>
            {
                entity.ToTable("telimci1");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ad)
                    .HasMaxLength(20)
                    .HasColumnName("ad");
            });

            modelBuilder.Entity<User1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("user1");

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .HasColumnName("password");

                entity.Property(e => e.Username)
                    .HasMaxLength(20)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<User2>(entity =>
            {
                entity.ToTable("user2");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.StatusId).HasColumnName("statusId");

                entity.Property(e => e.UserAd)
                    .HasMaxLength(20)
                    .HasColumnName("user_ad");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.User2s)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK__user2__statusId__5535A963");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
