﻿using ABS.Utility.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ABS.Web.Areas.Inventory.Controllers
{
    public class LoanReturnController : Controller
    {
       
        // GET: /Inventory/Issue/
        [SessionTimeout]
        public ActionResult Index()
        {
            return View();
        }      
    }
}