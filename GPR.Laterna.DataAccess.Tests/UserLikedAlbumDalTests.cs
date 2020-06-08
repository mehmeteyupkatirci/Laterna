using System;
using GPR.Laterna.Business.Concrete;
using GPR.Laterna.DataAccess.Abstract;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GPR.Laterna.DataAccess.Tests
{
    [TestClass]
    public class UserLikedAlbumDalTests
    {
        private IUserLikedAlbumDal _userLikedAlbumDal;
        public UserLikedAlbumDalTests()
        {
            _userLikedAlbumDal = DalFactory.CreateUserLikedAlbumDal();
        }

        [TestMethod]
        public void GetOneUserLikedAlbum()
        {
            var userLikedAlbum = _userLikedAlbumDal.Get(x => x.Id == 1);

            Assert.IsNotNull(userLikedAlbum);
        }

        [TestMethod]
        public void GetUserLikedAlbumListTest()
        {
            var list = _userLikedAlbumDal.GetList();
            Assert.IsTrue(list.Count > 0);
        }
    }
}
