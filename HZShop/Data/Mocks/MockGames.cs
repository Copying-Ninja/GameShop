using HZShop.Data.Interfaces;
using HZShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HZShop.Data.Mocks
{
    public class MockGames : IAllGames
    {
        private readonly IGamesCategory _categoryGames = new MockCategory();
        public IEnumerable<Game> Games 
        { 
            get
            {
                return new List<Game>
                {
                    new Game {
                        name = "Metro: Exodux",
                        shortDesc = "Передаємо за проїзд",
                        longDesc = "",
                        img = "/img/metroex.jpg",
                        price = 999,
                        isFavorite = true,
                        available = true,
                        Category = _categoryGames.AllCategorys.ElementAt(0)
                    },
                    new Game {
                        name = "XCOM:Enemy Unknown",
                        shortDesc = "Промахи на 99% гарантовані!",
                        longDesc = "",
                        img = "/img/xcomeu.png",
                        price = 299,
                        isFavorite = true,
                        available = true,
                        Category = _categoryGames.AllCategorys.ElementAt(1)
                    },
                    new Game {
                        name = "CS:GO",
                        shortDesc = "ТОП 1 шутан в Steam",
                        longDesc = "",
                        img = "/img/csgo.jpg",
                        price = 410,
                        isFavorite = true,
                        available = true,
                        Category = _categoryGames.AllCategorys.ElementAt(0)
                    },
                    new Game {
                        name = "Mount&Blade",
                        shortDesc = "Маунтенблейд",
                        longDesc = "",
                        img = "/img/mb.jpg",
                        price = 259,
                        isFavorite = true,
                        available = true,
                        Category = _categoryGames.AllCategorys.ElementAt(2)
                    },
                     new Game {
                        name = "Penumbra",
                        shortDesc = "Amnesia для бідних",
                        longDesc = "",
                        img = "/img/penumbra.jpg",
                        price = 99,
                        isFavorite = false,
                        available = true,
                        Category = _categoryGames.AllCategorys.ElementAt(3)
                    },
                };
            }
        }
        public IEnumerable<Game> getFavGames { get; set; }

        public Game getObjectGame(int gameId)
        {
            throw new NotImplementedException();
        }
    }
}
