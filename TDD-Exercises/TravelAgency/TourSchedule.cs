using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

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
            var result = listOfTours.Where(x => x.DateOfTour.Date == timeTour.Date).Count();
            if (result > 1)
            {
                throw new TourAllocationException(timeTour.AddDays(1));
            }
            return listOfTours;
        }
    }
}