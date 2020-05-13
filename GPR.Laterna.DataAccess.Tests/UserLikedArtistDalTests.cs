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
        public void TestMethod1()
        {
        }
    }
}
