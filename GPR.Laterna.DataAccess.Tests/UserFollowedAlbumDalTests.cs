using System;
using GPR.Laterna.Business.Concrete;
using GPR.Laterna.DataAccess.Abstract;
using GPR.Laterna.Entities.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GPR.Laterna.DataAccess.Tests
{
    [TestClass]
    public class UserFollowedAlbumDalTests
    {
        private IUserFollowedAlbumDal _userFollowedAlbumDal;
        public UserFollowedAlbumDalTests()
        {
            _userFollowedAlbumDal = DalFactory.CreateUserFollowedAlbumDal();
        }

        [TestMethod]
        public void GetOneUserFollowedAlbumTest()
        {
            var playlist = _userFollowedAlbumDal.Get(x => x.Id == 1);

            Assert.IsNotNull(playlist);
        }

        [TestMethod]
        public void GetUserFollowedAlbumListTest()
        {
            var list = _userFollowedAlbumDal.GetList();
            Assert.IsTrue(list.Count > 0);
        }
    }
}
