using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PRN211_Project.Models
{
    public partial class PRN211_ProjectContext : DbContext
    {
        public PRN211_ProjectContext()
        {
        }

        public PRN211_ProjectContext(DbContextOptions<PRN211_ProjectContext> options)
            : base(options)
        {
        }

        public virtual DbSet<History> Histories { get; set; } = null!;
        public virtual DbSet<Synonym> Synonyms { get; set; } = null!;
        public virtual DbSet<Type> Types { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<Word> Words { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=MARK-49\\HE171241DDH;database=PRN211_Project;uid=sa;pwd=123;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<History>(entity =>
            {
                entity.HasKey(e => new { e.Username, e.Id })
                    .HasName("PK__history__10FAFBF06D7CC2B6");

                entity.ToTable("history");

                entity.Property(e => e.Username)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("username");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Addtime)
                    .HasColumnType("datetime")
                    .HasColumnName("addtime");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.Histories)
                    .HasForeignKey(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__history__id__440B1D61");

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.Histories)
                    .HasForeignKey(d => d.Username)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__history__usernam__4316F928");
            });

            modelBuilder.Entity<Synonym>(entity =>
            {
                entity.HasKey(e => new { e.FirstId, e.SecondId })
                    .HasName("PK__synonyms__76034A2F40845945");

                entity.ToTable("synonyms");

                entity.Property(e => e.FirstId).HasColumnName("firstId");

                entity.Property(e => e.SecondId).HasColumnName("secondId");

                entity.Property(e => e.Username)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("username");

                entity.HasOne(d => d.First)
                    .WithMany(p => p.SynonymFirsts)
                    .HasForeignKey(d => d.FirstId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__synonyms__firstI__628FA481");

                entity.HasOne(d => d.Second)
                    .WithMany(p => p.SynonymSeconds)
                    .HasForeignKey(d => d.SecondId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__synonyms__second__6383C8BA");
            });

            modelBuilder.Entity<Type>(entity =>
            {
                entity.ToTable("Type");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Username)
                    .HasName("PK__User__F3DBC5739584D0A5");

                entity.ToTable("User");

                entity.Property(e => e.Username)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("username");

                entity.Property(e => e.IsAdmin)
                    .HasColumnName("isAdmin")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.HasMany(d => d.Ids)
                    .WithMany(p => p.Usernames)
                    .UsingEntity<Dictionary<string, object>>(
                        "UserWord",
                        l => l.HasOne<Word>().WithMany().HasForeignKey("Id").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__user_word__id__403A8C7D"),
                        r => r.HasOne<User>().WithMany().HasForeignKey("Username").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__user_word__usern__3F466844"),
                        j =>
                        {
                            j.HasKey("Username", "Id").HasName("PK__user_wor__10FAFBF0CF1B9924");

                            j.ToTable("user_word");

                            j.IndexerProperty<string>("Username").HasMaxLength(20).IsUnicode(false).HasColumnName("username");

                            j.IndexerProperty<long>("Id").HasColumnName("id");
                        });
            });

            modelBuilder.Entity<Word>(entity =>
            {
                entity.ToTable("Word");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Meaning)
                    .IsUnicode(false)
                    .HasColumnName("meaning");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.TypeId).HasColumnName("typeId");

                entity.Property(e => e.Username)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("username");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Words)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK__Word__typeId__3C69FB99");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
