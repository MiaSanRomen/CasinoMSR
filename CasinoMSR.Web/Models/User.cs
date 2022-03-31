using System.Collections.Generic;
using HistoryPedia.Models;
using Microsoft.AspNetCore.Identity;

namespace HistoryPedia.Models
{
    public class User : IdentityUser
    {
        public decimal TotalMoney { get; set; }
        public decimal TotalWon { get; set; }
        public Picture Image { get; set; }
        public string ImageName { get; set; }
        public List<GameUserStatistic> Statistics { get; set; }
        public List<FavoriteGame> FavoriteGames { get; set; }
    }
}