using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using HZShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HZShop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {


           if (!content.Categories.Any())
            {
                content.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!content.Games.Any())
            {
                content.AddRange(new Game
                {
                    name = "Metro: Exodux",
                    shortDesc = "Передаємо за проїзд",
                    longDesc = "",
                    img = "/img/metroex.jpg",
                    price = 999,
                    isFavorite = true,
                    available = true,
                    Category = Categories["Шутер"]
                },
                    new Game
                    {
                        name = "XCOM:Enemy Unknown",
                        shortDesc = "Промахи на 99% гарантовані!",
                        longDesc = "",
                        img = "/img/xcomeu.png",
                        price = 299,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Шутер"]
                    },
                    new Game
                    {
                        name = "CS:GO",
                        shortDesc = "ТОП 1 шутан в Steam",
                        longDesc = "",
                        img = "/img/csgo.jpg",
                        price = 410,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Шутер"]
                    },
                    new Game
                    {
                        name = "Mount&Blade",
                        shortDesc = "Маунтенблейд",
                        longDesc = "",
                        img = "/img/mb.jpg",
                        price = 259,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Шутер"]
                    },
                     new Game
                     {
                         name = "Penumbra",
                         shortDesc = "Amnesia для бідних",
                         longDesc = "",
                         img = "/img/penumbra.jpg",
                         price = 99,
                         isFavorite = false,
                         available = true,
                         Category = Categories["Шутер"]
                     });
            }
            content.SaveChanges();

        }
        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if(category == null)
                {
                    var list = new Category[]
                    {
                    new Category { categoryName = "Шутер", desc = "Для любителів постріляти" },
                    new Category { categoryName = "Стратегія", desc = "Для тих хто любить подумати перед тим як зробити" },
                    new Category { categoryName = "РПГ", desc = "Для тих хто любить проводити час прокачуючи персонажа" },
                    new Category { categoryName = "Хорор", desc = "Для любителів полоскотати нерви" }

                    };
                    category = new Dictionary<string, Category>();
                    foreach(Category el in list)
                    {
                        category.Add(el.categoryName, el);
                    }
                }
                return category;
            }
        }
    }
}
