using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVC_Core_Quan_Ly_Trung_Tam_TA.Models
{
    [Table("KhoaHoc")]
    public class KhoaHocModels
    {
        [Key, Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaKh { get; set; }
        public string TenKh { get; set; }
        public int HocPhi { get; set; }
        public DateOnly NgayBd { get; set; }
        public DateOnly NgayKt { get; set; }

        [NotMapped]
        public int Created_by { get; set; }
        public Nullable<DateTime> Created_at { get; set; }
        public int Updated_by { get; set; }
        public Nullable<DateTime> Updated_at { get; set; }
        public int Status { get; set; }
        [ForeignKey("MaGV")]
        public String MaGV { get; set; }
    }
}
