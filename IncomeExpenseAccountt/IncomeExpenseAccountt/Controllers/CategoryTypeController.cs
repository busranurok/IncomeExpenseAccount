using IncomeExpenseAccount.Business.Concrete;
using IncomeExpenseAccountt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IncomeExpenseAccountt.Controllers
{
    public class CategoryTypeController : Controller
    {
        CategoryTypeManager _categoryTypeManager = new CategoryTypeManager();
        // GET: 
        [HttpGet]
        public ActionResult ListCategoryType()
        {
            //var categoryList = _categoryTypeManager.GetAll(null);
            var categoryList = _categoryTypeManager.GetAll();
            return View(categoryList);
        }

        //get ile ben sayfa istiyorum
        [HttpGet]
        public ActionResult AddCategoryType(int id=0)
        {
            CategoryTypeAddViewModel model = new CategoryTypeAddViewModel();

            if (id != 0)
            {
                var categoryType = new CategoryTypeManager().Get(x => x.CategoryTypeId == id);
                model.CategoryType = categoryType;
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult AddCategoryType(CategoryTypeAddViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (model.CategoryType.CategoryTypeId != 0)
                    {
                        //var user = _context.Users.FirstOrDefault(u => u.UserId == model.User.UserId);
                        var categoryType = new CategoryTypeManager().Get(c=> c.CategoryTypeId == model.CategoryType.CategoryTypeId);
                        categoryType.CategoryTypeId = model.CategoryType.CategoryTypeId;
                        categoryType.CategoryTypeName = model.CategoryType.CategoryTypeName;
                        categoryType.CategoryTypeDescription = model.CategoryType.CategoryTypeDescription;
                        new CategoryTypeManager().Update(categoryType);
                    }

                    else
                    {
                        new CategoryTypeManager().Add(model.CategoryType);
                        //_context.Users.Add(model.User);
                    }

                    return RedirectToAction("List");
                }
                catch (Exception exception)
                {
                    ViewBag.Message = exception.Message;
                    return View();
                }
            }
            else
            {
                ViewBag.Message = "Model yanlış";
                return View();
            }
        }

        [HttpGet]
        public ActionResult DeleteCategoryType(int id)
        {
            var categoryType = new CategoryTypeManager().Get(c=>c.CategoryTypeId == id);
            new CategoryTypeManager().Delete(categoryType);
            return RedirectToAction("List");
        }

        public ActionResult CategoryTypeDetails(int id)
        {
            var model = _categoryTypeManager.Get(x => x.CategoryTypeId == id);
            return View(model);
        }
    }
 }