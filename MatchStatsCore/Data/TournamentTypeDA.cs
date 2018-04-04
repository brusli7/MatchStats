using Dapper;
using MatchStatsCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MatchStatsCore.Data
{
    public class TournamentTypeDA : DataConn, ITournamentTypeDA
    {
        private const string GetTournamentTypeSQL = "GetTournamentType";
    

        public TournamentType GetTournamentType(int id)
        {
            using (var conn = ConnectionFactory())
            {
                conn.Open();

                var queryParams = new { ID = id };

                var caree = conn.Query<TournamentType>(GetTournamentTypeSQL, param: queryParams, commandType: System.Data.CommandType.StoredProcedure);

                return caree.FirstOrDefault();
            }

            
        }

    }
}