using System;
using System.Collections.Generic;

namespace MVC_Core_Quan_Ly_Trung_Tam_TA.DataBase;

public partial class HocVien
{
    public int MaHv { get; set; }

    public string? TenHv { get; set; }

    public string? Gioitinh { get; set; }

    public DateTime? Ngaysinh { get; set; }

    public string? Diachi { get; set; }

    public int? MaLh { get; set; }

    public virtual ICollection<GhiDanh> GhiDanhs { get; set; } = new List<GhiDanh>();

    public virtual LopHoc? MaLhNavigation { get; set; }
}
