using System;
using System.Collections.Generic;
using LHBOL;
using LHDAL;

namespace LHBLL
{
    interface ICategoryBL
    {
        IEnumerable<Category> GetAllCategory();
        Category GetCategoryById(int Id);
        bool CreateCategory(Category category);
        bool UpdateCategory(Category category);
        bool DeleteCategory(int Id);
    }
    public class CategoryBL : ICategoryBL
    {
        readonly CategoryDb categoryDb;
        public CategoryBL()
        {
            categoryDb = new CategoryDb();
        }
        public bool CreateCategory(Category category)
        {
            return categoryDb.CreateCategory(category);
        }

        public bool DeleteCategory(int Id)
        {
            return categoryDb.DeleteCategory(Id);
        }

        public IEnumerable<Category> GetAllCategory()
        {
            return categoryDb.GetAllCategory();
        }

        public Category GetCategoryById(int Id)
        {
            return categoryDb.GetCategoryById(Id);
        }

        public bool UpdateCategory(Category category)
        {
            return categoryDb.UpdateCategory(category);
        }
    }
}
