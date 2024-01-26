using System;
using System.Linq;
using System.Collections.Generic;
using MVC_Core_Quan_Ly_Trung_Tam_TA.DataBase;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
namespace MVC_Core_Quan_Ly_Trung_Tam_TA.Models
{
    public class LopHocHelper
    {
        public List<LopHoc> getLopHocItems()
        {
            var items = new List<LopHoc>();
            using (var db = new QLContext())
            {
                items = db.LopHocs.ToList();
                return items;

            }
        }
        public List<LopHoc> getLopHocItems(int status)
        {
            using (var db = new QLContext())
            {
                if (status == -1)
                    return db.LopHocs.ToList();
                return db.LopHocs.Where(s => s.MaLh == status).ToList();
            }
        }
        public int ThemLopHoc(LopHoc item)
        {
            if (item == null) return 0;
            using (var db = new QLContext())
            {
                
                
                db.LopHocs.Add(item);
                return db.SaveChanges();
            }
        }

       
    }
    }


