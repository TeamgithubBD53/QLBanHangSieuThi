namespace bai6quanlysieuthi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;
    using System.Data.Entity.Spatial;

    [Table("phieunhapkho")]
    public partial class phieunhapkho
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public phieunhapkho()
        //{
        //    chitiepphieunhaps = new HashSet<chitiepphieunhap>();
        //}

        [Key]
        [StringLength(20)]
        public string ma { get; set; }

        [StringLength(20)]
        public string makhohang { get; set; }

        public DateTime? ngaynhap { get; set; }

        public float tonggiatri { get; set; }

        [StringLength(20)]
        public string manhacungcap { get; set; }

        [StringLength(20)]
        public string manhanvien { get; set; }

        public phieunhapkho(string ma, string makhohang, DateTime ngaynhap, float tonggiatri,string manhacc,string manhanvien)
        {
            this.ma = ma;
            this.makhohang = makhohang;
            this.ngaynhap = ngaynhap;
            this.tonggiatri = tonggiatri;
            this.manhacungcap = manhacc;
            this.manhanvien = manhanvien;
        }

        public phieunhapkho(DataRow row)
        {
            this.ma = row["ma"].ToString();
            this.makhohang = row["makhohang"].ToString();
            this.ngaynhap = (DateTime)row["ngaynhap"];
            this.tonggiatri = (float)Convert.ToDouble(row["tonggiatri"].ToString());
            this.manhacungcap = row["manhacungcap"].ToString();
            this.manhanvien = row["manhanvien"].ToString();
        }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<chitiepphieunhap> chitiepphieunhaps { get; set; }

        //public virtual khohang khohang { get; set; }

        //public virtual nhacungcap nhacungcap { get; set; }

        //public virtual nhanvien nhanvien { get; set; }
    }
}
