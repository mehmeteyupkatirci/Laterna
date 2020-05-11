using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GPR.Laterna.DataAccess.Abstract;
using GPR.Laterna.Business.Concrete;

namespace GPR.Laterna.DataAccess.Tests
{
    /// <summary>
    /// Summary description for ArtistDalTests
    /// </summary>
    [TestClass]
    public class ArtistDalTests
    {
        private IArtistDal _artistDal;
        public ArtistDalTests()
        {
            _artistDal = DalFactory.CreateArtistDal();
        }


        [TestMethod]
        public void TestMethod1()
        {
            //
            // TODO: Add test logic here
            //
        }
    }
}
