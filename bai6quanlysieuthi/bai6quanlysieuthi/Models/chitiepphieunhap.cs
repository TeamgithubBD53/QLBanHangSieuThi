namespace bai6quanlysieuthi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;
    using System.Data.Entity.Spatial;

    [Table("chitiepphieunhap")]
    public partial class chitiepphieunhap
    {
        [Key]
        public int stt { get; set; }

        [StringLength(20)]
        public string manhap { get; set; }

        [StringLength(20)]
        public string mamathang { get; set; }

        public int soluong { get; set; }

        public float dongia { get; set; }

        public chitiepphieunhap(int stt, string manhap,string mamh,int sl,float dg)
        {
            this.stt = stt;
            this.manhap = manhap;
            this.mamathang = mamh;
            this.soluong = sl;
            this.dongia = dg;
        }

        public chitiepphieunhap(DataRow row)
        {
            this.stt = (int)Convert.ToInt32(row["stt"].ToString());
            this.manhap = row["manhap"].ToString();
            this.mamathang = row["mamathang"].ToString();
            this.soluong = (int)Convert.ToInt32(row["soluong"].ToString());
            this.dongia = (float)Convert.ToDouble(row["dongia"].ToString());
        }

    }
}
