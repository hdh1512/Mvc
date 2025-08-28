using Microsoft.AspNetCore.Mvc;
using Mvc.Models;

namespace Mvc.Controllers
{
    public class Bai2Controller : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            // Lần đầu mở trang thì trả về model rỗng
            return View(new Bai2());
        }

        [HttpPost]
        public IActionResult Index(Bai2 model)
        {
            // Tính toán theo Operation
            switch (model.Operation)
            {
                case "add":
                    model.Result = model.Num1 + model.Num2;
                    break;
                case "subtract":
                    model.Result = model.Num1 - model.Num2;
                    break;
                case "multiply":
                    model.Result = model.Num1 * model.Num2;
                    break;
                case "divide":
                    if (model.Num2 != 0)
                        model.Result = model.Num1 / model.Num2;
                    else
                        model.ErrorMessage = "Không thể chia cho 0!";
                    break;
                default:
                    model.ErrorMessage = "Phép toán không hợp lệ!";
                    break;
            }

            // Trả lại model (có Result/ErrorMessage) về View
            return View(model);
        }
    }
}
