using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasinoMSR.Web.Models
{
    public class GameUserStatistic
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public string UserId { get; set; }
        public decimal TotalWon { get; set; }
        public decimal TotalLost { get; set; }

    }
}
