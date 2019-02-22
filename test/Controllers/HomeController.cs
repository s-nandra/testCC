using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test.Models;

namespace test.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var dateNow = DateTime.Now;
            string dateNowYear = dateNow.ToString("yy");

            var exDate = dateNow.AddYears(20);
            var exDateYear = exDate.ToString("yy"); ;

            List<SelectListItem> expMths = new List<SelectListItem>();
         
            for (int i = 0; i < 12; i++)
            {
                var mth = dateNow.ToString("MM");
                expMths.Add(new SelectListItem
                {
                    Text = mth,
                    Value = mth
                });
 
                dateNow = dateNow.AddMonths(1);
            }


            List<SelectListItem> expyrs = new List<SelectListItem>();
            for (int i = Convert.ToInt32(dateNowYear); i < Convert.ToInt32(exDateYear); i++)
            {
                expyrs.Add(new SelectListItem
                {
                    Text = i.ToString(),
                    Value = i.ToString()
                });

            }


            
            ViewBag.ExpiryDateMonth = expMths;
            ViewBag.ExpiryDateYear = expyrs;

            return View();
        }


        [HttpPost]
        public ActionResult Index(PaymentCard paymentCard)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            else
            {
                return View();
            }
        }

        //[HttpPost]
        //public ActionResult Create(PaymentCard paymentCard)
        //{
        //    if (!ModelState.IsValid)
        //        return View();

        //    //Save changes to data store with any required logic.
        //    //db.PaymentCard.Add(paymentCard);
        //    //db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

    }
}