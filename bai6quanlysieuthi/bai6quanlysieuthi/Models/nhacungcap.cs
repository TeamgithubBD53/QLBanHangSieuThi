namespace bai6quanlysieuthi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;
    using System.Data.Entity.Spatial;

    [Table("nhacungcap")]
    public partial class nhacungcap
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public nhacungcap()
        //{
        //    phieunhapkhoes = new HashSet<phieunhapkho>();
        //}

        [Key]
        [StringLength(20)]
        public string ma { get; set; }

        [Required]
        [StringLength(100)]
        public string ten { get; set; }

        [StringLength(200)]
        public string diachi { get; set; }

        [StringLength(15)]
        public string sodienthoai { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        public nhacungcap(string ma, string ten, string diachi, string sodienthoai, string email)
        {
            this.ma = ma;
            this.ten = ten;
            this.diachi = diachi;
            this.sodienthoai = sodienthoai;
            this.email = email;
        }

        public nhacungcap(DataRow row)
        {
            this.ma = row["ma"].ToString();
            this.ten = row["ten"].ToString();
            this.diachi = row["diachi"].ToString();
            this.sodienthoai = row["sodienthoai"].ToString();
            this.email = row["email"].ToString();
        }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<phieunhapkho> phieunhapkhoes { get; set; }
    }
}
