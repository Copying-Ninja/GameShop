using HZShop.Data.Interfaces;
using HZShop.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HZShop.Data.Repository
{
    public class GameRepository : IAllGames
    {
        private readonly AppDBContent appDBContent;

        public GameRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Game> Games => appDBContent.Games.Include(g => g.Category);

        public IEnumerable<Game> getFavGames => appDBContent.Games.Where(f => f.isFavorite).Include(g => g.Category);

        public Game getObjectGame(int gameId) => appDBContent.Games.FirstOrDefault(i => i.id == gameId);
     
    }
}
