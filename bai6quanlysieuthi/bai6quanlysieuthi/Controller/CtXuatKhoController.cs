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
    class CtXuatKhoController
    {
        private static CtXuatKhoController instance;
        public static CtXuatKhoController Instance
        {
            get
            {
                if (instance == null)
                    instance = new CtXuatKhoController();
                return CtXuatKhoController.instance;
            }
            private set { CtXuatKhoController.instance = value; }
        }
        private CtXuatKhoController() { }
        // xem chi tiết phiếu xuất
        public List<chitietphieuxuat> XemCtXuatKho()
        {
            List<chitietphieuxuat> list = new List<chitietphieuxuat>();
            string query = "select stt,maxuat ,mamathang,soluong,dongia from chitietphieuxuat";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                chitietphieuxuat hd = new chitietphieuxuat(item);
                list.Add(hd);
            }
            return list;
        }

        // thêm chi tiết phiếu xuất
        public bool InsertCtXuat(string maxuat, string mamathang, int sl)
        {
            string query = string.Format("exec proc_chitietxuat N'{0}',N'{1}',{2}", maxuat, mamathang, sl);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }


        // sửa chi tiết phiếu xuất
        public bool UpdateCtXuat(int stt, string maxuat, string mamathang, int sl)
        {
            string query = string.Format("exec proc_dechitietxuat {0},N'{1}',N'{2}',{3}", stt, maxuat, mamathang, sl);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        // xóa chi tiết phiếu xuất
        public bool DeleteCtXuat(int stt)
        {
            string query = string.Format("exec proc_dechitietxuat {0}", stt);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        // tìm kiếm chi tiết phiếu xuất
        public List<chitietphieuxuat> SearchCtXuat(string maxuat, string mamathang)
        {
            List<chitietphieuxuat> list = new List<chitietphieuxuat>();
            string query = string.Format("select * from chitietphieuxuat a where a.maxuat like N'%{0}%' and a.mamathang like N'%{1}%' ", maxuat, mamathang);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow i in data.Rows)
            {
                chitietphieuxuat mh = new chitietphieuxuat(i);
                list.Add(mh);
            }
            return list;
        }
    }
}
