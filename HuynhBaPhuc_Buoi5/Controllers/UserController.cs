using HuynhBaPhuc_Buoi5.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HuynhBaPhuc_Buoi5.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(User user)
        {
            dbRubikStore context = new dbRubikStore();
            context.Users.AddOrUpdate(user);
            context.SaveChanges();
            return RedirectToActionPermanent("ListBook");
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string tk)
        {
            dbRubikStore context = new dbRubikStore();
            context.Users.AddOrUpdate(user);
            context.SaveChanges();
            return RedirectToActionPermanent("ListBook");
        }
    }
}