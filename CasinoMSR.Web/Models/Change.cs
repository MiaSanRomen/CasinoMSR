using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CasinoMSR.Web.Models;

namespace CasinoMSR.Web.Models
{
    public class Change
    {
        public int ChangeId { get; set; }
        public string Author { get; set; }
        public DateTime Date { get; set; }

        public int GameId { get; set; }
        public Game Game { get; set; }
    }
}
