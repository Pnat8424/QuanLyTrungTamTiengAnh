using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVC_Core_Quan_Ly_Trung_Tam_TA.Models
{
    [Table("BaocaoHV")]
    public class BaoCaoHocVienModels
    {
        [Key, Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaBC { get; set; }
        public string TinhtrangHP { get; set; }
        public string TenGV { get; set; }
        public int MaGV { get; set; }
        

        [NotMapped]
        public int Created_by { get; set; }
        public Nullable<DateTime> Created_at { get; set; }
        public int Updated_by { get; set; }
        public Nullable<DateTime> Updated_at { get; set; }
        public int Status { get; set; }
        [ForeignKey("MaHV,TenHV")]
        public int MaHV { get; set; }
        
        
    }
}
