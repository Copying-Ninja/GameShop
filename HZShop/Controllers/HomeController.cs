using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HZShop.Data.Interfaces;
using HZShop.Data.Models;
using HZShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HZShop.Conrollers
{
    public class HomeController : Controller
    {
        private readonly IAllGames _gameRep;


        public HomeController(IAllGames gameRep)
        {
            _gameRep = gameRep;
       
        }
        public ViewResult Index()
        {
            var homeGames = new HomeViewModel
            {
                favGames = _gameRep.getFavGames
            };
            return View(homeGames);
        }
/*        public IActionResult Index()
        {

            return View();
        }*/
    }
}
