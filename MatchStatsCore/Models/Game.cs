using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MatchStatsCore.Models
{
    public class Game
    {
        public int ID { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int IDTournament { get; set; }
    }
}