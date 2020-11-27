namespace bai6quanlysieuthi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;
    using System.Data.Entity.Spatial;

    [Table("chitietphieuxuat")]
    public partial class chitietphieuxuat
    {
        [Key]
        public int stt { get; set; }

        [StringLength(20)]
        public string maxuat { get; set; }

        [StringLength(20)]
        public string mamathang { get; set; }

        public int soluong { get; set; }

        public float dongia { get; set; }

        public chitietphieuxuat(int stt, string maxuat, string mamh,int sl,float dongia)
        {
            this.stt = stt;
            this.maxuat = maxuat;
            this.mamathang = mamh;
            this.soluong = sl;
            this.dongia = dongia;
        } 

        public chitietphieuxuat(DataRow row)
        {
            this.stt = (int)Convert.ToInt32(row["stt"].ToString());
            this.maxuat = row["maxuat"].ToString();
            this.mamathang = row["mamathang"].ToString();
            try
            {
                this.soluong = (int)Convert.ToInt32(row["soluong"].ToString());
                this.dongia = (float)Convert.ToDouble(row["dongia"].ToString());
            }
            catch { }
        }

    }
}
