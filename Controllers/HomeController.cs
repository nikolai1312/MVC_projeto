﻿using Microsoft.AspNetCore.Mvc;
using MVC_projeto.Models;
using System.Diagnostics;

namespace MVC_projeto.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            HomeModel model = new HomeModel();
            model.Nome = "Nicolas Evangelista";
            model.Email = "nicolas.evangelista1312@gmail.com";


            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}