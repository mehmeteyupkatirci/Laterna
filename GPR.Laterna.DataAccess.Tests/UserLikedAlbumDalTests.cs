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
        public void TestMethod1()
        {
        }
    }
}
