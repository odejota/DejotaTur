using DejotaTur.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DejotaTur.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Promoções()
        {
            return View();
        }

        public IActionResult Contato()
        {
            return View();
        }
    }
}