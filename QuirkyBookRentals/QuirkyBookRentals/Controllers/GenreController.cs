using QuirkyBookRentals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuirkyBookRentals.Controllers
{
    public class GenreController : Controller
    {
        private ApplicationDbContext db;

        public GenreController()
        {
            db = new ApplicationDbContext();
        }
        // GET: Genre
        public ActionResult Index()
        {
            return View(db.Gneres.ToList());
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

    }
}