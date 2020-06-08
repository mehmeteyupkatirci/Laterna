using System;
using GPR.Laterna.Business.Concrete;
using GPR.Laterna.DataAccess.Abstract;
using GPR.Laterna.Entities.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GPR.Laterna.DataAccess.Tests
{
    [TestClass]
    public class PlaylistTrackDalTests
    {
        private IPlaylistTrackDal _playlistTrackDal;
        public PlaylistTrackDalTests()
        {
            _playlistTrackDal = DalFactory.CreatePlaylistTrackDal();
        }
        [TestMethod]
        public void AddPlaylistTrackTest()
        {
            var addedPlaylistTrack = _playlistTrackDal.Add(new PlaylistTrack
            {
                PlaylistId = 10011,
                TrackId = 11317,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            });
        }
        [TestMethod]
        public void DeletePlaylistTrackTest()
        {
            var testPlaylist = _playlistTrackDal.Get(x => x.PlaylistId == 10011 && x.TrackId == 11317);
            if (testPlaylist != null)
            {
                _playlistTrackDal.Delete(testPlaylist);
            }
            else
            {
                Assert.AreEqual(1, 1);
            }
        }

        [TestMethod]
        public void GetOnePlaylistTrackTest()
        {
            var playlistTrack = _playlistTrackDal.Get(x => x.PlaylistId == 10011 && x.TrackId == 100);

            Assert.IsNotNull(playlistTrack);
        }

        [TestMethod]
        public void GetPlaylistTrackListTest()
        {
            var list = _playlistTrackDal.GetList();

            Assert.IsTrue(list.Count > 0);
        }
    }
}
