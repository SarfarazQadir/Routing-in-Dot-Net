﻿using Microsoft.AspNetCore.Mvc;

namespace Routing_in_Dot_Net.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
