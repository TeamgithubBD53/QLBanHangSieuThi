namespace bai6quanlysieuthi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;
    using System.Data.Entity.Spatial;

    [Table("quayhang")]
    public partial class quayhang
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public quayhang()
        //{
        //    mathangs = new HashSet<mathang>();
        //    phieugiaocas = new HashSet<phieugiaoca>();
        //    phieuxuatkhoes = new HashSet<phieuxuatkho>();
        //}

        [Key]
        [StringLength(20)]
        public string ma { get; set; }

        [Required]
        [StringLength(50)]
        public string ten { get; set; }

        public string vitri { get; set; }

        public quayhang(string ma, string ten, string vt)
        {
            this.ma = ma;
            this.ten = ten;
            this.vitri = vt;
        }

        public quayhang(DataRow row)
        {
            this.ma = row["ma"].ToString();
            this.ten = row["ten"].ToString();
            this.vitri = row["vitri"].ToString();
        }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<mathang> mathangs { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<phieugiaoca> phieugiaocas { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<phieuxuatkho> phieuxuatkhoes { get; set; }
    }
}
