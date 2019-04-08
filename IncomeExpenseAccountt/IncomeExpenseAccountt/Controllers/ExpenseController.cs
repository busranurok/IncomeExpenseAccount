using IncomeExpenseAccount.Business.Concrete;
using IncomeExpenseAccountt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IncomeExpenseAccountt.Controllers
{
    public class ExpenseController : Controller
    {
        ExpenseManager _expenseManager = new ExpenseManager();
        // GET: Expense
        [HttpGet]
        public ActionResult ListExpense()
        {
            var model = _expenseManager.GetAllWithCategory();
            return View(model);
        }

        [HttpGet]
        public ActionResult DeleteExpense(int id)
        {
            var expense = _expenseManager.Get(e => e.ExpenseId == id);
            _expenseManager.Delete(expense);
            return RedirectToAction("ListExpense");
        }

        [HttpGet]
        public ActionResult AddExpense(int id=0)
        {
            var model = new ExpenseAddViewModel();

            CategoryManager categoryManager = new CategoryManager();
            var categories = categoryManager.GetAll();
            ViewBag.Categories = categories;

            if ( id!= 0 )
            {
                var expense = _expenseManager.Get(e=>e.ExpenseId == id);
                model.Expense = expense;
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult AddExpense(ExpenseAddViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Expense.ExpenseId != 0)
                {
                    //update
                    var expense = _expenseManager.Get(e=>e.ExpenseId == model.Expense.ExpenseId);
                    expense.ExpenseName = model.Expense.ExpenseName;
                    expense.ExpenseDescription = model.Expense.ExpenseDescription;
                    expense.ExpenseAmount = model.Expense.ExpenseAmount;
                    expense.DateTime = model.Expense.DateTime;
                    expense.CategoryId = model.Expense.CategoryId;
                    _expenseManager.Update(expense);
                }

                else
                {
                    //add
                    _expenseManager.Add(model.Expense);
                }
            }

            else
            {
                ViewBag.Message = "Model yanlış";
                return View();
            }

            return RedirectToAction("ListExpense");
        }

        [HttpGet]
        public ActionResult ExpenseDetails(int id)
        {
            var model = _expenseManager.GetWithCategory(e => e.ExpenseId == id);
            return View(model);
        }
    }
}