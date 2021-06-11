using System;
using System.Diagnostics;
using HomeAccounting.BusinessLogic.Contracts;
using HomeAccounting.BusinessLogic.Contracts.Dto;
using HomeAccounting.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HomeAccounting.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAccounting _accounting;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IAccounting accounting)
        {
            _logger = logger;
            _accounting = accounting;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }

        public ActionResult CreateAccount()
        {
            _accounting.Create(new Account {Title = "Test", CreationTime = DateTime.Now});
            return Json(new {Status = true});
        }

        [HttpGet]
        public ActionResult Get(int id)
        {
            var account = _accounting.GetById(id);
            return Json(account);
        }
    }
}