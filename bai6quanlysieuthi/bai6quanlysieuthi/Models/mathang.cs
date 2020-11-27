namespace bai6quanlysieuthi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Data;

    [Table("mathang")]
    public partial class mathang
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public mathang()
        //{
        //    chitiepphieunhaps = new HashSet<chitiepphieunhap>();
        //    chitiethoadons = new HashSet<chitiethoadon>();
        //    chitietphieugiaocas = new HashSet<chitietphieugiaoca>();
        //    chitietphieuxuats = new HashSet<chitietphieuxuat>();
        //    hoadons = new HashSet<hoadon>();
        //    phieukiemkes = new HashSet<phieukiemke>();
        //}

        [Key]
        [StringLength(20)]
        public string ma { get; set; }

        [Required]
        [StringLength(50)]
        public string ten { get; set; }

        [StringLength(50)]
        public string loaimathang { get; set; }

        [StringLength(10)]
        public string donvitinh { get; set; }

        [StringLength(20)]
        public string maquay { get; set; }

        public string manhacc { get; set; }

        public float gia { get; set; }
        public mathang(string ma, string ten, string loaimathang, string donvitinh, string maquay,string nhacc,float gia)
        {
            this.ma = ma;
            this.ten = ten;
            this.loaimathang = loaimathang;
            this.donvitinh = donvitinh;
            this.maquay = maquay;
            this.manhacc = nhacc;
            this.gia = gia;
        }

        public mathang(DataRow rows)
        {
            this.ma = rows["ma"].ToString();
            this.ten = rows["ten"].ToString();
            this.loaimathang = rows["loaimathang"].ToString();
            this.donvitinh = rows["donvitinh"].ToString();
            this.maquay = rows["maquay"].ToString();
            this.manhacc = rows["manhacc"].ToString();
            try
            {
                this.gia = (float)Convert.ToDouble(rows["gia"].ToString());
            }
            catch { }
        }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<chitiepphieunhap> chitiepphieunhaps { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<chitiethoadon> chitiethoadons { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<chitietphieugiaoca> chitietphieugiaocas { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<chitietphieuxuat> chitietphieuxuats { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<hoadon> hoadons { get; set; }

        //public virtual quayhang quayhang { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<phieukiemke> phieukiemkes { get; set; }
    }
}
