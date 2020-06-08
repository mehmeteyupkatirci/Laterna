using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GPR.Laterna.DataAccess.Abstract;
using GPR.Laterna.Business.Concrete;
using GPR.Laterna.Entities.Concrete;

namespace GPR.Laterna.DataAccess.Tests
{
    [TestClass]
    public class ArtistDalTests
    {
        private IArtistDal _artistDal;
        public ArtistDalTests()
        {
            _artistDal = DalFactory.CreateArtistDal();
        }

        [TestMethod]
        public void AddArtistTest()
        {
            var addedArtist = _artistDal.Add(new Artist
            {
                Name = "DAL.Artist.Test",
                SpotId = "aklala",
                Popularity = 12,
                CreatedAt = DateTime.Now,
                Genres = "Deneme türü",
            });
        }

        [TestMethod]
        public void DeleteArtistTest()
        {
            var testArtist = _artistDal.Get(x => x.Name == "DAL.Artist.Test");
            if (testArtist != null)
            {
                _artistDal.Delete(testArtist);
            }
            else
            {
                Assert.AreEqual(1, 1);
            }
        }

        [TestMethod]
        public void GetOneArtistTest()
        {
            var playlist = _artistDal.Get(x => x.Id == 1);

            Assert.IsNotNull(playlist);
        }

        [TestMethod]
        public void GetArtistListTest()
        {
            var list = _artistDal.GetList();

            Assert.IsTrue(list.Count > 0);
        }
    }
}
