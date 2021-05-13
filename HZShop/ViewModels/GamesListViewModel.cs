using HZShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HZShop.ViewModels
{
    public class GamesListViewModel
    {
        public IEnumerable<Game> allGames { get; set; }
        public string currentCategory { get; set; }
    }
}
