namespace bai6quanlysieuthi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;
<<<<<<< HEAD
    using System.Data.Entity.Spatial;
=======

>>>>>>> 8bedb5f4728463a9fa975e513081259749ff4271

    [Table("chitietphieugiaoca")]
    public partial class chitietphieugiaoca
    {
        [Key]
        public int stt { get; set; }

        [StringLength(20)]
        public string magiaoca { get; set; }

        [StringLength(20)]
        public string mamathang { get; set; }

        public int soluong { get; set; }

        public chitietphieugiaoca(int stt,string magc,string mamh,int sl)
        {
            this.stt = stt;
            this.magiaoca = magc;
            this.mamathang = mamh;
            this.soluong = sl;
        }

        public chitietphieugiaoca(DataRow row)
        {
            this.stt = (int)Convert.ToInt32(row["stt"].ToString());
            this.magiaoca = row["magiaoca"].ToString();
            this.mamathang = row["mamathang"].ToString();
            this.soluong = (int)Convert.ToInt32(row["soluong"].ToString());
<<<<<<< HEAD
=======

>>>>>>> 8bedb5f4728463a9fa975e513081259749ff4271
        }

    }
}
