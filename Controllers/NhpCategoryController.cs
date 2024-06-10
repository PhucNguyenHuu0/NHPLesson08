using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NHPLesson08.Models;

namespace NHPLesson08.Controllers
{
    public class NhpCategoryController : Controller
    {
        public static NhpBookStore _nhpBookStore;
        public NhpCategoryController()
        {
            _nhpBookStore = new NhpBookStore();
        }

        // GET: NhpCategory
        public ActionResult NhpIndex()
        {
            var nhpcategory = _nhpBookStore.NhpCategories.FirstOrDefault();

            return View(nhpcategory);
        }
        [HttpGet]
        public ActionResult NhpCreate()
        {
            var nhpcategory = new NhpCategory();
            return View(nhpcategory);
        }
        [HttpPost]
        public ActionResult NhpCreate(NhpCategory nhpcategory)
        {
            _nhpBookStore.NhpCategories.Add(nhpcategory);
            _nhpBookStore.SaveChanges();
            return RedirectToAction("NhpIndex");
        }
    }
}