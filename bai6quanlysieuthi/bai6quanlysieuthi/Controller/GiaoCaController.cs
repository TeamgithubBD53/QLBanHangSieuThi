using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bai6quanlysieuthi.Bus;
using bai6quanlysieuthi.Models;
using System.Data;

namespace bai6quanlysieuthi.Controller
{
    class GiaoCaController
    {
        public static GiaoCaController instance;
        public static GiaoCaController Instance
        {
            get
            {
                if (instance == null)
                    instance = new GiaoCaController();
                return GiaoCaController.instance;
            }
            private set { GiaoCaController.instance = value; }
        }

        public GiaoCaController() { }
        // xem phiếu giao ca
        public List<phieugiaoca> XemGiaoCa()
        {
            List<phieugiaoca> list = new List<phieugiaoca>();
            string query = "select ma,ngay,ca,maquay,manhanvien from phieugiaoca";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                phieugiaoca hd = new phieugiaoca(item);
                list.Add(hd);
            }
            return list;
        }
        // thêm phiếu giao ca
        public bool InsertGiaoCa(string ma, DateTime ngay, int ca, string maquay, string manhanvien)
        {
            string query = string.Format("insert phieugiaoca(ma,ngay,ca,maquay,manhanvien) values(N'{0}',N'{1}',{2},N'{3}',N'{4}')", ma, ngay, ca, maquay, manhanvien);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        // sửa phiếu giao ca
        public bool UpdateGiaoCa(string ma, DateTime ngay, int ca, string maquay, string manhanvien)
        {
            string query = string.Format("update phieugiaoca set ngay=N'{0}',ca={1},maquay=N'{2}',manhanvien=N'{3}' where ma=N'{4}'", ngay, ca, maquay, manhanvien);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;

        }
        // xoas phieu giao ca
        public bool DeleteGiaoCa(string ma)
        {
            string query = string.Format("delete phieugiaoca where ma=N'{0}'", ma);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        // tim kiem phieu giao ca
        public List<phieugiaoca> SearchGiaoCa(string ma, string maquay, string manhanvien)
        {
            List<phieugiaoca> list = new List<phieugiaoca>();
            string query = string.Format("select * from phieugiaoca where ma like N'%{0}%' and maquay like N'%{1}%' and manhanvien like N'%{2}%'", ma, maquay, manhanvien);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow i in data.Rows)
            {
                phieugiaoca gc = new phieugiaoca(i);
                list.Add(gc);
            }
            return list;
        }
    }
}
