using System;
using GPR.Laterna.Business.Concrete;
using GPR.Laterna.DataAccess.Abstract;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GPR.Laterna.DataAccess.Tests
{
    [TestClass]
    public class AlbumTypesTests
    {
        private IAlbumTypesDal _albumTypes;
        public AlbumTypesTests()
        {
            _albumTypes = DalFactory.CreateAlbumTypesDal();
        }
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
