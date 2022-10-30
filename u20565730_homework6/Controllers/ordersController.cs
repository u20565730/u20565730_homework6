using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u20565730_homework6.Models;
using System.Data.Entity;
using System.Threading.Tasks;
using PagedList.Mvc;
using PagedList;

namespace u20565730_homework6.Controllers
{
    public class OrderController : Controller
    {
        private BikeStoresEntities db = new BikeStoresEntities();
        // GET: products
        public ActionResult Index(DateTime? date, int? i)
        {
            var orders = db.orders.Where(x => x.order_date == date || date == null).ToList().ToPagedList(i ?? 1, 5);
            return View(orders);
        }
    }
}


