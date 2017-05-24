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
            var result = listOfTours.Where(x => x.DateOfTour.Date == dateTime.Date).Count();

            if (result >= 3)
            {
                throw new TourAllocationException(dateTime.AddDays(1).Date);
            }
            listOfTours.Add(new Tour{NameOfTour = nameoftour, DateOfTour = dateTime.Date, NumberOfSeats = numberofseats});
        }

        public List<Tour> GetToursFor(DateTime timeTour)
        {
            return listOfTours.Where(x => x.DateOfTour.Date == timeTour.Date).ToList();
        }
    }
}