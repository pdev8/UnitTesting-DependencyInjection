using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting.Services;
using UnitTesting.Testing.Fakes;

namespace UnitTesting.Testing.Services
{
    [TestClass]
    public class VideoServiceTests
    {
        [TestMethod]
        public void ReadVideoTitle_EmptyFile_ReturnError()
        {
            var service = new VideoService(new FakeFileReader());

            Assert.IsTrue(service.ReadVideoTitle().Contains("error", StringComparison.OrdinalIgnoreCase));
        }
    }
}