using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HistoryPedia.Models
{
    public class FavoriteGame
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public string UserId { get; set; }
    }
}
