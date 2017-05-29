using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgencyExerciseFour;

namespace TravelAgencyExerciseFourTests
{
    public class TourScheduleStub:ITourSchedule
    {
        public List<Tour> listOfTours { get; set; }

        public TourScheduleStub()
        {
            
        }
        public void CreateTour(string nameoftour, DateTime tourDateTime, int numberofseats)
        {
            var addTour= new Tour();
            addTour.NameOfTour = nameoftour;
            addTour.DateOfTour = tourDateTime;
            addTour.NumberOfSeats = numberofseats;
        }

        public List<Tour> GetToursFor(DateTime timeTour)
        {
            return listOfTours;
        }
    }
}
