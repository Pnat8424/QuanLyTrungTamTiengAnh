using System;
using System.Collections.Generic;

namespace MVC_Core_Quan_Ly_Trung_Tam_TA.DataBase;

public partial class LopHoc
{
    public int MaLh { get; set; }

    public string? TenLh { get; set; }

    public int? MaHv { get; set; }

    public int? MaGv { get; set; }

    public int? MaKh { get; set; }

    public virtual ICollection<HocVien> HocViens { get; set; } = new List<HocVien>();

    public virtual KhoaHoc? MaKhNavigation { get; set; }
}
