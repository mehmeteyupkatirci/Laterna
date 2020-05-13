using System;
using GPR.Laterna.Business.Concrete;
using GPR.Laterna.DataAccess.Abstract;
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
        public void TestMethod1()
        {
        }
    }
}
