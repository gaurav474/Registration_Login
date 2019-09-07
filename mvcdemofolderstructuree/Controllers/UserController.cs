using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcdemofolderstructuree.Models;

namespace mvcdemofolderstructuree.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult List()
        {
            List<UserModel> userlist = new List<UserModel>();

            var user = new UserModel(1, "Gaurav", "Gaurav@.com", "abc", "987654321", "1.jpg", "male", 1);
            userlist.Add(user);

            user = new UserModel(1, "Gajjar", "gg@.com", "def", "987654322", "2.jpg", "male", 1);
            userlist.Add(user);



            return View(userlist);
        }
        [HttpGet]
        public ActionResult SignUpAuto()
        {
            UserModel userModel = new UserModel();
            userModel.StateId = new StateModel();
            SelectList countryList = new SelectList(userModel.StateId.GetCountries, "CountryId", "CountryName");

            SelectList stateList = new SelectList(userModel.GetStates, "StateId", "StateName");

            ViewBag.StateId = stateList;
            ViewBag.CountryId = countryList;

            return View();
        }
        [HttpPost]
        public ActionResult SignUpAuto(UserModel userModel)
        {
            // UserModel userModel = new UserModel();
            userModel.StateId = new StateModel();
            SelectList countryList = new SelectList(userModel.StateId.GetCountries, "CountryId", "CountryName");

            SelectList stateList = new SelectList(userModel.GetStates, "StateId", "StateName");

            ViewBag.StateId = stateList;
            ViewBag.CountryId = countryList;

            return View();
        }
    }
}