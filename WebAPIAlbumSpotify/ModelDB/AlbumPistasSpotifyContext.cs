using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebAPIAlbumSpotify.ModelDB
{
    public partial class AlbumPistasSpotifyContext : DbContext
    {
        public AlbumPistasSpotifyContext()
        {
        }

        public AlbumPistasSpotifyContext(DbContextOptions<AlbumPistasSpotifyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cancion> Cancion { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=AlbumPistasSpotify;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cancion>(entity =>
            {
                entity.Property(e => e.Nombre).IsRequired();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
