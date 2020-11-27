namespace bai6quanlysieuthi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Data;
    [Table("khachhang")]
    public partial class khachhang
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public khachhang()
        //{
        //    khachmuahangs = new HashSet<khachmuahang>();
        //}

        [Key]
        [StringLength(20)]
        public string ma { get; set; }

        [Required]
        [StringLength(50)]
        public string ten { get; set; }

        [StringLength(200)]
        public string diachi { get; set; }

        [StringLength(15)]
        public string sodienthoai { get; set; }

        public float uudai { get; set; }

        public khachhang(string ma, string ten, string diachi, string sodienthoai, float uudai)
        {
            this.ma = ma;
            this.ten = ten;
            this.diachi = diachi;
            this.sodienthoai = sodienthoai;
            this.uudai = uudai;
        }

        public khachhang(DataRow row)
        {
            this.ma = row["ma"].ToString();
            this.ten = row["ten"].ToString();
            this.diachi = row["diachi"].ToString();
            this.sodienthoai = row["sodienthoai"].ToString();
            try
            {
                this.uudai = (float)Convert.ToDouble(row["uudai"].ToString());
            }
            catch { }
        }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<khachmuahang> khachmuahangs { get; set; }
    }
}
