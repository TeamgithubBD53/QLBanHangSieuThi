using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bai6quanlysieuthi.Models;
using bai6quanlysieuthi.Bus;
using System.Data;

namespace bai6quanlysieuthi.Controller
{
    class XuatKhoController
    {

        private static XuatKhoController instance;
        public static XuatKhoController Instance
        {
            get
            {
                if (instance == null)
                    instance = new XuatKhoController();
                return XuatKhoController.instance;
            }
            private set { XuatKhoController.instance = value; }
        }

        private XuatKhoController() { }
        // xem xuất kho
        public List<phieuxuatkho> XemXuatKho()
        {
            List<phieuxuatkho> list = new List<phieuxuatkho>();
            string query = "select ma,makhohang,ngayxuat,tonggiatri,maquay,manhanvien from phieuxuatkho ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                phieuxuatkho xk = new phieuxuatkho(item);
                list.Add(xk);
            }
            return list;
        }
        //  thêm xuất kho
        public bool InsertXuatKho(string ma, string makh, string manv, string maquay, DateTime ngayxuat)
        {
            string query = string.Format("insert phieuxuatkho(ma,makhohang,manhanvien,maquay,ngayxuat) values(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}')", ma, makh, manv, maquay, ngayxuat);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        // sửa xuất kho
        public bool UpdateXuatKho(string ma, string makh, string manv, string maquay, DateTime ngayxuat)
        {
            string query = string.Format("update phieuxuatkho set makhohang=N'{0}',manhanvien=N'{1}',maquay=N'{2}',ngayxuat=N'{3}' where ma=N'{4}'", makh, manv, maquay, ngayxuat, ma);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        // xóa xuất kho
        public bool DeleteXuatKho(string ma)
        {
            string query = string.Format("delete phieuxuatkho where ma=N'{0}'", ma);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        // tìm kiếm xuất kho
        public List<phieuxuatkho> SearchXuatKho(string ma, string makh, string manv, string maquay)
        {
            List<phieuxuatkho> list = new List<phieuxuatkho>();
            string query = string.Format("select * from phieuxuatkho a where a.ma like N'%{0}%' and a.makhohang like N'%{1}%' and a.manhanvien like N'%{2}%' and a.maquay like N'%{3}%'", ma, makh, manv, maquay);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow i in data.Rows)
            {
                phieuxuatkho xk = new phieuxuatkho(i);
                list.Add(xk);
            }
            return list;
        }
    }
}
