using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MatchStatsCore.Models
{
    public class PlayerStats
    {
        public int ID { get; set; }
        public int GoalScored { get; set; }
        public int GoalConcieved { get; set; }
        public int FoulCount { get; set; }
        public int Red { get; set; }
        public int Yellow { get; set; }
        public int IDPlayer { get; set; }
    }
}