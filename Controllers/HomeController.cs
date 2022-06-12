using System.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DojoDachi.Models;

namespace DojoDachi.Controllers;

public class HomeController : Controller
{
    [HttpGet("")]
    public IActionResult Index()
    {
        // if(HttpContext.Session.GetString("MyPet") == null) {
        //     HttpContext.Session.SetString("MyPet", "");
        // }

        Dojodachi myPet = new Dojodachi()
        {
            Happiness = 20,
            Fullness = 20,
            Energy = 50,
            Meals = 3
        };
        return View("Index", myPet);
    }

    [HttpPost("/feed")]
    public IActionResult Feed()
    {
        return RedirectToAction("Index");
    }

    [HttpPost("/play")]
    public IActionResult Play()
    {
        return RedirectToAction("Index");
    }
    [HttpPost("/work")]
    public IActionResult Work()
    {
        return RedirectToAction("Index");
    }
    [HttpPost("/sleep")]
    public IActionResult Sleep()
    {
        return RedirectToAction("Index");
    }
}
