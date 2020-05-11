using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GPR.Laterna.DataAccess.Concrete.EntityFramework;
using GPR.Laterna.Entities.Concrete;
using GPR.Laterna.DataAccess.Abstract;
using GPR.Laterna.Business.Concrete;

namespace GPR.Laterna.DataAccess.Tests
{
    [TestClass]
    public class UserDalTests
    {
        private IUserDal _userDal;

        public UserDalTests()
        {
            _userDal = DalFactory.CreateUserDal();
        }
       
        [TestMethod]
        public void AddUserTest()
        {
           
            var addedUSer = _userDal.Add(new User() { 
                Name="Deneme",
                Password="123456",
                UpdatedAt=DateTime.Now,
                CreatedAt = DateTime.Now,
                Email="deneme@laterna.com"
            });

            _userDal.Delete(addedUSer);
        }

        [TestMethod]
        public void GetUserListTest()
        {
            var list = _userDal.GetList();

            Assert.IsTrue(list.Count > 0);
        }

        [TestMethod]
        public void GetOneUserTest()
        {
            var user = _userDal.Get(x => x.Email == "admin@laterna.com");

            Assert.IsNotNull(user);
        }
    }
}
