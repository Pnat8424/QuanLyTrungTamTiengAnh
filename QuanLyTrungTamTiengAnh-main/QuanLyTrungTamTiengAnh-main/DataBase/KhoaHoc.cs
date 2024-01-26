using System;
using System.Collections.Generic;

namespace MVC_Core_Quan_Ly_Trung_Tam_TA.DataBase;

public partial class KhoaHoc
{
    public int MaKh { get; set; }

    public DateTime? NgayBd { get; set; }

    public DateTime? NgayKt { get; set; }

    public string? TenKh { get; set; }

    public int? MaGv { get; set; }

    public decimal? HocPhi { get; set; }

    public virtual ICollection<BaoCaoHv> BaoCaoHvs { get; set; } = new List<BaoCaoHv>();

    public virtual ICollection<LopHoc> LopHocs { get; set; } = new List<LopHoc>();
}
