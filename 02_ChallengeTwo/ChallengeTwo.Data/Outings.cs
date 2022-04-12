using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeTwo.Data
{
    public class Outings
    {
        public Outings() {}
        public Outings(EventType eventType, int numberAttended, int year, int month, 
        int day, int eventCostPerPerson, int eventCost)
        {
            EventType=eventType;
            NumberAttended=numberAttended;
            Year=year;
            Month=month;
            Day=day;
            EventCost=eventCost;
        }
       
        public EventType EventType {get; set;}
        public int NumberAttended { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public int EventCostPerPerson {get; set;}
        public int EventCost { get; set; }
    }
}