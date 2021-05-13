using HZShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HZShop.Data.Interfaces
{
    public interface IAllGames
    {
        IEnumerable<Game> Games { get;  }
        IEnumerable<Game> getFavGames { get; }
        Game getObjectGame(int gameId);
    }
}
