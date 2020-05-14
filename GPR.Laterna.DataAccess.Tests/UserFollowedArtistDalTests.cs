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
        public void TestMethod1()
        {
        }
    }
}
