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
    class KhoHangController
    {
        private static KhoHangController instance;
        public static KhoHangController Instance
        {
            get
            {
                if (instance == null)
                    instance = new KhoHangController();
                return KhoHangController.instance;
            }
            private set { KhoHangController.instance = value; }
        }
        public KhoHangController() { }
        //xem kho hàng
        public List<khohang> XemKhoHang()
        {
            List<khohang> list = new List<khohang>();
            string query = "select ma, ten, diachi from khohang";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                khohang kh = new khohang(item);
                list.Add(kh);
            }
            return list;
        }
        // thêm kho hàng
        public bool InsertKhoHang(string ma, string ten, string diachi)
        {
            string query = string.Format("insert khohang(ma,ten,diachi) values(N'{0}',N'{1}',N'{2}')", ma, ten, diachi);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        // sửa kho hàng
        public bool UpdateKhoHang(string ma, string ten, string diachi)
        {
            string query = string.Format("update khohang  set ten=N'{0}',diachi=N'{1}' where ma=N'{2}' ", ten, diachi, ma);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        // xóa kho hàng
        public bool DeleteKhoHang(string ma)
        {
            string query = string.Format("delete khohang where ma=N'{0}'", ma);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        // tìm kiếm kho hàng
        public List<khohang> SearchKhoHang(string ma, string ten)
        {
            List<khohang> list = new List<khohang>();
            string query = string.Format("select * from khohang a where a.ma like N'%{0}%' and a.ten like N'%{1}%'", ma, ten);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow i in data.Rows)
            {
                khohang mh = new khohang(i);
                list.Add(mh);
            }
            return list;
        }
    }
}
