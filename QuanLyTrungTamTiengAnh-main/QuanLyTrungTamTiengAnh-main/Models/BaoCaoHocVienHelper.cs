using MVC_Core_Quan_Ly_Trung_Tam_TA.DataBase;

namespace MVC_Core_Quan_Ly_Trung_Tam_TA.Models
{
    public class BaoCaoHocVienHelper
    {
        public List<BaoCaoHv> getBaoCaoHocVienItems()
        {
            var items = new List<BaoCaoHv>();
            using (var db = new QLContext())
            {
                items = db.BaoCaoHvs.ToList();
                return items;

            }
        }
        public int ThemBaoCao(BaoCaoHv item)
        {
            if (item == null) return 0;
            using (var db = new QLContext())
            {
               
                db.BaoCaoHvs.Add(item);
                return db.SaveChanges();
            }
        }
        public int Update(BaoCaoHv item)
        {
            if (item == null || item.MaBc == 0) return 0;
            using (var db = new QLContext())
            {
                var dataItem = db.BaoCaoHvs.Where(s => s.MaBc == item.MaBc).FirstOrDefault();
                if (dataItem == null) return 0;
                dataItem.MaBc = item.MaBc;
                dataItem.MaHv = item.MaHv;
                dataItem.TenHv = item.TenHv;
                dataItem.MaKh = item.MaKh;
                dataItem.TinhtrangHp = item.TinhtrangHp;
                db.BaoCaoHvs.Update(item);
                return db.SaveChanges();
            }
        }


    }
}
