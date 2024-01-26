using Microsoft.AspNetCore.Mvc;
using MVC_Core_Quan_Ly_Trung_Tam_TA.Models;

namespace MVC_Core_Quan_Ly_Trung_Tam_TA.Controllers
{
    public class HocVienController : Controller
    {
        public IActionResult HocVien(int id)
        {
            var items = new HocVienHelper().getHocVienItems();
            return View(items);
        }
    }


}
