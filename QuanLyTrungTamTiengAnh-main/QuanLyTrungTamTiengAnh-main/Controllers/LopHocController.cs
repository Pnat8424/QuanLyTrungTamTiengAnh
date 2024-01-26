using Microsoft.AspNetCore.Mvc;
using MVC_Core_Quan_Ly_Trung_Tam_TA.DataBase;
using MVC_Core_Quan_Ly_Trung_Tam_TA.Models;
using System.Security.Claims;

namespace MVC_Core_Quan_Ly_Trung_Tam_TA.Controllers
{
    public class LopHocController : Controller
    {
        public IActionResult LopHoc(int id)
        {
            var items = new LopHocHelper().getLopHocItems();
            return View(items);
        }
        [HttpGet]
        public async Task<IActionResult> ThemLopHoc()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ThemLopHoc(IFormCollection frmItem)
        {
            var item = new LopHoc();
            if (frmItem != null)
            {
                item.TenLh = frmItem["tenlh"];
                
                var result = new LopHocHelper().ThemLopHoc(item);
                if (result > 0)
                    return RedirectToAction("LopHoc");
            }
            return View(item);

        }

    }
}
