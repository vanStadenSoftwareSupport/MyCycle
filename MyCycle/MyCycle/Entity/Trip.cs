using System;
namespace MyCycle.Entity
{
    public class Trip
    {
        public string Id
        {
            get;
            set;
        }
   
        public DateTimeOffset StartDate
        {
            get;
            set;
        }

        public DateTimeOffset EndDate
        {
            get;
            set;
        }

        public TimeSpan Duration 
        {
            get 
            {
                return EndDate - StartDate;    
            }
        }

        public long DistanceInMeters
        {
            get;
            set;
        }

        public string FromSuburb
        {
            get;
            set;
        }

        public string ToSuburb
        {
            get;
            set;
        }
    }
}
