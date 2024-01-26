using Microsoft.AspNetCore.Mvc;
using MVC_Core_Quan_Ly_Trung_Tam_TA.DataBase;
using MVC_Core_Quan_Ly_Trung_Tam_TA.Models;

namespace MVC_Core_Quan_Ly_Trung_Tam_TA.Controllers
{
    public class KhoaHocController : Controller
    {
        public IActionResult KhoaHoc(int id)
        {
            var items = new KhoaHocHelper().getKhoaHocItems();
            return View(items);
        }
        [HttpGet]
        public async Task<IActionResult> ThemKhoaHoc()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ThemKhoaHoc(IFormCollection frmItem)
        {
            var item = new KhoaHoc();
            if (frmItem != null)
            {
                item.TenKh = frmItem["TenKh"];
                
                item.MaKh = string.IsNullOrEmpty(frmItem["MaKh"]) ? 0 : Convert.ToInt32(frmItem["MaKh"]);
                var result = new KhoaHocHelper().ThemKhoaHOc(item);
                if (result > 0)
                    return RedirectToAction("KhoaHoc");
            }
            return View();
        }
    }
}
