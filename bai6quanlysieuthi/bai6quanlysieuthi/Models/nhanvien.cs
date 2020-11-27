namespace bai6quanlysieuthi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;
    using System.Data.Entity.Spatial;

    [Table("nhanvien")]
    public partial class nhanvien
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public nhanvien()
        //{
        //    hoadons = new HashSet<hoadon>();
        //    phieugiaocas = new HashSet<phieugiaoca>();
        //    phieukiemkes = new HashSet<phieukiemke>();
        //    phieunhapkhoes = new HashSet<phieunhapkho>();
        //    phieuxuatkhoes = new HashSet<phieuxuatkho>();
        //}

        [Key]
        [StringLength(20)]
        public string ma { get; set; }

        [Required]
        [StringLength(50)]
        public string ten { get; set; }

        public DateTime? ngaysinh { get; set; }

        [StringLength(200)]
        public string diachi { get; set; }

        [StringLength(15)]
        public string sodienthoai { get; set; }

        [StringLength(20)]
        public string machucvu { get; set; }

        public string taikhoan { get; set; }

        public string matkhau { get; set; }

        public nhanvien(string ma, string ten, DateTime ngaysinh, string diachi, string sodt,string macv,string tk,string mk)
        {
            this.ma = ma;
            this.ten = ten;
            this.ngaysinh = ngaysinh;
            this.diachi = diachi;
            this.sodienthoai = sodt;
            this.machucvu = macv;
            this.taikhoan = tk;
            this.matkhau = mk;
        }

        public nhanvien(DataRow row)
        {
            this.ma = row["ma"].ToString();
            this.ten = row["ten"].ToString();
            this.ngaysinh = (DateTime)row["ngaysinh"];
            this.diachi = row["diachi"].ToString();
            this.sodienthoai = row["sodienthoai"].ToString();
            this.machucvu = row["machucvu"].ToString();
            this.taikhoan = row["taikhoan"].ToString();
            this.matkhau = row["matkhau"].ToString();

        }
        //public virtual chucvu chucvu { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<hoadon> hoadons { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<phieugiaoca> phieugiaocas { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<phieukiemke> phieukiemkes { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<phieunhapkho> phieunhapkhoes { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<phieuxuatkho> phieuxuatkhoes { get; set; }
    }
}
