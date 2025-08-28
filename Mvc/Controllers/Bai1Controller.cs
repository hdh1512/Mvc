using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mvc.Models;

namespace Mvc.Controllers;

public class Bai1Controller : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(Bai1 b1)
    {
        ViewBag.Person = $"Học sinh có tên {b1.Name} có tuổi là {b1.Age}";
        return View();
    }
 }
