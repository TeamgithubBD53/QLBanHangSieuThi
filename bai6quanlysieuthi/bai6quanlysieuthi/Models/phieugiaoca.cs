namespace bai6quanlysieuthi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;
    using System.Data.Entity.Spatial;

    [Table("phieugiaoca")]
    public partial class phieugiaoca
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public phieugiaoca()
        //{
        //    chitietphieugiaocas = new HashSet<chitietphieugiaoca>();
        //}

        [Key]
        [StringLength(20)]
        public string ma { get; set; }

        public DateTime? ngay { get; set; }

        public int ca { get; set; }

        [StringLength(20)]
        public string maquay { get; set; }

        [StringLength(20)]
        public string manhanvien { get; set; }

        public phieugiaoca(string ma, DateTime ngay,int ca, string maquay,string manv)
        {
            this.ma = ma;
            this.ngay = ngay;
            this.ca = ca;
            this.maquay = maquay;
            this.manhanvien = manv;
        }

        public phieugiaoca(DataRow row)
        {
            this.ma = row["ma"].ToString();
            this.ngay = (DateTime)row["ngay"];
            this.ca = (int)Convert.ToInt32(row["ca"].ToString());
            this.maquay = row["maquay"].ToString();
            this.manhanvien = row["manhanvien"].ToString();
        }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<chitietphieugiaoca> chitietphieugiaocas { get; set; }

        //public virtual nhanvien nhanvien { get; set; }

        //public virtual quayhang quayhang { get; set; }
    }
}
