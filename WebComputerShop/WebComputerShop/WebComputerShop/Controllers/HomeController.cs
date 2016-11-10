using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebComputerShop.Models;

namespace WebComputerShop.Controllers
{
    public class HomeController : Controller
    {

        private ItemProductContext db = new ItemProductContext();
        private ApplicationDbContext db2 = new ApplicationDbContext();

        public ActionResult Index()
        {
            var products = db.Productss.ToList();
            return View(products);
        }

        public ActionResult addToCart(int id)
        {
            var product = db.Productss.Find(id);
            var userId = User.Identity.GetUserId();
            var user = db2.Users.Find(userId);
            user.Cart.Add(product);
            db2.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Cart  ()
        {
            var UserId = User.Identity.GetUserId();
            var user = db2.Users.Find(UserId);
            var Cart = user.Cart;

            return View(Cart);
        }
    }
}