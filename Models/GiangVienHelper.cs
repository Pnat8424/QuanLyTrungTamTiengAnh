using System;
using System.Linq;
using System.Collections.Generic;
using MVC_Core_Quan_Ly_Trung_Tam_TA.DataBase;
using MVC_Core_Quan_Ly_Trung_Tam_TA.Models;
using System.Net;
using System.Security.Claims;

namespace MVC_Core_Quan_Ly_Trung_Tam_TA.Models
{
  public class GiangVienHelper
    {
        public List<DGiangVien> getGiangVienItems()
        {
            var items = new List<DGiangVien>();
            using (var db = new QLContext())
            {
                items = db.DGiangViens.ToList();
                return items;

            }
        }
        public List<DGiangVien> getGiangVienItems(int status)
        {
            using (var db = new QLContext())
            {
                if (status == -1)
                    return db.DGiangViens.ToList();
                return db.DGiangViens.Where(s => s.Status == status).ToList();
            }
        }
        public int ThemGiangVien(DGiangVien item)
        {
            if (item == null) return 0;
            using (var db = new QLContext())
            {
                item.CreatedAt = DateTime.Now;
               
                item.UpdatedAt = DateTime.Now;
                
                db.DGiangViens.Add(item);
                return db.SaveChanges();
            }
        }
        public int Update(DGiangVien item)
        {
            if (item == null || item.MaGv == 0) return 0;
            using (var db = new QLContext())
            {
                var dataItem = db.DGiangViens.Where(s => s.MaGv == item.MaGv).FirstOrDefault();
                if (dataItem == null) return 0;
                dataItem.MaGv = item.MaGv;
                dataItem.TenGv = item.TenGv;
                dataItem.Sdt = item.Sdt;
                dataItem.Trinhdo = item.Trinhdo;
                dataItem.MaLh = item.MaLh;
                dataItem.UpdatedAt = DateTime.Now;
                
                db.DGiangViens.Update(item);
                return db.SaveChanges();
            }
        }

    }
}

        

           

           


