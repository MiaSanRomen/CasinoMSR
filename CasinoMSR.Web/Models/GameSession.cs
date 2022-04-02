using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasinoMSR.Web.Models
{
    public class GameSession
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public string UserName { get; set; }
        public string Domain { get; set; }
    }
}
