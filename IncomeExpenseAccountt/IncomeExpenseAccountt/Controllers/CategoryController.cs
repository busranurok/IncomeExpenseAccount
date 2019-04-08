using IncomeExpenseAccount.Business.Concrete;
using IncomeExpenseAccountt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IncomeExpenseAccountt.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        [HttpGet]
        public ActionResult ListCategory()
        {
            CategoryManager categoryManager = new CategoryManager();
            var model = categoryManager.GetAllWithCategoryType();
            return View(model);
        }

        [HttpGet]
        public ActionResult DeleteCategory(int id)
        {
            CategoryManager categoryManager = new CategoryManager();
            var category = categoryManager.Get(c => c.CategoryId == id);
            categoryManager.Delete(category);
            return RedirectToAction("ListCategory");
        }

        [HttpGet]
        public ActionResult AddCategory(int id=0)
        {
            //Category i içeren yeni bir model class ı oluşturduk
            var model = new CategoryAddViewModel();

            CategoryTypeManager categoryTypeManager = new CategoryTypeManager();
            var categoryTypes = categoryTypeManager.GetAll();
            ViewBag.CategoryTypes = categoryTypes;
            //model.Category dediğimizde null gelmemesi için model kısmında constructor unda new leme yapıyoruz
            if (id !=0)
            {
                var category = new CategoryManager().Get(c => c.CategoryId == id);
                model.Category = category;
            }
            return View(model);
        }

        //Bind : Modelin içerisini doldurup bize verir, değişkenlere veriyi bağlar.
        //post un view ı olmaz
        [HttpPost]
        public ActionResult AddCategory(CategoryAddViewModel model)
        {
            //model doğrulandı mı, entity de validation için yazılır.
            if (ModelState.IsValid)
            {
                if (model.Category.CategoryId != 0)
                {
                    //update
                    var category = new CategoryManager().Get(c => c.CategoryId == model.Category.CategoryId);
                    category.CategoryDescription = model.Category.CategoryDescription;
                    category.CategoryName = model.Category.CategoryName;
                    //ilişkili nesenelerde onların idi leri set edilir.
                    category.CategoryTypeId = model.Category.CategoryTypeId;
                    new CategoryManager().Update(category);
                }

                else
                {
                    //add
                    //veritabanında veri olmadığı için bir şey getirilmiyor bu yüzden direkt bu şekilde yazılır
                    new CategoryManager().Add(model.Category);
                }
            }

            else
            {
                ViewBag.Message = "Model yanlış";
                return View();
            }

            return RedirectToAction("ListCategory");
        }

        public ActionResult CategoryDetails(int id)
        {
            var model = new CategoryManager().GetWithCategoryType(x => x.CategoryId == id);
            return View(model);
        }
    }
}