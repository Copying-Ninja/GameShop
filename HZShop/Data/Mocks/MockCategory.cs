using HZShop.Data.Interfaces;
using HZShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HZShop.Data.Mocks
{
    public class MockCategory : IGamesCategory
    {
        public IEnumerable<Category> AllCategorys
        {
            get
            {
                return new List<Category>
                {
                    new Category { categoryName = "Шутери", desc = "Для любителів постріляти" },
                    new Category { categoryName = "Стратегії", desc = "Для тих хто любить подумати перед тим як зробити" },
                    new Category { categoryName = "РПГ", desc = "Для тих хто любить проводити час прокачуючи персонажа" },
                    new Category { categoryName = "Хорори", desc = "Для любителів полоскотати нерви" },
                };
            }
        }
    }
}
