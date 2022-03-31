using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HistoryPedia.Interfaces;
using HistoryPedia.Models;

namespace HistoryPedia.Repositories
{
    public class FavoriteRepository : IGetFavorite
    {
        private readonly GameContext _GameContext;
        public FavoriteRepository(GameContext GameContext)
        {
            _GameContext = GameContext;
        }
        public List<Game> GetFavorite(string id) => _GameContext.Games.ToList();/*.Where(x => x.UserId == id).ToList().ToList()*/
    }
}
