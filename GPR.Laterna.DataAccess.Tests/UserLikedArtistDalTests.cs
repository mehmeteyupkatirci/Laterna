using System;
using GPR.Laterna.Business.Concrete;
using GPR.Laterna.DataAccess.Abstract;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GPR.Laterna.DataAccess.Tests
{
    [TestClass]
    public class UserLikedArtistDalTests
    {
        private IUserLikedArtistDal _userLikedArtistDal;
        public UserLikedArtistDalTests()
        {
            _userLikedArtistDal = DalFactory.CreateUserLikedArtistDal();
        }

        [TestMethod]
        public void GetOneUserLikedArtistTest()
        {
            var userLikedArtist = _userLikedArtistDal.Get(x => x.Id == 5);

            Assert.IsNotNull(userLikedArtist);
        }

        [TestMethod]
        public void GetUserLikedArtistListTest()
        {
            var list = _userLikedArtistDal.GetList();
            Assert.IsTrue(list.Count > 0);
        }
    }
}
