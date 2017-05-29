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
        public List<Tour>tours = new List<Tour>();

        public void CreateTour(string nameoftour, DateTime dateTime, int numberofseats)
        {
            throw new NotImplementedException();
        }

        public List<Tour> GetToursFor(DateTime timeTour)
        {
            return tours;
        }
    }
}
