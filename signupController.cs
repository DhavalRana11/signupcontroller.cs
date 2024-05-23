using QuickShoap.Infrastructure;
using QuickShoap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuickShoap.Controllers
{
    public class signupController : Controller
    {
        // GET: signup
        public ActionResult Index()
        {

            signupmodel obj = new signupmodel();


            return View(obj);
        }
        [HttpPost]
        public ActionResult Index(signupmodel model)
        {
          int result=  DbAccess.User.sellerInsert(model.password, model.firstname, model.lastname, model.Email, model.gender, model.Residency, model.City);
            if (result == 1)
            {
                this.ShowMessage(MessageExtensions.MessageType.Success, "signup successfully", false);
            }
            else
            {
                this.ShowMessage(MessageExtensions.MessageType.Error, "email already exists successfully", false);

            }
            model = new signupmodel();
            return View(model);

        }



    }
}