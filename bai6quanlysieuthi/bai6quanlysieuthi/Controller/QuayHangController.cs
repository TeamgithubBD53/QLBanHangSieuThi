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
    class QuayHangController
    {
        private static QuayHangController instance;
        public static QuayHangController Instance
        {
            get
            {
                if (instance == null)
                    instance = new QuayHangController();
                return QuayHangController.instance;
            }
            private set { QuayHangController.instance = value; }
        }
        private QuayHangController() { }
        // xem quầy hàng
        public List<quayhang> XemQuayHang()
        {
            List<quayhang> list = new List<quayhang>();
            string query = "select ma,ten,vitri from quayhang";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                quayhang qh = new quayhang(item);
                list.Add(qh);
            }
            return list;
        }
        // thêm quầy hàng
        public bool InsertQuayHang(string ma, string ten, string vitri)
        {
            string query = string.Format("insert quayhang(ma,ten,vitri) values(N'{0}',N'{1}',N'{2}')", ma, ten, vitri);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        // sửa quầy hàng
        public bool UpdateQuayHang(string ma, string ten, string vitri)
        {
            string query = string.Format("update quayhang  set ten=N'{0}',vitri=N'{1}' where ma=N'2'", ten, vitri, ma);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        // xóa quầy hàng
        public bool DeleteQuayHang(string ma)
        {
            string query = string.Format("delete quayhang where ma=N'{0}'", ma);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        // tìm kiếm quầy hàng
        public List<quayhang> SearchQuayHang(string ma, string ten)
        {
            List<quayhang> list = new List<quayhang>();
            string query = string.Format("select * from quayhang a where a.ma like N'%{0}%' and a.ten like N'%{1}%'", ma, ten);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow i in data.Rows)
            {
                quayhang mh = new quayhang(i);
                list.Add(mh);
            }
            return list;

        }
    }
}
