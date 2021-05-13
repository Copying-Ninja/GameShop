using HZShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HZShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Game> favGames { get; set; }
    }
}
