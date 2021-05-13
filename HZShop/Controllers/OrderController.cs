using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HZShop.Data.Interfaces;
using HZShop.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace HZShop.Conrollers
{
    public class OrderController : Controller
    {
        private readonly IAllOrders allOrders;
        private readonly ShopCart shopCart;
        public OrderController(ShopCart shopCart, IAllOrders allOrders)
        {
            this.shopCart = shopCart;
            this.allOrders = allOrders;
        }
        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            shopCart.listCartItems = shopCart.getShopItems();
            if(shopCart.listCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Корзина порожня");
            }
            if(ModelState.IsValid)
            {
                allOrders.createOrder(order);
                return RedirectToAction("Complate");
            }
            return View(order);
        }

        public IActionResult Complate()
        {
            ViewBag.Message = "Замовленя успішно оброблено";
            return View();
        }
    }
}
