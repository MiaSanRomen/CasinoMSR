using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HistoryPedia.Data;
using HistoryPedia.Interfaces;
using HistoryPedia.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HistoryPedia.Controllers
{
    //[Authorize]
    public class FavoriteController : Controller
    {
        private GameContext db;
        private readonly IGetFavorite _getFavorite;
        private readonly IGetGame _getGame;
        public FavoriteController(GameContext contextArt, IGetFavorite getFavorite, IGetGame getGame)
        {
            db = contextArt;
            _getFavorite = getFavorite;
            _getGame = getGame;
        }

        public ActionResult Index()
        {
            User user = db.Users.ToList().FirstOrDefault(g => g.UserName == User.Identity.Name);
            //user.FavoriteGames = _getFavorite.GetFavorite(user.Id);
            
            //if (user.FavoriteGames != null)
            //{
            //    foreach (var item in user.FavoriteGames)
            //    {
            //        item.Image = db.Pictures.FirstOrDefault(x => x.PictureName == item.ImageName);
            //    }
            //}
            //db.SaveChanges();
            return View(user);
        }


        //public async Task<IActionResult> AddToFavorite(int id)
        //{
        //    Game Game = db.Games.FirstOrDefault(g => g.Id == id);
        //    User user = dbUsers.Users.FirstOrDefault(g => g.UserName == User.Identity.Name);
        //    if (Game != null)
        //    {
        //        Game.UserId = user.Id;
        //    }
        //    await db.SaveChangesAsync();
        //    return RedirectToAction("Index");
        //}

        //public async Task<IActionResult> RemoveFromFavorite(int id)
        //{
        //    Game Game = db.Games.FirstOrDefault(g => g.Id == id);
        //    User user = dbUsers.Users.FirstOrDefault(g => g.UserName == User.Identity.Name);
        //    user.FavoriteGames = db.Games.Where(x => x.UserId == user.Id).ToList();
        //    if (Game != null)
        //    {
        //        user.FavoriteGames.Remove(Game);
        //        Game.UserId = null;
        //    }
        //    await db.SaveChangesAsync();
        //    return RedirectToAction("Index");
        //}
    }
}
