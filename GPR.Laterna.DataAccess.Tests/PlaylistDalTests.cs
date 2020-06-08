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
                UserId = 20004,
                Name = "DAL.Playlist.Test",
                Description = "Deniyorum",
                Public = true,
                UpdatedAt = DateTime.Now,
                CreatedAt = DateTime.Now,
            });
           
        }
        [TestMethod]
        public void DeletePlaylistTest()
        {
            var testPlaylist = _playlistDal.Get(x => x.Name == "DAL.Playlist.Test");
            if (testPlaylist != null)
            {
                _playlistDal.Delete(testPlaylist);
            }
            else
            {
                Assert.AreEqual(1, 1);
            }
        }
            [TestMethod]
        public void GetOnePlaylistTest()
        {
            var playlist = _playlistDal.Get(x => x.Id == 10011);

            Assert.IsNotNull(playlist);
        }

        [TestMethod]
        public void GetPlaylistListTest()
        {
            var list = _playlistDal.GetList();

            Assert.IsTrue(list.Count > 0);
        }
    }
}
