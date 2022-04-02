using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CasinoMSR.Web.Models;
using HistoryPedia.Data;

namespace CasinoMSR.Web.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }
        public string View { get; set; }
        public List<GameSession> Sessions { get; set; }
        public Picture Image { get; set; }
        public GenreEnum Genre { get; set; }
        public Genre GenreValue { get; set; }
        public string ImageName { get; set; }
        public string TypeName { get; set; }
        public int Recommendations { get; set; }
        public int Year { get; set; }
        public List<GameUserStatistic> Statistics { get; set; }

    }

}