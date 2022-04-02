﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasinoMSR.Web.Models
{
    public class FavoriteGame
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public string UserName { get; set; }
        public Game Game { get; set; }
    }
}
