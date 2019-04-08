using IncomeExpenseAccount.Business.Concrete;
using IncomeExpenseAccount.DataAccess.Concrete.EntityFramework;
using IncomeExpenseAccount.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IncomeExpenseAccountt.Models;
using IncomeExpenseAccount.Business.Abstract;
using System.Linq.Expressions;

namespace IncomeExpenseAccountt.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        //Index yerine List de yazabilirdim. Listeleme işlemi yapıyoruz
        public ActionResult IndexUser()
        {
            var userList = new UserManager().GetAll();
            return View(userList);
        }

        //NOT: Post yaptığı için iki adet action a ihtiyaç var. Bir action da view ı ekrana basarız diğerinde de butona basınca olması gereken işlemlri yaparız
        [HttpGet]
        public ActionResult AddUser(int id=0)
        {
            UserAddViewModel model = new UserAddViewModel();
            if (id!=0)
            {
                //update yapılmak istenyor id 0 değil

                //UserManager userManager = new UserManager();
                //var user= userManager.Get(um => um.UserId == id);
                var user= new UserManager().Get(x => x.UserId == id);
                model.User = user;
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult AddUser(UserAddViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (model.User.UserId != 0)
                    {
                        //var user = _context.Users.FirstOrDefault(u => u.UserId == model.User.UserId);
                        var user = new UserManager().Get(u => u.UserId == model.User.UserId);
                        user.Name = model.User.Name;
                        user.Lastname = model.User.Lastname;
                        user.Username = model.User.Username;
                        user.Phone = model.User.Phone;
                        user.Email = model.User.Email;
                        user.Password = model.User.Password;
                        new UserManager().Update(user);
                    }

                    else
                    {
                        new UserManager().Add(model.User);
                        //_context.Users.Add(model.User);
                    }

                    return View();
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
        public ActionResult DeleteUser(int id)
        {
            var user = new UserManager().Get(x=> x.UserId == id);
            new UserManager().Delete(user);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UserDetails(int id)
        {
            var model = new UserManager().Get(m=> m.UserId == id);
            return View(model);
        }
    }
}