using System;
using GPR.Laterna.Business.Concrete;
using GPR.Laterna.DataAccess.Abstract;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GPR.Laterna.DataAccess.Tests
{
    [TestClass]
    public class UserFollowedTrackDalTests
    {
        private IUserFollowedTrackDal _userFollowedTrackDal;
        public UserFollowedTrackDalTests()
        {
            _userFollowedTrackDal = DalFactory.CreateUserFollowedTrackDal();
        }

        [TestMethod]
        public void GetOneUserFollowedTrack()
        {
            var userFollowedTrack = _userFollowedTrackDal.Get(x => x.Id == 7);

            Assert.IsNotNull(userFollowedTrack);
        }

        [TestMethod]
        public void GetUserFollowedTrackListTest()
        {
            var list = _userFollowedTrackDal.GetList();
            Assert.IsTrue(list.Count > 0);
        }
    }
}
