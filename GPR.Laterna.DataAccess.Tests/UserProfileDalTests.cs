using System;
using GPR.Laterna.Business.Concrete;
using GPR.Laterna.DataAccess.Abstract;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GPR.Laterna.DataAccess.Tests
{
    [TestClass]
    public class UserProfileDalTests
    {
        private IUserProfileDal _userProfileDal;
        public UserProfileDalTests()
        {
            _userProfileDal = DalFactory.CreateUserProfileDal();
        }
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
