using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LHBOL;

namespace LHDAL
{
    public interface ICategoryDb
    {
        IEnumerable<Category> GetAllCategory();
        Category GetCategoryById(int Id);
        bool CreateCategory(Category category);
        bool UpdateCategory(Category category);
        bool DeleteCategory(int Id);
    }
    public class CategoryDb : ICategoryDb
    {
        readonly LHDBContext lhDbContext;
        public CategoryDb()
        {
            lhDbContext = new LHDBContext();
        }
        public bool CreateCategory(Category category)
        {
            lhDbContext.Add(category);
            lhDbContext.SaveChanges();
            return true;
        }

        public bool DeleteCategory(int Id)
        {
            var category = lhDbContext.Categories.Find(Id);
            lhDbContext.Remove(category);
            lhDbContext.SaveChanges();
            return true;
        }

        public IEnumerable<Category> GetAllCategory()
        {
            return lhDbContext.Categories.ToList();
        }

        public Category GetCategoryById(int Id)
        {
            return lhDbContext.Categories.Find(Id);
            //return category;
        }

        public bool UpdateCategory(Category category)
        {
            lhDbContext.Update(category);
            lhDbContext.SaveChanges();
            return true;
        }
    }
}
