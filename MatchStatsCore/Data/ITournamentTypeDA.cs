using MatchStatsCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MatchStatsCore.Data
{
    public interface ITournamentTypeDA
    {
        TournamentType GetTournamentType(int id);
    }
}