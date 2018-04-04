using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MatchStatsCore.Models
{
    public class TeamStats
    {
        public int ID { get; set; }
        public int Points { get; set; }
        public int WinCount { get; set; }
        public int LossCount { get; set; }
        public int DrawCount { get; set; }
        public int GoalCount { get; set; }
        public int GoalConcieved { get; set; }
        public int GoalScored { get; set; }
        public int IDTeam { get; set; }
    }
}