using Microsoft.AspNetCore.Mvc;
using MVC_Core_Quan_Ly_Trung_Tam_TA.DataBase;
using MVC_Core_Quan_Ly_Trung_Tam_TA.Models;

namespace MVC_Core_Quan_Ly_Trung_Tam_TA.Controllers
{
    public class BaoCaoHocVienController : Controller
    {
        public IActionResult BaoCaoHocVien(int id)
        {
            var items = new BaoCaoHocVienHelper().getBaoCaoHocVienItems();
            return View(items);
        }
        public IActionResult ThemBaoCao(int id)
        {
            var items = new BaoCaoHocVienHelper().getBaoCaoHocVienItems();
            return View(items);
        }

        [HttpGet]
        public async Task<IActionResult> ThemBaoCao()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ThemBaoCao(IFormCollection frmItem)
        {
            var item = new BaoCaoHv();
            if (frmItem != null)
            {
                item.TenHv = frmItem["TenHv"];
                item.TinhtrangHp = frmItem["TintranhHp"];
               
                var result = new BaoCaoHocVienHelper().ThemBaoCao(item);
                if (result > 0)
                    return RedirectToAction("BaoCaoHocVien");
            }
            return View();
        }
    }
}

