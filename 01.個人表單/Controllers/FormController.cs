using _01.個人表單.Models;
using _01.個人表單.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _01.個人表單.Controllers
{
    public class FormController : Controller
    {
        private EdenContext db = new EdenContext();
        // GET: Form
        public ActionResult Index()
        {
            return View(db.InfosList.ToList());
        }
        public ActionResult Create() {
            return View();
        }

        [HttpPost]//使用Post
        [ValidateAntiForgeryToken]//防止攻擊
        public ActionResult Create([Bind(Include = "id,Name,Phone,Email,Gender")] Infos Info) {
            if (ModelState.IsValid) {
                db.InfosList.Add(Info);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(Info);
        }
        [HttpPost]//使用Post
        [ValidateAntiForgeryToken]//防止攻擊
        public ActionResult UserData([Bind(Include = "id,Name,Phone,Email,Gender")] Infos Info) {

            if (ModelState.IsValid) {
                db.InfosList.Add(Info);
                db.SaveChanges();
                return RedirectToAction("Index");//強制跳去別的方法
            }

            return View("Create", Info);//回到Create方法 並且夾帶Info
        }

        public ActionResult PassViewModel() {
            PeopleViewModel PeopleVM = new PeopleViewModel();
            PeopleVM.Infos1 = db.InfosList;
            PeopleVM.Infos2 = db.InfosList;
            return View(PeopleVM);
        }
    }
}