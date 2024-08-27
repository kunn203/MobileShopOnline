using MobileShopOnline.Models;
using System.Linq;
using System.Web.Mvc;

namespace MobileShopOnline.Controllers
{
    public class MenuNavPartialController : Controller
    {
        MobileShopOnlineEntities db = new MobileShopOnlineEntities();
        // GET: MenuNavPartial
        public ActionResult MenuNav()
        {
            ViewBag.CategoryNavList = db.Categories.ToList();
            return PartialView();
        }
    }
}