using System;
using System.Collections.Generic;

namespace MVC_Core_Quan_Ly_Trung_Tam_TA.DataBase;

public partial class BaoCaoHv
{
    public int MaBc { get; set; }

    public int? MaHv { get; set; }

    public string? TenHv { get; set; }

    public string? TinhtrangHp { get; set; }

    public int? MaKh { get; set; }

    public virtual KhoaHoc? MaKhNavigation { get; set; }
}
