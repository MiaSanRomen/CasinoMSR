using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CasinoMSR.Web.Models;

namespace CasinoMSR.Web.Models
{
    public class Link
    {
        public int LinkId { get; set; }
        public string Name { get; set; }

        public int GameId { get; set; }
        public Game Game { get; set; }
    }
}
