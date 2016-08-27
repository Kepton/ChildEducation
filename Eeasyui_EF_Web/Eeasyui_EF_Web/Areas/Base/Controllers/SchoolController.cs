using Common;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Eeasyui_EF_Web.Areas.Base.Controllers
{
    public class SchoolController : Controller
    {
        //
        // GET: /School/School/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Detail()
        {
            return View();
        }

        public JsonResult GetList(BaseGridParam param)
        {
            SchoolService service = new SchoolService();
            var list = service.GetList();
            return Json(list, JsonRequestBehavior.AllowGet);
        }

    }
}
