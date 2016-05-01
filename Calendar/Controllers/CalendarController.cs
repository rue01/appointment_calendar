﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using DHTMLX.Scheduler;

namespace Calendar.Controllers
{
    public class CalendarController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            var scheduler = new DHXScheduler(this);
            scheduler.Skin = DHXScheduler.Skins.Flat;
            return View(scheduler);
        }
    }
}