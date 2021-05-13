using HZShop.Data.Interfaces;
using HZShop.Data.Models;
using HZShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HZShop.Conrollers
{
    public class GamesController : Controller
    {
        private readonly IAllGames allGames;
        private readonly IGamesCategory gamesCategory;


        public GamesController(IAllGames iAllGames, IGamesCategory iGamesCategory)
        {
            allGames = iAllGames;
            gamesCategory = iGamesCategory;

        }

        [Route("Games/List")]
        [Route("Games/List/{category}")]
        public ViewResult List( string category)
        {
            string _category = category;
            IEnumerable<Game> games = null;
            string currCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                games = allGames.Games.OrderBy(i => i.id);
            }
            else
            {
                if(string.Equals("Shooter", category, StringComparison.OrdinalIgnoreCase))
                {
                    games = allGames.Games.Where(i => i.Category.id.Equals(4)).OrderBy(i => i.id);
                }
                else if(string.Equals("Strategy", category, StringComparison.OrdinalIgnoreCase))
                {
                    games = allGames.Games.Where(i => i.Category.id.Equals(1)).OrderBy(i => i.id);
                }
                else if (string.Equals("RPG", category, StringComparison.OrdinalIgnoreCase))
                {
                    games = allGames.Games.Where(i => i.Category.id.Equals(2)).OrderBy(i => i.id);
                }
                else if (string.Equals("Horror", category, StringComparison.OrdinalIgnoreCase))
                {
                    games = allGames.Games.Where(i => i.Category.id.Equals(3)).OrderBy(i => i.id);
                   
                }

                currCategory = _category;


            }
            var gameObj = new GamesListViewModel
            {
                allGames = games,
                currentCategory = currCategory
            };

            ViewBag.Title = "Games Page";

            return View(gameObj);
        }
    }
}
