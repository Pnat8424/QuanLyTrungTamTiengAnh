using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_Core_Quan_Ly_Trung_Tam_TA.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_Core_Quan_Ly_Trung_Tam_TA.DataBase;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;


namespace MVC_Core_Quan_Ly_Trung_Tam_TA.Controllers
{
    
    public class GiangVienController : Controller
    {
        
    
       
        public IActionResult GiangVien(int id)
        {
           var items = new GiangVienHelper().getGiangVienItems() ;
            return View(items);
        }

        [HttpGet]
        public async Task<IActionResult> ThemGiangVien()
        {
            return View ();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ThemGiangVien(IFormCollection frmItem)
        {
            var item = new DGiangVien();
            if (frmItem != null)
            {
                item.TenGv = frmItem["TenGv"];
                item.Sdt = frmItem["Sdt"];
                item.Trinhdo = frmItem["Trinhdo"];
                item.MaLh = string.IsNullOrEmpty(frmItem["MaLh"]) ? 0 : Convert.ToInt32(frmItem["MaLh"]);
                var result = new GiangVienHelper().ThemGiangVien(item);
                if (result > 0)
                    return RedirectToAction("GiangVien");
            }
            return View();
        }

    }
}
