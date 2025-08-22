using Microsoft.AspNetCore.Mvc;

namespace Mvc.Controllers;

public class PersonController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
[HttpPost]
    public IActionResult Index(Person ps)
    {
        ViewBag.Person = $"Học sinh có tên {ps.Name} có tuổi là {ps.Age} có số điểm là {ps.Score}";
        return View();
    }
}