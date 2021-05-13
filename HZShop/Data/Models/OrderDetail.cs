using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HZShop.Data.Models
{
    public class OrderDetail
    {
        public int id { get; set; }
        public int orderId { get; set; }

        public int GameId { get; set; }
        public uint Price { get; set; }
        public virtual Game Game { get; set; }
        public virtual Order Order { get; set; }

    }
}
