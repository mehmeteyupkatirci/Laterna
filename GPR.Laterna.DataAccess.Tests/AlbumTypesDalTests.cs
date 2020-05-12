using System;
using GPR.Laterna.Business.Concrete;
using GPR.Laterna.DataAccess.Abstract;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GPR.Laterna.DataAccess.Tests
{
    [TestClass]
    public class AlbumTypesDalTests
    {
        private IAlbumTypesDal _albumTypes;
        public AlbumTypesDalTests()
        {
            _albumTypes = DalFactory.CreateAlbumTypesDal();
        }
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
