using System.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DojoDachi.Models;

namespace DojoDachi.Controllers;

public class HomeController : Controller
{
    [HttpGet("")]
    public IActionResult Index() {
        Dojodachi myPet =  new Dojodachi() {
            Happiness = 20,
            Fullness = 20,
            Energy = 50,
            Meals = 3
        };

        return View("Index");
    }
}
