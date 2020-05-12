using System;
using GPR.Laterna.Business.Concrete;
using GPR.Laterna.DataAccess.Abstract;
using GPR.Laterna.Entities.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GPR.Laterna.DataAccess.Tests
{
    [TestClass]
    public class PlaylistDalTests
    {
        private IPlaylistDal _playlistDal;
        public PlaylistDalTests()
        {
            _playlistDal = DalFactory.CreatePlaylistDal();
        }
        [TestMethod]
        public void AddPlaylistTest()
        {
            var addedPlaylist = _playlistDal.Add(new Playlist()
            {
                UserId = 5,
                Name = "Deneme",
                Description = "Deniyorum",
                Public = true,
                UpdatedAt = DateTime.Now,
                CreatedAt = DateTime.Now,
            });
            _playlistDal.Delete(addedPlaylist);
        }
        [TestMethod]
        public void GetOnePlaylistTest()
        {
            var playlist = _playlistDal.Get(x => x.Name == "Deneme");

            Assert.IsNotNull(playlist);
        }
    }
}
