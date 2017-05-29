using System;
using System.Collections.Generic;

namespace TravelAgencyExerciseFour
{
    public interface ITourSchedule
    {
        void CreateTour(string nameoftour, DateTime dateTime, int numberofseats);
        List<Tour> GetToursFor(DateTime timeTour);
    }
}