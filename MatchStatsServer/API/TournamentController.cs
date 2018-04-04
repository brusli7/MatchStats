using MatchStatsCore.Data;
using MatchStatsCore.Models;
using MatchStatsServer.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MatchStatsServer.API
{
    public class TournamentController : ApiController
    {
        private ITournamentTypeDA _tournamentTypeDA;


        public TournamentController(ITournamentTypeDA tournamentTypeDA)
        {
            _tournamentTypeDA = tournamentTypeDA;
        }



        [HttpGet]
        public SingleItemHttpResponse<TournamentType> GetTournamentType(int id)
        {
            var model = _tournamentTypeDA.GetTournamentType(id);

            return new SingleItemHttpResponse<TournamentType>(model, HttpStatusCode.OK);
        }
    }
}