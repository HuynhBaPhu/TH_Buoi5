using HuynhBaPhuc_Buoi5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HuynhBaPhuc_Buoi5.Controllers
{
    public class RubikController : Controller
    {
        // GET: Rubikller
        dbRubikStore data = new dbRubikStore();
        public ActionResult Index()
        {
            var all_rubik = data.Rubiks.ToList();
            return View(all_rubik);
        }
    }
}