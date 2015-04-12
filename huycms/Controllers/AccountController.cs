using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using datacms;
using huycms.Models;
using AutoMapper;

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

        public ActionResult Create()
        {
            AccountViewModel model = new AccountViewModel();
            model.ActionState = BaseViewModel.ActionState.Create;
            return View("Edit", model);
        }

        public ActionResult Detail(string id)
        {
            AccountViewModel model = new AccountViewModel();
            using (CmsContext ctx = new CmsContext())
            {
                model = Mapper.Map<AccountViewModel>(ctx.Account.Where(a => a.Id.ToString() == id));
            }
            
            return View(model);
        }
    }
}
