using System;
using System.Collections.Generic;

namespace MVC_Core_Quan_Ly_Trung_Tam_TA.DataBase;

public partial class GhiDanh
{
    public int Id { get; set; }

    public int? MaHv { get; set; }

    public string? TenHv { get; set; }

    public string? Sdt { get; set; }

    public DateTime? Ngaysinh { get; set; }

    public string? Trinhdo { get; set; }

    public string? Gioitinh { get; set; }

    public virtual HocVien? MaHvNavigation { get; set; }
}
