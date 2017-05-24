using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TravelAgency;

namespace TravelAgencyTests
{
    [TestFixture]
    public class TourScheduleTests
    {
        [Test]
        public void CanCreateNewTour()
        {
            var sut = new TourSchedule();

            sut.CreateTour("New years day safari", new DateTime(2013, 1, 1), 20);

            var result = sut.GetToursFor(new DateTime(2013, 1, 1));

            Assert.AreEqual(1,result.Count);
            Assert.AreEqual("New years day safari",result[0].NameOfTour);
            Assert.AreEqual(20,result[0].NumberOfSeats);

        }

        [Test]
        public void ToursAreScheduledByDateOnly()
        {
            var sut = new TourSchedule();
        }
    }
}
