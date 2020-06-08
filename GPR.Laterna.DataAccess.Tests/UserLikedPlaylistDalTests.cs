using System;
using GPR.Laterna.Business.Concrete;
using GPR.Laterna.DataAccess.Abstract;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GPR.Laterna.DataAccess.Tests
{
    [TestClass]
    public class UserLikedPlaylistDalTests
    {
        private IUserLikedPlaylistDal _userLikedPlaylistDal;
        public UserLikedPlaylistDalTests()
        {
            _userLikedPlaylistDal = DalFactory.CreateUserLikedPlaylistDal();
        }

        [TestMethod]
        public void GetOneUserLikedPlaylistTest()
        {
            var userLikedPlaylist = _userLikedPlaylistDal.Get(x => x.Id == 1);

            Assert.IsNotNull(userLikedPlaylist);
        }

        [TestMethod]
        public void GetUserLikedPlaylistListTest()
        {
            var list = _userLikedPlaylistDal.GetList();
            Assert.IsTrue(list.Count > 0);
        }
    }
}
