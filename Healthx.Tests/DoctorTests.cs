
using Healthx.Api.Models;
using Healthx.Api.Services;
using NUnit.Framework;

namespace Healthx.Tests
{
    [TestFixture]
    public class DoctorTests
    {
        private DoctorService _doctorService; 
        [SetUp]
        public void Setup()
        {
            _doctorService = new DoctorService();
            // var doctor = new Doctor(); 

        }

        [Test]
        public void Test()
        {
            
        }
    }
}
