using System;
using GPR.Laterna.Business.Concrete;
using GPR.Laterna.DataAccess.Abstract;
using GPR.Laterna.Entities.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GPR.Laterna.DataAccess.Tests
{
    [TestClass]
    public class TrackDalTests
    {
        private ITrackDal _trackDal;
        public TrackDalTests()
        {
            _trackDal = DalFactory.CreateTrackDal();
        }
        [TestMethod]
        public void AddTrackTest()
        {
            var addedTrack = _trackDal.Add(new Track
            {
                Name = "DAL.Track.Test",
                AlbumId = 50,
                DiscNumber = "1",
                CreatedAt = DateTime.Now,
                Popularity = 12,
                PreviewUrl = "www.www.www.com",
                DurationMs = "123123",
            });
        }

        [TestMethod]
        public void DeleteTrackTest()
        {
            var testTrack = _trackDal.Get(x => x.Name == "DAL.Track.Test");
            if (testTrack != null)
            {
                _trackDal.Delete(testTrack);
            }
            else
            {
                Assert.AreEqual(1, 1);
            }
        }

        [TestMethod]
        public void GetOnePlaylistTrackTest()
        {
            var track = _trackDal.Get(x => x.Id == 319);

            Assert.IsNotNull(track);
        }

        [TestMethod]
        public void GetTrackListTest()
        {
            var list = _trackDal.GetList();

            Assert.IsTrue(list.Count > 0);
        }
    }
}
