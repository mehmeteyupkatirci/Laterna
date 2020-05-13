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
        public void TestMethod1()
        {
        }
    }
}
