using Microsoft.AspNetCore.Mvc;
using MVC_Core_Quan_Ly_Trung_Tam_TA.DataBase;

namespace MVC_Core_Quan_Ly_Trung_Tam_TA.Models
{
    public class HocVienHelper
    {
        public List<HocVien> getHocVienItems()
        {
            var items = new List<HocVien>();
            using (var db = new QLContext())
            {
                items = db.HocViens.ToList();
                return items;

            }
        }
        public int GhiDanh(HocVien item)
        {
            if (item == null) return 0;
            using (var db = new QLContext())
            {
                db.HocViens.Add(item);
                return db.SaveChanges();
            }
        }
        public int Update(HocVien item)
        {
            if (item == null || item.MaHv == 0) return 0;
            using (var db = new QLContext())
            {
                var dataItem = db.HocViens.Where(s => s.MaHv == item.MaHv).FirstOrDefault();
                if (dataItem == null) return 0;
                dataItem.MaHv = item.MaHv;
                dataItem.TenHv = item.TenHv;
                dataItem.Diachi = item.Diachi;
                dataItem.Gioitinh = item.Gioitinh;
                dataItem.Ngaysinh = item.Ngaysinh;
               

                db.HocViens.Update(item);
                return db.SaveChanges();
            }
        }
    }
}
