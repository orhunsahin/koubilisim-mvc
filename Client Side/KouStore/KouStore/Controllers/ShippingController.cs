﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KouStore.Controllers
{
    public class ShippingController : Controller
    {
        // GET: Shipping
        public ActionResult Index()
        {
            return View("Shipping");
        }
    }
}