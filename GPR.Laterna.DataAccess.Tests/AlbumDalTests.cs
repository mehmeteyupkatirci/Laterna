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
            var addedAlbum = _albumDal.Add(new Album
            {
                AlbumTypeId = 1,
                ArtistId = 23,
                Copyrights = "Barış Manço Copyrights",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                Name = "DAL.Album.Test",
                Popularity = 13,
                ReleaseData = "11.11.2011",
                SpotId = "askmnaksf",
            });
        }

        [TestMethod]
        public void GetOneAlbumTest()
        {
            var album = _albumDal.Get(x => x.Id == 51);

            Assert.IsNotNull(album);
        }

        [TestMethod]
        public void DeleteAlbumTest()
        {
            var albumTest = _albumDal.Get(x => x.Name == "DAL.Album.Test");
            if (albumTest != null)
            {
                _albumDal.Delete(albumTest);
            }
            else
            {
                Assert.AreEqual(1, 1);
            }
        }

        [TestMethod]
        public void GetAlbumListTest()
        {
            var list = _albumDal.GetList();

            Assert.IsTrue(list.Count > 0);
        }
    }
}
