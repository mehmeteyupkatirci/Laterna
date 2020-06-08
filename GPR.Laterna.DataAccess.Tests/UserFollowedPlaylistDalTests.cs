using System;
using GPR.Laterna.Business.Concrete;
using GPR.Laterna.DataAccess.Abstract;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GPR.Laterna.DataAccess.Tests
{
    [TestClass]
    public class UserFollowedPlaylistDalTests
    {
        private IUserFollowedPlaylistDal _userFollowedPlaylistDal;
        public UserFollowedPlaylistDalTests()
        {
            _userFollowedPlaylistDal = DalFactory.CreateUserFollowedPlaylistDal();
        }

        [TestMethod]
        public void GetOneUserFollowedPlaylist()
        {
            var userFollowedPlaylist = _userFollowedPlaylistDal.Get(x => x.Id == 1);

            Assert.IsNotNull(userFollowedPlaylist);
        }

        [TestMethod]
        public void GetUserFollowedArtistListTest()
        {
            var list = _userFollowedPlaylistDal.GetList();
            Assert.IsTrue(list.Count > 0);
        }
    }
}
