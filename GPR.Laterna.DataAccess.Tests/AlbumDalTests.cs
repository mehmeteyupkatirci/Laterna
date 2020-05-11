using System;
using GPR.Laterna.Business.Concrete;
using GPR.Laterna.DataAccess.Abstract;
using GPR.Laterna.Entities.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GPR.Laterna.DataAccess.Tests
{
    [TestClass]
    public class AlbumDalTests
    {
        private IAlbumDal _albumDal;

        public AlbumDalTests()
        {
            _albumDal = DalFactory.CreateAlbumDal();
        }
        [TestMethod]
        public void AddAlbumTest()
        {
           
        }
    }
}
