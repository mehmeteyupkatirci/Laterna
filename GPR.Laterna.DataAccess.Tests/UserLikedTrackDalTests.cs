using System;
using GPR.Laterna.Business.Concrete;
using GPR.Laterna.DataAccess.Abstract;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GPR.Laterna.DataAccess.Tests
{
    [TestClass]
    public class UserLikedTrackDalTests
    {
        private IUserLikedTrackDal _userLikedTrackDal;
        public UserLikedTrackDalTests()
        {
            _userLikedTrackDal = DalFactory.CreateUserLikedTrackDal();
        }

        [TestMethod]
        public void GetOneUserLikedTrackTest()
        {
            var userLikedTrack = _userLikedTrackDal.Get(x => x.Id == 10007);

            Assert.IsNotNull(userLikedTrack);
        }

        [TestMethod]
        public void GetUserLikedTrackListTest()
        {
            var list = _userLikedTrackDal.GetList();
            Assert.IsTrue(list.Count > 0);
        }
    }
}
