using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LHBOL;
using LHBLL;

namespace LHUI.Controllers
{
    public class CategoriesController : Controller
    {
        readonly CategoryBL objCategoryBll;
        public CategoriesController()
        {
            objCategoryBll = new CategoryBL();
        }
        public IActionResult Index()
        {
            var categories = objCategoryBll.GetAllCategory();
            return View(categories);
        }
    }
}
