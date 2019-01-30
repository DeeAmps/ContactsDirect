using ContactsDirect.Data.DB;
using ContactsDirect.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using ContactsDirect.Web.ViewModels;

namespace ContactsDirect.Web.Controllers
{
    public class OrderController : Controller
    {
        private contactsdirectEntities service;
        public OrderController()
        {
            service = new contactsdirectEntities();
        }
        // GET: Order
        public ActionResult Index()
        {
            var ordervm = new OrderViewModel()
            {
                lenstype = service.lenstypes.ToList(),
                prescriptiontype = service.prescriptiontypes.ToList(),
                subscriptionlength = service.subscriptionlengths.ToList(),
                paymentmethod = service.paymentmethods.ToList(),
                optionalproduct = service.optionalproducts.ToList(),
            };
            return View(ordervm);
            //return View();
        }
    }
}