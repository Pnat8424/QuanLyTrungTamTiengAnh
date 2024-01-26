using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVC_Core_Quan_Ly_Trung_Tam_TA.Models
{
    [Table("GiangVien")]
    public class GiangVienModels
    {
        [Key, Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaGV { get; set; }
        public string TenGV { get; set; }
        public int Sdt { get; set; }
        public int DiaChi_id { get; set; }
        public String Diachi { get; set; }
        public String Gioitinh {  get; set; }
        public Nullable<DateTime> Ngaysinh { get; set; }
        public String Trinhdo { get; set; }
        
        [NotMapped]
        public int Created_by { get; set; }
        public Nullable<DateTime> Created_at { get; set; }
        public int Updated_by { get;set; } 
        public Nullable<DateTime> Updated_at { get;set; }
        public int Status { get; set; }
        [ForeignKey("MaLH")]
        public String MaLH {  get; set; }
        public GiangVienModels()
        {
            this.MaGV = 0;
            this.TenGV = string.Empty;
            this.Ngaysinh = new DateTime(1900, 01, 01);
            this.DiaChi_id = 0;
            this.Diachi = string.Empty;
        }

        public GiangVienModels(int id)
        {
            this.MaGV = 0;
            this.TenGV = string.Empty;
            this.Ngaysinh = new DateTime(1900, 01, 01);
            this.DiaChi_id = 0;
            this.Diachi = string.Empty;
        }
    }
}
