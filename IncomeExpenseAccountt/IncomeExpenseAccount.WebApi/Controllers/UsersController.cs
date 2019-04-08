using IncomeExpenseAccount.Business.Abstract;
using IncomeExpenseAccount.Business.Concrete;
using IncomeExpenseAccount.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IncomeExpenseAccount.WebApi.Controllers
{
    public class UsersController : ApiController
    {

        UserManager _userManager = new UserManager();

        [System.Web.Http.HttpGet]
        public List<User> Get()
        {
            return _userManager.GetAll();
        }


        //system.web.mvc ya da system.web.http nin içinde mi diye ayırt ettim.
        [System.Web.Http.HttpGet]
        public User Get(int id)
        {
            var user = _userManager.Get(u => u.UserId == id);
            return user;
        }


        [HttpPost]
        public IHttpActionResult Post(User user)
        {
            _userManager.Add(user);
            return Ok();
        }

        [System.Web.Http.HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var user = _userManager.Get(u => u.UserId == id);
            _userManager.Delete(user);
            return Ok();
        }


        [HttpPut]
        public IHttpActionResult Put(User user)
        {
            var entity = _userManager.Get(e=> e.UserId == user.UserId);
            entity.Email = user.Email;
            entity.Lastname = user.Lastname;
            entity.Name = user.Name;
            entity.Password = user.Password;
            entity.Phone = user.Phone;
            entity.Username = user.Username;
            _userManager.Update(entity);

            return Ok();
        }

    }
}
