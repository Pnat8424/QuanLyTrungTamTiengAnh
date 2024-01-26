using Microsoft.AspNetCore.Mvc;
using MVC_Core_Quan_Ly_Trung_Tam_TA.DataBase;

namespace MVC_Core_Quan_Ly_Trung_Tam_TA.Models
{
    public class KhoaHocHelper
    {
        public List<KhoaHoc> getKhoaHocItems()
        {
            var items = new List<KhoaHoc>();
            using (var db = new QLContext())
            {
                items = db.KhoaHocs.ToList();
                return items;

            }
        }
        public int ThemKhoaHOc(KhoaHoc item)
        {
            if (item == null) return 0;
            using (var db = new QLContext())
            {
                

                db.KhoaHocs.Add(item);
                return db.SaveChanges();
            }
        }
        public int Update(KhoaHoc item)
        {
            if (item == null || item.MaKh == 0) return 0;
            using (var db = new QLContext())
            {
                var dataItem = db.KhoaHocs.Where(s => s.MaKh == item.MaKh).FirstOrDefault();
                if (dataItem == null) return 0;
                dataItem.MaKh = item.MaKh;
                dataItem.TenKh = item.TenKh;
                dataItem.NgayBd = item.NgayBd;
                dataItem.NgayKt = item.NgayKt;
                dataItem.HocPhi = item.HocPhi;
                
                db.KhoaHocs.Update(item);
                return db.SaveChanges();
            }
        }
    }
}

