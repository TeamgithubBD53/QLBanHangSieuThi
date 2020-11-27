namespace bai6quanlysieuthi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;
    using System.Data.Entity.Spatial;

    [Table("phieuxuatkho")]
    public partial class phieuxuatkho
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public phieuxuatkho()
        //{
        //    chitietphieuxuats = new HashSet<chitietphieuxuat>();
        //}

        [Key]
        [StringLength(20)]
        public string ma { get; set; }

        public DateTime? ngayxuat { get; set; }

        public float tonggiatri { get; set; }

        [StringLength(20)]
        public string makhohang { get; set; }

        [StringLength(20)]
        public string manhanvien { get; set; }

        [StringLength(20)]
        public string maquay { get; set; }

        public phieuxuatkho(string ma, string makhohang, DateTime ngayxuat, float tonggiatri, string maquay, string manhanvien)
        {
            this.ma = ma;
            this.makhohang = makhohang;
            this.ngayxuat = ngayxuat;
            this.tonggiatri = tonggiatri;
            this.maquay = maquay;
            this.manhanvien = manhanvien;
        }

        public phieuxuatkho(DataRow row)
        {
            this.ma = row["ma"].ToString();
            this.makhohang = row["makhohang"].ToString();
            this.ngayxuat = (DateTime)row["ngayxuat"];
            try
            {
                this.tonggiatri = (float)Convert.ToDouble(row["tonggiatri"].ToString());
            }
            catch
            {

            }
            this.maquay = row["maquay"].ToString();
            this.manhanvien = row["manhanvien"].ToString();
        }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<chitietphieuxuat> chitietphieuxuats { get; set; }

        //public virtual khohang khohang { get; set; }

        //public virtual nhanvien nhanvien { get; set; }

        //public virtual quayhang quayhang { get; set; }
    }
}
