using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeTwo.Data
{
    public class Outings
    {
        
        public EventType EventType {get; set;}
        public int NumberAttended { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public int EventCostPerPerson {get; set;}
        public int EventCost { get; set; }
    }
}