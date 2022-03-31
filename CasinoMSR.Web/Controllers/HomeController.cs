using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HistoryPedia.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Web;
using HistoryPedia.Data;
using HistoryPedia.Interfaces;
using HistoryPedia.signalR;
using HistoryPedia.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.SignalR;


namespace HistoryPedia.Controllers
{
    public class HomeController : Controller
    {

        private GameContext db;
        private readonly ILogger<HomeController> _logger;
        private readonly IGetGame _getGame;

        public HomeController(ILogger<HomeController> logger, GameContext contextApp, IHubContext<ChatHub> hubContext, IGetGame getGame)
        {
            db = contextApp;
            _logger = logger;
            _getGame = getGame;
        }

        [HttpPost]
        public async Task<IActionResult> Create(Game Game)
        {
            db.Games.Add(Game);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public IActionResult Contacts()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }

        public IActionResult Details(int id)
        {
            if (id != 0)
            {
                Game game = _getGame.GetObjectGame(id);
                game.Blocks = db.BlocksInfo.Where(x => x.GameId == game.Id).ToList();
                game.GenreValue = db.Genres.FirstOrDefault(x => x.GenreId == (int)game.Genre);
                var pictures = db.Pictures;
                game.Image = pictures.FirstOrDefault(x => x.PictureName == game.ImageName);
                foreach (var item in game.Blocks)
                {
                    if (item.BlockImageName == null)
                        item.Image = pictures.FirstOrDefault(x => x.PictureName == "Def1");
                    else
                        item.Image = pictures.FirstOrDefault(x => x.PictureName == item.BlockImageName);
                }
                if (game != null)
                    return View(game);
            }

            return NotFound();
        }

        public ActionResult Index(string name)
        {
            var games = _getGame.GetAllGames;
            foreach (var item in games)
            {
                item.Image = db.Pictures.FirstOrDefault(x => x.PictureName == item.ImageName);
                item.Blocks = db.BlocksInfo.Where(x => x.GameId == item.Id).ToList();
                item.GenreValue = db.Genres.FirstOrDefault(x => x.GenreId == (int)item.Genre);

                foreach (var block in item.Blocks)
                {
                    block.GameName = item.Name;
                }
            }
            List<User> users = db.Users.ToList().OrderByDescending(i => i.TotalWon).Take(3).ToList(); 
            foreach (var item in users)
            {
                item.Image = db.Pictures.FirstOrDefault(x => x.PictureName == item.ImageName);
            }
            SearchGame dataGamesUsers = new SearchGame();
            dataGamesUsers.Games = games;
            dataGamesUsers.Users = users;
            db.SaveChanges();
            return View(dataGamesUsers);
        }

        public ActionResult Games(string name)
        {
            var games = string.IsNullOrEmpty(name) ? _getGame.GetAllGames : db.Games.Where(p => p.Name.Contains(name)).ToList();
            foreach (var item in games)
            {
                item.Image = db.Pictures.FirstOrDefault(x => x.PictureName == item.ImageName);
                item.Blocks = db.BlocksInfo.Where(x => x.GameId == item.Id).ToList();
                item.GenreValue = db.Genres.FirstOrDefault(x => x.GenreId == (int)item.Genre);

                foreach (var block in item.Blocks)
                {
                    block.GameName = item.Name;
                }
            }
            db.SaveChanges();
            return View(games);
        }
    }
}
