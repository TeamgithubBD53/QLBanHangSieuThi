namespace bai6quanlysieuthi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;
    using System.Data.Entity.Spatial;

    [Table("chitiethoadon")]
    public partial class chitiethoadon
    {
        [Key]
        public int stt { get; set; }

        [StringLength(20)]
        public string mahoadon { get; set; }

        [StringLength(20)]
        public string mamathang { get; set; }

        public int soluong { get; set; }

        public float dongia { get; set; }

        public chitiethoadon(int stt, string mahd,string mamh,int sl,float dongia)
        {
            this.stt = stt;
            this.mahoadon = mahd;
            this.mamathang = mamh;
            this.soluong = sl;
            this.dongia = dongia;
        }

        public chitiethoadon(DataRow row)
        {
            this.stt = (int)Convert.ToInt32(row["stt"].ToString());
            this.mahoadon = row["mahoadon"].ToString();
            this.mamathang = row["mamathang"].ToString();
            this.soluong = (int)Convert.ToInt32(row["soluong"].ToString());
            try {
                this.dongia = (float)Convert.ToDouble(row["dongia"].ToString());
            }
            catch { }
        }
    }
}
