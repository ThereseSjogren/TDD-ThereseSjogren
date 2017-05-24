using System;
using System.Collections.Generic;

namespace TravelAgency
{
    public class TourSchedule
    {
        private List<Tour> listOfTours;
        public TourSchedule()
        {
            listOfTours = new List<Tour>();
        }

        public void CreateTour(string nameoftour, DateTime dateTime, int numberofseats)
        {
            listOfTours.Add(new Tour{NameOfTour = nameoftour, DateOfTour = dateTime.Date, NumberOfSeats = numberofseats});
        }

        public List<Tour> GetToursFor(DateTime timeTour)
        {
            return listOfTours;
        }
    }
}