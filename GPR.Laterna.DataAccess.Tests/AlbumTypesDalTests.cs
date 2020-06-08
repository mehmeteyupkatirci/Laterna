using System;
using GPR.Laterna.Business.Concrete;
using GPR.Laterna.DataAccess.Abstract;
using GPR.Laterna.Entities.Concrete;
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
        public void AddAlbumTypeTest()
        {
            var addedAlbumTypes = _albumTypes.Add(new AlbumTypes
            {
                Name = "DAL.AlbumTypes.Test",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            });
        }

        [TestMethod]
        public void DeleteAlbumTypesTest()
        {
            var testAlbumTypes = _albumTypes.Get(x => x.Name == "DAL.AlbumTypes.Test");
            if (testAlbumTypes != null)
            {
                _albumTypes.Delete(testAlbumTypes);
            }
            else
            {
                Assert.AreEqual(1, 1);
            }
        }

        [TestMethod]
        public void GetOneAlbumTypesTest()
        {
            var albumTypes = _albumTypes.Get(x => x.Id == 1);

            Assert.IsNotNull(albumTypes);
        }

        [TestMethod]
        public void GetAlbumTypesListTest()
        {
            var list = _albumTypes.GetList();

            Assert.IsTrue(list.Count > 0);
        }
    }
}
