using System;
using System.Collections.Generic;

namespace MVC_Core_Quan_Ly_Trung_Tam_TA.DataBase;

public partial class DGiangVien
{
    

    public int MaGv { get; set; }

    public string? TenGv { get; set; }

    public string? Sdt { get; set; }

    public string? Diachi { get; set; }

    public string? Gioitinh { get; set; }

    public DateTime? Ngaysinh { get; set; }

    public string? Trinhdo { get; set; }

    public int? MaLh { get; set; }

    public DateTime? CreatedAt { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? Status { get; set; }
}
