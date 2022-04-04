using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CasinoMSR.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Web;
using CasinoMSR.Web.Models;
using CasinoMSR.Web.Data;
using CasinoMSR.Web.Interfaces;
using CasinoMSR.Web.signalR;
using CasinoMSR.Web.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.SignalR;


namespace CasinoMSR.Web.Controllers
{
    [Authorize]
    public class GameController : Controller
    {

        private GameContext db;
        private readonly ILogger<GameController> _logger;
        private readonly IGetGame _getGame;

        public GameController(ILogger<GameController> logger, GameContext contextApp, IHubContext<ChatHub> hubContext, IGetGame getGame)
        {
            db = contextApp;
            _logger = logger;
            _getGame = getGame;
        }

        public async Task<IActionResult> CreateGame(int id)
        {
            Game game = db.Games.FirstOrDefault(g => g.Id == id);
            User user = db.Users.FirstOrDefault(g => g.UserName == User.Identity.Name);
            game.Sessions = db.GameSessions.Where(s => s.GameId == game.Id).ToList();
            if (game.Sessions.Any(session => session.UserName.Equals(user.UserName)))
            {
                var session = game.Sessions.FirstOrDefault(s => s.UserName.Equals(user.UserName));
                game.Sessions.Remove(session);
                db.Entry(session).State = EntityState.Deleted;
                await db.SaveChangesAsync();
            }
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string domain = new string(Enumerable.Repeat(chars, 12)
                .Select(s => s[random.Next(s.Length)]).ToArray());
            GameSession gameSession = new GameSession{Domain = domain, GameId = game.Id, UserName = user.UserName };
            db.GameSessions.Add(gameSession);
            game.Sessions.Add(gameSession);
            await db.SaveChangesAsync();
            return RedirectToAction("Game", new { domain = gameSession.Domain });
        }

        public IActionResult Game(string domain)
        {
            var gameSession = db.GameSessions.Any(session => session.Domain.Equals(domain)) ? 
                db.GameSessions.FirstOrDefault(session => session.Domain.Equals(domain)) : null;
            var user = db.Users.Any(g => g.UserName == User.Identity.Name) ?
                db.Users.FirstOrDefault(g => g.UserName == User.Identity.Name) : null;
            if (gameSession != null && user != null)
                if (gameSession.UserName.Equals(user.UserName))
                {
                    Game game = _getGame.GetObjectGame(gameSession.GameId);
                    if (game != null)
                        return View(game.View, user);
                }
            return NotFound();
        }

    }
}
