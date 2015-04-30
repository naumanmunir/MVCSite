using NaumanSite.DAL;
using NaumanSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NaumanSite.Controllers
{
    public class PortfolioController : Controller
    {
        // GET: Portfolio
        public ActionResult Index(string filter = null, int page = 1, int pageSize = 20)
        {
            GalleryContext db = new GalleryContext();
            
            var records = new PagedList<Photo>();
            ViewBag.filter = filter;

            records.Content = db.Photos
                        .Where(x => filter == null || (x.Description.Contains(filter)))
                        .OrderByDescending(x => x.PhotoId)
                        .Skip((page - 1) * pageSize)
                        .Take(pageSize)
                        .ToList();

            // Count
            records.TotalRecords = db.Photos
                            .Where(x => filter == null || (x.Description.Contains(filter))).Count();

            records.CurrentPage = page;
            records.PageSize = pageSize;

            return View(records);
        }

        [HttpGet]
        public ActionResult Create()
        {
            var photo = new Photo();
            return View(photo);
        }
    }
}