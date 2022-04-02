using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HistoryPedia.Interfaces;
using HistoryPedia.Models;

namespace CasinoMSR.Web.Repositories
{
    public class GameRepository : IGetGame
    {
        private readonly GameContext _GameContext;
        public GameRepository(GameContext GameContext)
        {
            _GameContext = GameContext;
        }
        public Game GetObjectGame(int id) => _GameContext.Games.FirstOrDefault(p => p.Id == id);
        public List<Game> GetAllGames => _GameContext.Games.ToList();
    }
}
