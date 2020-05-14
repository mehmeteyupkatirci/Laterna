using GPR.Laterna.DataAccess.Concrete.EntityFramework.Mappings;
using GPR.Laterna.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPR.Laterna.DataAccess.Concrete.EntityFramework
{
    public class LaternaContext:DbContext
    {
        public LaternaContext()
        {
            Database.SetInitializer<LaternaContext>(null);
        }
         
        public DbSet<User> Users { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<AlbumTypes> AlbumTypes { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<PlaylistTrack> PlaylistTracks { get; set; }
        public DbSet<UserLikedArtist> UserLikedArtists { get; set; }
        public DbSet<UserLikedAlbum> UserLikedAlbums { get; set; }
        public DbSet<UserLikedTrack> UserLikedTracks { get; set; }
        public DbSet<UserLikedPlaylist> UserLikedPlaylists { get; set; }
        public DbSet<UserFollowedArtist> UserFollowedArtists { get; set; }
        public DbSet<UserFollowedAlbum> UserFollowedAlbums { get; set; }
        public DbSet<UserFollowedTrack> UserFollowedTracks { get; set; }
        public DbSet<UserFollowedPlaylist> UserFollowedPlaylists { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new AlbumMap());
            modelBuilder.Configurations.Add(new ArtistMap());
            modelBuilder.Configurations.Add(new PlaylistMap());
            modelBuilder.Configurations.Add(new AlbumTypesMap());
            modelBuilder.Configurations.Add(new TrackMap());
            modelBuilder.Configurations.Add(new UserProfileMap());
            modelBuilder.Configurations.Add(new PlaylistTrackMap());
            modelBuilder.Configurations.Add(new UserLikedArtistMap());
            modelBuilder.Configurations.Add(new UserLikedAlbumMap());
            modelBuilder.Configurations.Add(new UserLikedTrackMap());
            modelBuilder.Configurations.Add(new UserLikedPlaylistMap());
            modelBuilder.Configurations.Add(new UserFollowedArtistMap());
            modelBuilder.Configurations.Add(new UserFollowedAlbumMap());
            modelBuilder.Configurations.Add(new UserFollowedTrackMap());
            modelBuilder.Configurations.Add(new UserFollowedPlaylistMap());
        }
    }
}
