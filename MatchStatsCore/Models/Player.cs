﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MatchStatsCore.Models
{
    public class Player
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool GoalKeeper { get; set; }
        public int IDTeam { get; set; }
    }
}