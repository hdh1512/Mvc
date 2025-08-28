using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers;
public class Bai3Controller:Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
public IActionResult Index(string Fullname, float Height, float Weight, int Age)
{
    var result = Weight / (2* (Height / 100));
    ViewBag.BMI = $"Tên là: {Fullname}, Cao: {Height} cm, Nặng: {Weight} kg, Tuổi: {Age}, Chỉ số BMI là: {result:F2}";
    return View();  
}
}
