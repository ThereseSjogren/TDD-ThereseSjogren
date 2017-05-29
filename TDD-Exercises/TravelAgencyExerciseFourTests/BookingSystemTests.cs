using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TravelAgencyExerciseFour;

namespace TravelAgencyExerciseFourTests
{
    [TestFixture]
    [Category("ExerciseFour - BookinSystemTests")]
    public class BookingSystemTests
    {
        private TourScheduleStub tourScheduleStub;
        private BookingSystem sut;

        [SetUp]
        public void Setup()
        {
            sut = new BookingSystem(tourScheduleStub);
        }

        [Test]
        public void CanCreateBooking()
        {
            //12.Start by calling your stub object and setting the public member Tours to a new list
            //containing at least one tour with at least one available seat.
        }
    }
}
