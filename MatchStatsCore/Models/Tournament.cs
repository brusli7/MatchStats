using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MatchStatsCore.Models
{
    public class Tournament
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Location { get; set; }
        public int IDTournamentType { get; set; }
    }
}