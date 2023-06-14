using SwadeshProperties_DocumentManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.IO;
using SwadeshProperties_DocumentManagement.ViewModels;

namespace SwadeshProperties_DocumentManagement.Controllers
{
    public class InfoController : Controller
    {
        private readonly SplDbContext db = new SplDbContext();
        // GET: Info
        public ActionResult Index()
        {
            var data = db.DocumentInformations.Include(d => d.DocumentCategoryInfo).ToList();
            return View(data);
        }
        public ActionResult Create()
        {
            ViewBag.Categories = db.DocumentCategoryInfoes.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult Upload()
        {
            HttpFileCollectionBase files = Request.Files;
            var saved = new List<ImagePathResponse>();
            for (int i = 0; i < files.Count; i++)
            {
                HttpPostedFileBase file = files[i];
                var fileName = Path.GetFileNameWithoutExtension(Path.GetRandomFileName()) + Path.GetExtension(file.FileName);
                var savePath = Path.Combine(Server.MapPath("~/Uploads"), fileName);
                file.SaveAs(savePath);
                saved.Add(new ImagePathResponse { FileName = file.FileName, SavedFileName=fileName });
            }
            return Json(saved);
        }
        [HttpPost]
        public ActionResult Insert(DocumentInformation data) 
        {
            if(ModelState.IsValid)
            {
                db.DocumentInformations.Add(data);
                db.SaveChanges();
                return Json(new { success = true, msg = "Data Saved" });
            }
            return Json(new { success = false, msg = "Failed to save data" });
        }
    }
}