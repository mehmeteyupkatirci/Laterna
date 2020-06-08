using System;
using GPR.Laterna.Business.Concrete;
using GPR.Laterna.DataAccess.Abstract;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GPR.Laterna.DataAccess.Tests
{
    [TestClass]
    public class UserFollowedArtistDalTests
    {
        private IUserFollowedArtistDal _userFollowedArtistDal;
        public UserFollowedArtistDalTests()
        {
            _userFollowedArtistDal = DalFactory.CreateUserFollowedArtistDal();
        }

        [TestMethod]
        public void GetOneUserFollowedArtistTest()
        {
            var userFollowedArtist = _userFollowedArtistDal.Get(x => x.Id == 1);

            Assert.IsNotNull(userFollowedArtist);
        }

        [TestMethod]
        public void GetUserFollowedArtistListTest()
        {
            var list = _userFollowedArtistDal.GetList();
            Assert.IsTrue(list.Count > 0);
        }
    }
}
