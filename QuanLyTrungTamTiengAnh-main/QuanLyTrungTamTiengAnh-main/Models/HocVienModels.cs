using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Core_Quan_Ly_Trung_Tam_TA.Models
{
    [Table("HocVien")]
    public class HocVienModels
    {
        [Key, Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaHV { get; set; }
        public string TenHV { get; set; }
        public int Sdt { get; set; }
        public int DiaChi_id { get; set; }
        public String Diachi { get; set; }
        public String Gioitinh { get; set; }
        public Nullable<DateTime> Ngaysinh { get; set; }
        [ForeignKey("MaLH")]
        public String MaLH { get; set; }
    }
}
