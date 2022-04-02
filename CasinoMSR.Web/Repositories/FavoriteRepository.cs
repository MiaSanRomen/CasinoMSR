using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CasinoMSR.Web.Interfaces;
using CasinoMSR.Web.Models;

namespace CasinoMSR.Web.Repositories
{
    public class FavoriteRepository : IGetFavorite
    {
        private readonly GameContext _GameContext;
        public FavoriteRepository(GameContext GameContext)
        {
            _GameContext = GameContext;
        }
        public List<FavoriteGame> GetFavorite(string username) => _GameContext.FavoriteGames.Where(x => x.UserName == username).ToList();
    }
}
