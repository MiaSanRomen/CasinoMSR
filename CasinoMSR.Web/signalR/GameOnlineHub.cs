using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CasinoMSR.Web.Controllers;
using CasinoMSR.Web.Models;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace CasinoMSR.Web.signalR
{
    public class GameOnlineHub : Hub
    {
        public static GameContext db;
        private readonly ILogger<GameController> _logger;

        public GameOnlineHub(ILogger<GameController> logger, GameContext contextApp)
        {
            db = contextApp;
            _logger = logger;
        }

        public async Task GetSpinValue(string bid, string username)
        {
            User user = db.Users.FirstOrDefault(g => g.UserName == username);
            user.TotalMoney = user.TotalMoney - int.Parse(bid);
            await db.SaveChangesAsync();
            await this.Clients.All.SendAsync("Spin", new Random().Next(0, 36).ToString(), user.TotalMoney);
        }

        public async Task WonMoney(string won, string bid, string username)
        {
            User user = db.Users.FirstOrDefault(g => g.UserName == username);
            user.TotalWon = user.TotalWon + int.Parse(won);
            user.TotalMoney = user.TotalMoney + int.Parse(won) + int.Parse(bid);
            await db.SaveChangesAsync();
            await this.Clients.All.SendAsync("Win", user.TotalMoney);
        }
    }
}
