using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using datacms;
using huycms.Models;

namespace huycms.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/

        public ActionResult Index()
        {
            AccountViewModel model = new AccountViewModel();
            using (CmsContext ctx = new CmsContext())
            {
                model.ListAccount = ctx.Account.Where(a => a.IsDelete == false).ToList();
            }
            
            return View(model);
        }

        public JsonResult DataTablesAccount()
        {
            using (CmsContext ctx = new CmsContext())
            {
                //var data = ctx.Account;
                return Json(ctx.Account, JsonRequestBehavior.AllowGet);
            }
        }
    }
}
