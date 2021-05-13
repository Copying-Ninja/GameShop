using HZShop.Data.Interfaces;
using HZShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HZShop.Data.Repository
{
    public class CategoryRepository : IGamesCategory
    {
        private readonly AppDBContent appDBContent;
        

        public CategoryRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Category> AllCategorys => appDBContent.Categories;
    }
}
