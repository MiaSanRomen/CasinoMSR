using System.Linq;
using System.Threading.Tasks;
using HistoryPedia.Interfaces;
using HistoryPedia.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CasinoMSR.Web.Controllers
{
    [Authorize]
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
            user.FavoriteGames = _getFavorite.GetFavorite(user.UserName);
            foreach (var item in user.FavoriteGames)
            {
                item.Game = db.Games.FirstOrDefault(x => x.Id == item.GameId);
                item.Game.Image = db.Pictures.FirstOrDefault(x => x.PictureName == item.Game.ImageName);
                item.Game.GenreValue = db.Genres.FirstOrDefault(x => x.GenreId == (int)item.Game.Genre);
            }
            db.SaveChanges();

            return View(user);
        }


        public async Task<IActionResult> AddToFavorite(int id)
        {
            Game game = db.Games.FirstOrDefault(g => g.Id == id);
            User user = db.Users.FirstOrDefault(g => g.UserName == User.Identity.Name);
            user.FavoriteGames = _getFavorite.GetFavorite(user.UserName);
            if (game != null)
            {
                game.Recommendations++;
                FavoriteGame favoriteGame = new FavoriteGame { GameId = game.Id, UserName = user.UserName, Game = game};
                db.FavoriteGames.Add(favoriteGame);
                user.FavoriteGames.Add(favoriteGame);
            }
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> RemoveFromFavorite(int id)
        {
            User user = db.Users.FirstOrDefault(g => g.UserName == User.Identity.Name);
            FavoriteGame favoriteGame = db.FavoriteGames.FirstOrDefault(fg => fg.GameId == id);
            Game game = db.Games.FirstOrDefault(g => g.Id == id);
            user.FavoriteGames = _getFavorite.GetFavorite(user.UserName);
            if (favoriteGame != null)
            {
                game.Recommendations--;
                user.FavoriteGames.Remove(favoriteGame);
                db.Entry(favoriteGame).State = EntityState.Deleted;
            }
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
