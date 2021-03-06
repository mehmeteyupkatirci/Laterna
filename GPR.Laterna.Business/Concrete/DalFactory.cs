﻿using GPR.Laterna.DataAccess.Abstract;
using GPR.Laterna.DataAccess.Concrete;
using GPR.Laterna.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPR.Laterna.Business.Concrete
{
    public class DalFactory
    {
        public static IUserDal CreateUserDal()
        {
            return new EfUserDal();
        }
        public static IAlbumDal CreateAlbumDal()
        {
            return new EfAlbumDal();
        }
        public static IArtistDal CreateArtistDal()
        {
            return new EfArtistDal();
        }
        public static IAlbumTypesDal CreateAlbumTypesDal()
        {
            return new EfAlbumTypesDal();
        }
        public static IPlaylistDal CreatePlaylistDal()
        {
            return new EfPlaylistDal();
        }
        public static ITrackDal CreateTrackDal()
        {
            return new EfTrackDal();
        }
        public static IUserProfileDal CreateUserProfileDal()
        {
            return new EfUserProfileDal();
        }
        public static IPlaylistTrackDal CreatePlaylistTrackDal()
        {
            return new EfPlaylistTrackDal();
        }
        public static IUserLikedArtistDal CreateUserLikedArtistDal()
        {
            return new EfUserLikedArtistDal();
        }
        public static IUserLikedAlbumDal CreateUserLikedAlbumDal()
        {
            return new EfUserLikedAlbumDal();
        }
        public static IUserLikedTrackDal CreateUserLikedTrackDal()
        {
            return new EfUserLikedTrackDal();
        }
        public static IUserLikedPlaylistDal CreateUserLikedPlaylistDal()
        {
            return new EfUserLikedPlaylistDal();
        }
        public static IUserFollowedArtistDal CreateUserFollowedArtistDal()
        {
            return new EfUserFollowedArtistDal();
        }
        public static IUserFollowedAlbumDal CreateUserFollowedAlbumDal()
        {
            return new EfUserFollowedAlbumDal();
        }
        public static IUserFollowedTrackDal CreateUserFollowedTrackDal()
        {
            return new EfUserFollowedTrackDal();
        }
        public static IUserFollowedPlaylistDal CreateUserFollowedPlaylistDal()
        {
            return new EfUserFollowedPlaylistDal();
        }
    }
}
