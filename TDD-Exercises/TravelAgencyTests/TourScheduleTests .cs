﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using TravelAgency;

namespace TravelAgencyTests
{
    [TestFixture]
    [Category("ExerciseTwo")]
    public class TourScheduleTests
    {
        private TourSchedule sut;
        [SetUp]
        public void Setup()
        {
            sut = new TourSchedule();
        }
        [Test]
        public void CanCreateNewTour()
        {
            //Act
            sut.CreateTour("New years day safari", new DateTime(2013, 1, 1), 20);
            var result = sut.GetToursFor(new DateTime(2013, 1, 1));

            //Assert
            Assert.AreEqual(1,result.Count);
            Assert.AreEqual("New years day safari",result[0].NameOfTour);
            Assert.AreEqual(20,result[0].NumberOfSeats);

        }

        [Test]
        public void ToursAreScheduledByDateOnly()
        {
            //Act
            sut.CreateTour("New years day safari",new DateTime(2013, 1, 1, 10, 15, 0), 20);
            var result = sut.GetToursFor(new DateTime(2013, 1, 1));

            //Assert
            Assert.AreEqual(new DateTime(2013,1,1),result[0].DateOfTour.Date);
        }

        [Test]
        public void GetToursForGivenDayOnly()
        {
            sut.CreateTour("New years day safari",new DateTime(2013, 1, 1, 10, 15, 0), 20);
            sut.CreateTour("May safari", new DateTime(2013, 5, 1, 10, 15, 0), 20);
            sut.CreateTour("July safari", new DateTime(2013, 7, 1, 10, 15, 0), 20);
            sut.CreateTour("April safari", new DateTime(2013, 4, 1, 10, 15, 0), 20);

            var result = sut.GetToursFor(new DateTime(2013, 4, 1));

            Assert.AreEqual(new DateTime(2013, 4, 1),result[0].DateOfTour.Date);
            Assert.AreEqual(1,result.Count);
        }

        [Test]
        public void ThrowsExceptionWhenThereIsMoreThanOneTourPerDay()
        {
            sut.CreateTour("New years day safari", new DateTime(2013, 1, 1, 10, 15, 0), 20);
            sut.CreateTour("January safari", new DateTime(2013, 1, 1, 10, 15, 0), 20);
            sut.CreateTour("Winter safari", new DateTime(2013, 1, 1, 10, 15, 0), 20);

            Assert.Throws<TourAllocationException>(() => sut.CreateTour("Winter safari", new DateTime(2013, 1, 1, 10, 15, 0), 20));
        }

        [Test]
        public void MoreThanOneTourSuggestNextTour()
        {
            sut.CreateTour("New years day safari", new DateTime(2013, 1, 1, 10, 15, 0), 20);
            sut.CreateTour("January safari", new DateTime(2013, 1, 1, 10, 15, 0), 20);
            sut.CreateTour("Winter safari", new DateTime(2013, 1, 1, 10, 15, 0), 20);

            var e=Assert.Throws<TourAllocationException>(() => sut.CreateTour("A new in january safari", new DateTime(2013, 1, 1, 10, 15, 0), 20));
            Assert.AreEqual(new DateTime(2013,1,2),e.SuggestedTime, "Correct suggested time");
        }
    }
}
