using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HZShop.Data.Interfaces;
using HZShop.Data.Models;
using HZShop.Data.Repository;
using HZShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HZShop.Conrollers
{
    public class ShopCartController : Controller
    {
        private readonly IAllGames _gameRep;
        private readonly ShopCart _shopCart;

        public ShopCartController(IAllGames gameRep, ShopCart shopCart)
        {
            _gameRep = gameRep;
            _shopCart = shopCart;
        }

        public IActionResult Index()
        {
            var items = _shopCart.getShopItems();
            _shopCart.listCartItems = items;

            var obj = new ShopCartViewModel
            {
                shopCart = _shopCart
            };
            return View(obj);
        }

        public RedirectToActionResult addToCart(int id)
        {
            var item = _gameRep.Games.FirstOrDefault(i => i.id == id);
            if(item != null)
            {
                _shopCart.AddToCart(item);
            }
            return RedirectToAction("Index");
        }
    }
}
