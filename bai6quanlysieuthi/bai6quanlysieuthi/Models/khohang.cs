namespace bai6quanlysieuthi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;
    using System.Data.Entity.Spatial;

    [Table("khohang")]
    public partial class khohang
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public khohang()
        //{
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

        [StringLength(200)]
        public string diachi { get; set; }

        public khohang(string ma, string ten, string diachi)
        {
            this.ma = ma;
            this.ten = ten;
            this.diachi = diachi;
        }

        public khohang(DataRow row)
        {
            this.ma = row["ma"].ToString();
            this.ten = row["ten"].ToString();
            this.diachi = row["diachi"].ToString();
        }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<phieukiemke> phieukiemkes { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<phieunhapkho> phieunhapkhoes { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<phieuxuatkho> phieuxuatkhoes { get; set; }
    }
}
