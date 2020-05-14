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
        public void TestMethod1()
        {
        }
    }
}
