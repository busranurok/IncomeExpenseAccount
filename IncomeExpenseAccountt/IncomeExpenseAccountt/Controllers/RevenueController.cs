using IncomeExpenseAccount.Business.Concrete;
using IncomeExpenseAccountt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IncomeExpenseAccountt.Controllers
{
    public class RevenueController : Controller
    {
        RevenueManager _revenueManager = new RevenueManager();
        // GET: Revenue
        [HttpGet]
        public ActionResult ListRevenue()
        {
            var model = _revenueManager.GetAllWithCategory();
            return View(model);
        }

        [HttpGet]
        public ActionResult DeleteRevenue(int id)
        {
            var revenue = _revenueManager.Get(r => r.RevenueId == id);
            _revenueManager.Delete(revenue);
            return RedirectToAction("ListRevenue");
        }

        [HttpGet]
        public ActionResult AddRevenue(int id=0)
        {
            var model = new RevenueAddViewModel();

            CategoryManager categoryTypeManager = new CategoryManager();
            var categories = categoryTypeManager.GetAll();
            ViewBag.Categories = categories;
            if (id != 0)
            {
                var revenue = _revenueManager.Get(r=> r.RevenueId == id);
                model.Revenue = revenue;
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult AddRevenue(RevenueAddViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Revenue.RevenueId != 0)
                {
                    //update
                    var revenue = _revenueManager.Get(r=> r.RevenueId == model.Revenue.RevenueId);
                    revenue.RevenueName = model.Revenue.RevenueName;
                    revenue.RevenueDescription = model.Revenue.RevenueDescription;
                    revenue.RevenueAmount = model.Revenue.RevenueAmount;
                    revenue.DateTime = model.Revenue.DateTime;
                    revenue.CategoryId = model.Revenue.CategoryId;
                    new RevenueManager().Update(revenue);
                }

                else
                {
                    //add
                    new RevenueManager().Add(model.Revenue);
                }
            }

            else
            {
                ViewBag.Message = "Model yanlış";
                return View();
            }
            return RedirectToAction("ListRevenue");
        }

        public ActionResult RevenueDetails(int id)
        {
            var model = _revenueManager.GetWithCategory(m => m.RevenueId == id);
            return View(model);
        }
    }
}