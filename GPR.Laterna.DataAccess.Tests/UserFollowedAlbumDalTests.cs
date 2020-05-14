using System;
using GPR.Laterna.Business.Concrete;
using GPR.Laterna.DataAccess.Abstract;
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
        public void TestMethod1()
        {
        }
    }
}
