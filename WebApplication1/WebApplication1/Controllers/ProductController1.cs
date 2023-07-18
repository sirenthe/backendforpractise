﻿using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ProductController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Detail(int id ) { 
            return $"product-{id}";
        }
    }
}
