namespace bai6quanlysieuthi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;
    using System.Data.Entity.Spatial;

    [Table("phieukiemke")]
    public partial class phieukiemke
    {
        [Key]
        [StringLength(20)]
        public string ma { get; set; }

        public DateTime? ngaylap { get; set; }

        [StringLength(20)]
        public string mamathang { get; set; }

        public int soluong { get; set; }

        [StringLength(20)]
        public string manhanvien { get; set; }

        [StringLength(20)]
        public string makhohang { get; set; }
        
        public phieukiemke(string ma,DateTime ngaylap,string mamathang,int soluong, string makho,string manv)
        {
            this.ma = ma;
            this.ngaylap = ngaylap;
            this.mamathang = mamathang;
            this.soluong = soluong;
            this.makhohang = makho;
            this.manhanvien = manv;
        }

        public phieukiemke(DataRow row)
        {
            this.ma = row["ma"].ToString();
            this.ngaylap = (DateTime)row["ngaylap"];
            this.mamathang = row["mamathang"].ToString();
            this.soluong = (int)Convert.ToInt32(row["soluong"].ToString());
            this.makhohang = row["makhohang"].ToString();
            this.manhanvien = row["manhanvien"].ToString();
        }
        //public virtual khohang khohang { get; set; }

        //public virtual mathang mathang { get; set; }

        //public virtual nhanvien nhanvien { get; set; }
    }
}
