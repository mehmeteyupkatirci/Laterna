using System;
using GPR.Laterna.Business.Concrete;
using GPR.Laterna.DataAccess.Abstract;
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
        public void AddTrack()
        {

        }
    }
}
