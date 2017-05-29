﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgencyExerciseFour
{
    public class BookingPersonOnNonexistentTourException:Exception
    {
    }
    public class TourAllocationException : Exception
    {
        public DateTime? SuggestedTime { get; set; }

        public TourAllocationException(DateTime? suggestedTime)
        {
            this.SuggestedTime = suggestedTime;
        }
    }

    public class SameNameSameDateException : Exception
    {

    }

    public class NegativeSeatException : Exception
    {

    }
}
