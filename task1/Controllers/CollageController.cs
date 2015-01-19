using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace task1.Controllers
{
    [Authorize]
    public class CollageController : Controller
    {
        //
        // GET: /Collage/
        public ActionResult Photo()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Photo(IEnumerable<HttpPostedFileBase> file1)
        {
            foreach (var upload in file1)
            {
                if (upload==null) continue;
                string fileName = Path.GetFileName(upload.FileName);
                // сохраняем файл в папку Files в проекте
                upload.SaveAs(Server.MapPath("~/uploads/" + fileName));
               
            }
            return View();
        }

      /*  [HttpPost]
        public ActionResult Photo(HttpPostedFileBase upload)
        {
            if (upload != null)
            {
                // получаем имя файла
                string fileName = Path.GetFileName(upload.FileName);
                // сохраняем файл в папку Files в проекте
                upload.SaveAs(Server.MapPath("~/uploads/" + fileName));
            }
            return View();
        }
       /* [HttpPost]
        public ActionResult Photo(IEnumerable<HttpPostedFileBase> files)
        {
            foreach (var file in files)
            {
                if (file.ContentLength <= 0) continue;
                var fileName = Path.GetFileName(file.FileName);
                if (fileName == null) continue;
                var path = Path.Combine(Server.MapPath("~/uploads"), fileName);
                file.SaveAs(path);
            }
            return View();
        }      */
	}
}