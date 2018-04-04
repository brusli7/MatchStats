using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MatchStatsCore.Models
{
    public class Team
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int PlayerCount { get; set; }
        public int IDGame { get; set; }
        public int IDTournament { get; set; }
    }
}