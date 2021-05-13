using HZShop.Data.Interfaces;
using HZShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HZShop.Data.Repository
{
    public class OrdersRepository : IAllOrders
    {
        private readonly AppDBContent appDBContent;
        private readonly ShopCart shopCart;
        public OrdersRepository(AppDBContent appDBContent, ShopCart shopCart)
        {
            this.shopCart = shopCart;
            this.appDBContent = appDBContent;
        }

        public void createOrder(Order order)
        {
            order.ortderTime = DateTime.Now;
            
            appDBContent.Order.Add(order);
            appDBContent.SaveChanges();



            var items = shopCart.listCartItems;

            foreach(var el in items)
            {
                var orderDetails = new OrderDetail()
                {
                    GameId = el.Game.id,
                    orderId = order.id,
                    Price = el.Game.price
                };
                appDBContent.OrderDetail.Add(orderDetails);
            }
            appDBContent.SaveChanges();
        }
    }
}
