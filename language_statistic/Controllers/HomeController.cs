using System;
using System.Linq;
using System.Web.Mvc;
using Newtonsoft.Json;
using language_statistic.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System.Web;
using System.Collections.Generic;


namespace language_statistic.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View(MvcApplication.db_languages.Languages.ToList());
        }

        [Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [Authorize]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult GetLanguageResources(string langISO639_3, string resourceType, string languageFilter)
        {
            try
            {
                string[] websitesLanguagesToReturn = languageFilter.Split(',');
                switch (resourceType)
                {
                    case "Courses": {
                        var _listOfResources = (from CourseWebsite r in MvcApplication.db_resources.CourseWebsites
                                                where r.ISO639_3 == langISO639_3 && websitesLanguagesToReturn.Any(l => r.Website_ISO639_3.Contains(l))
                                                select new { r.ID, r.EnglishName, r.Website, WebsiteLanguages = r.Website_ISO639_3, Description = r.ResourceDescription, r.ShortDescription, Fees = r.LowestFee, r.IsFree, Rating = (r.Reviews.Count == 0 ? 0 : (double)r.Reviews.Sum(s => s.Rating) / r.Reviews.Count) });
                        return Json(new { status = "success", listOfResources = JsonConvert.SerializeObject(_listOfResources, Formatting.Indented) }, JsonRequestBehavior.AllowGet);
                    }
                    case "Dictionaries": {
                       var _listOfResources = (from Dictionary r in MvcApplication.db_resources.Dictionaries
                                                where r.TO_ISO639_3 == langISO639_3 && websitesLanguagesToReturn.Any(l => r.FROM_ISO639_3.Contains(l))
                                               select new { r.ID, r.EnglishName, r.Website, FromLanguages = r.FROM_ISO639_3, ToLanguages = r.TO_ISO639_3, Description = r.ResourceDescription, r.ShortDescription, Fees = r.LowestFee, r.IsFree, Rating = (r.Reviews.Count == 0 ? 0 : (double)r.Reviews.Sum(s => s.Rating) / r.Reviews.Count) }).ToList();
                       return Json(new { status = "success", listOfResources = JsonConvert.SerializeObject(_listOfResources, Formatting.Indented) }, JsonRequestBehavior.AllowGet);
                    } 
                    case "Forums": {
                       var _listOfResources = (from Forum r in MvcApplication.db_resources.Forums
                                                where r.ISO639_3 == langISO639_3 && websitesLanguagesToReturn.Any(l => r.Forum_ISO639_3.Contains(l))
                                               select new { r.ID, r.EnglishName, r.Website, ForumLanguages = r.Forum_ISO639_3, Description = r.ResourceDescription, r.ShortDescription, Fees = r.LowestFee, r.IsFree, Rating = (r.Reviews.Count == 0 ? 0 : (double)r.Reviews.Sum(s => s.Rating) / r.Reviews.Count) }).ToList();
                       return Json(new { status = "success", listOfResources = JsonConvert.SerializeObject(_listOfResources, Formatting.Indented) }, JsonRequestBehavior.AllowGet);
                    } 
                    default: {
                        return Json(new { status = "fail" });
                    } 
                }
            }
            catch
            {
                return Json(new { status = "fail" });
            }      
        }

        [HttpGet]
        public ActionResult GetReviews(string resourceGuid, string resourceType)
        {
            try
            {
                var userManager = HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();

                switch (resourceType)
                {
                    case "Courses": {
                        var _listOfReviews = (from Review r in MvcApplication.db_resources.CourseWebsites.First(f => f.ID.ToString() == resourceGuid).Reviews
                                              select new { r.ID, r.Comment, r.Rating, UserName = userManager.Users.FirstOrDefault(u => u.Id == r.UserID.ToString()).UserName }).ToList();
                        return Json(new { status = "success", listOfReviews = JsonConvert.SerializeObject(_listOfReviews, Formatting.Indented) }, JsonRequestBehavior.AllowGet);
                    } 
                    case "Dictionaries": {
                        var _listOfReviews = (from Review r in MvcApplication.db_resources.Dictionaries.First(f => f.ID.ToString() == resourceGuid).Reviews
                                              select new { r.ID, r.Comment, r.Rating, UserName = userManager.Users.FirstOrDefault(u => u.Id == r.UserID.ToString()).UserName }).ToList();
                        return Json(new { status = "success", listOfReviews = JsonConvert.SerializeObject(_listOfReviews, Formatting.Indented) }, JsonRequestBehavior.AllowGet);
                    } 
                    case "Forums": {
                        var _listOfReviews = (from Review r in MvcApplication.db_resources.Forums.First(f => f.ID.ToString() == resourceGuid).Reviews
                                              select new { r.ID, r.Comment, r.Rating, UserName = userManager.Users.FirstOrDefault(u => u.Id == r.UserID.ToString()).UserName }).ToList();
                        return Json(new { status = "success", listOfReviews = JsonConvert.SerializeObject(_listOfReviews, Formatting.Indented) }, JsonRequestBehavior.AllowGet);
                    }
                    default: {
                        return Json(new { status = "fail" });
                    }
                }
            }
            catch
            {
                return Json(new { status = "fail" });
            }
        }
        
        [HttpPost]
        public ActionResult SubmitReview (Guid resourceGuid, int rating, string comment)
        {
            try
            {
                MvcApplication.db_resources.Reviews.Add(new Review() { Comment = comment, ID = Guid.NewGuid(), Rating = rating, UserID = Guid.Parse(User.Identity.GetUserId()), ResourceID = resourceGuid });
                MvcApplication.db_resources.SaveChanges();

                return Json(new { status = "success" });
            }
            catch
            {
                return Json(new { status = "fail" });
            }
        }
    }
}