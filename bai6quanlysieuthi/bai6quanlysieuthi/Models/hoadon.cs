namespace bai6quanlysieuthi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Data;
    [Table("hoadon")]
    public partial class hoadon
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public hoadon()
        //{
        //    chitiethoadons = new HashSet<chitiethoadon>();
        //    khachmuahangs = new HashSet<khachmuahang>();
        //}

        [Key]
        [StringLength(20)]
        public string ma { get; set; }

        public DateTime? ngaylap { get; set; }

        public float tonggiatri { get; set; }

        public float thanhtien { get; set; }

        [StringLength(20)]
        public string manhanvien { get; set; }

        public string makhachhang { get; set; }

        public hoadon(string ma,string manhanvien, float tonggiatri,float thanhtien, DateTime ngaylap,string makh)
        { 
            this.ma = ma;
            this.manhanvien = manhanvien;
            this.ngaylap = ngaylap;
            this.tonggiatri = tonggiatri;
            this.thanhtien = thanhtien;
            this.makhachhang = makh;
            
        }

        public hoadon(DataRow row)
        {
            this.ma = row["ma"].ToString();
            this.manhanvien = row["manhanvien"].ToString();
            this.ngaylap = (DateTime)row["ngaylap"];
            try
            {
                this.tonggiatri = (float)Convert.ToDouble(row["tonggiatri"].ToString());
                this.thanhtien = (float)Convert.ToDouble(row["thanhtien"].ToString());
            }
            catch { }
            this.makhachhang = row["makhachhang"].ToString();
        }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<chitiethoadon> chitiethoadons { get; set; }

        //public virtual mathang mathang { get; set; }

        //public virtual nhanvien nhanvien { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<khachmuahang> khachmuahangs { get; set; }

    }
}
