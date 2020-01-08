using MyShop.Core.Contracts;
using MyShop.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyShop.WebUI.Controllers
{
    public class ReviewController : Controller
    {
        IRepository<Review> reviews;

        public ReviewController(IRepository<Review> reviews)
        {
            this.reviews = reviews;
        }

        // GET: Review
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult GetReviewForProduct(string id)
        {
            List<Review> reviews = this.reviews.Collection().Where(r => r.ProductId == id).ToList();

            return PartialView(reviews);
        }

        public PartialViewResult Create(string productId)
        {
            Review review = new Review();
            review.ProductId = productId;
            review.CustomerName = User.Identity.Name;

            return PartialView(review);
        }

        [HttpPost]
        public PartialViewResult Create(Review review)
        {
            review.Id = Guid.NewGuid().ToString();
            this.reviews.Insert(review);
            this.reviews.Commit();

            return PartialView();
        }
    }
}