using SwadeshProperties_DocumentManagement.Models;
using SwadeshProperties_DocumentManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SwadeshProperties_DocumentManagement.Controllers
{
    public class DocumentsController : Controller
    {
        private readonly SplDbContext db = new SplDbContext();
        public DocumentsController() {
            db.Configuration.ProxyCreationEnabled = false;
        }
        // GET: Documents
        public ActionResult Index()
        {
           
            return View(db.DocumentCategoryInfoes.ToList());
        }
        //Partials
        public ActionResult CategoryInsert() {
            return PartialView("_CategoryInfoInsert");
        }
        public ActionResult CategoryEdit()
        {
            return PartialView("_CategoryInfoEdit");
        }
        //Data
        [HttpGet]
        public ActionResult CategoryList() {
            var data = db.DocumentCategoryInfoes.ToList();
            return Json(data, JsonRequestBehavior.AllowGet);
        
        }
        [HttpPost]
        public ActionResult CategoryInsert(DocumentCategoryInfo model)
        {
            if(ModelState.IsValid)
            {
                db.DocumentCategoryInfoes.Add(model);
                db.SaveChanges();
                return Json(new { success = true, data = model });

            }
            return Json(new { success = false, data = new{ } });
        }
        [HttpPost]
        public ActionResult CategoryEdit(DocumentCategoryInfo model)
        {
            if (ModelState.IsValid)
            {
                db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return Json(new { success = true, data = model });

            }
            return Json(new { success = false, data = new { } });
        }
    }
}