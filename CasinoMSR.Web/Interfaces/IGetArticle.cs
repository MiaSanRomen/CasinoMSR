using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CasinoMSR.Web.Models;

namespace CasinoMSR.Web.Interfaces
{
    public interface IGetGame
    {
        Game GetObjectGame(int id);
        List<Game> GetAllGames { get; }
    }
}
