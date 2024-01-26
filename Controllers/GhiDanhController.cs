using Microsoft.AspNetCore.Mvc;
using MVC_Core_Quan_Ly_Trung_Tam_TA.DataBase;
using MVC_Core_Quan_Ly_Trung_Tam_TA.Models;

namespace MVC_Core_Quan_Ly_Trung_Tam_TA.Controllers
{
    public class GhiDanhController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> GhiDanh()
        {
            return View();
        }
        /*
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> GhiDanh(IFormCollection frmItem)
        {
            var item = new GhiDanh();
            if (frmItem != null)
            {
                item.TenHv = frmItem["TenHv"];
                item.Sdt = frmItem["Diachi"];
                item.Gioitinh = frmItem["Giotinh"];
                item.Trinhdo = frmItem["Trinhdo"];            
                var result = new GhiDanhHelper().GhiDanh(item);
                if (result > 0)
                    return RedirectToAction("HocVien");
            }
            return View();
        }
        */
    }
}
