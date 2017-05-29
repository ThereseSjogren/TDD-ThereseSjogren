using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using TravelAgencyExerciseFour;

namespace TravelAgencyExerciseFourTests
{
    [TestFixture]
    [Category("ExerciseFour BookinSystemTests")]
    public class BookingSystemTests
    {
        private BookingSystem sut;
        private TourScheduleStub tourScheduleStub { get; set; }
        private Passenger StubPassenger;


        [SetUp]
        public void Setup()
        {
            tourScheduleStub = new TourScheduleStub();
            sut = new BookingSystem(tourScheduleStub);
            StubPassenger = new Passenger()
            {
                FirstName = "Kalle",
                LastName = "Anka"
            };
        }

        [Test]
        public void CanCreateBooking()
        { //Number 20 on exercise 4
            //Arrange
            tourScheduleStub.listOfTours.Add(new Tour
            {
                NameOfTour = "Wild Tour",
                DateOfTour = new DateTime(2018, 1, 1),
                NumberOfSeats = 10
            });

            //Act
            sut.CreateBooking("Wild Tour",new DateTime(2018,1,1),10, StubPassenger);

            List<Booking> bookingsList = sut.GetBookingsFor(StubPassenger);

            //Assert
            Assert.AreEqual(1,bookingsList.Count);
            
            //17.	Assert that this Booking instance contains a reference to the correct 
            //Tour object and the correct Passenger.
            //Assert.IsInstanceOf<Passenger>(StubPassenger);
            //Assert.IsInstanceOf<TourScheduleStub>(tourScheduleStub);
        }

        [Test]
        public void BookingAPassengerOnANonExistentTourThrowsException()
        {
            //Arrange
            //Act

            //Assert
            Assert.Throws<BookingPersonOnNonexistentTourException>(() =>
            sut.CreateBooking("Wild Tour", new DateTime(2018, 1, 1), 10, StubPassenger));
        }
    }
}

