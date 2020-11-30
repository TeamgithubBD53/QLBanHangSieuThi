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
    class CtHoaDonController
    {
        private static CtHoaDonController instance;
        public static CtHoaDonController Instance
        {
            get
            {
                if (instance == null)
                    instance = new CtHoaDonController();
                return CtHoaDonController.instance;
            }
            private set { CtHoaDonController.instance = value; }
        }

        private CtHoaDonController() { }

        public List<chitiethoadon> XemCtHoaDon()
        {
            List<chitiethoadon> list = new List<chitiethoadon>();
            string query = "select stt,mahoadon,mamathang , soluong, dongia from chitiethoadon";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                chitiethoadon hd = new chitiethoadon(item);
                list.Add(hd);
            }
            return list;
        }
        // thêm chi tiết hóa đơn
        public bool InsertCTHD(string mahd, string mamh, int sl)
        {
            //string query = string.Format("insert chitiethoadon(mahoadon,mamathang,soluong) values(N'{0}',N'{1}',N'{2}')", mahd, mamh, sl);
            string query = string.Format("exec proc_giatien N'{0}',N'{1}',{2}", mahd, mamh, sl);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        // sửa chi tiết hóa đơn
        public bool UpdateCTHD(int stt, string mahd, string mamh, int sl)
        {
            //string query = string.Format("update chitiethoadon set mahoadon=N'{0}',mamathang=N'{1}',soluong={2} where stt={3}", mahd, mamh, sl, stt);
            string query = string.Format("exec proc_updateCtHd N'{0}',N'{1}',{2},{3}", mahd, mamh, sl, stt);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        // xóa chi tiết hóa đơn
        public bool DeleteCTHD(int stt)
        {
            string query = string.Format("delete chitiethoadon where stt={0}", stt);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        // tìm kiếm chi tiết hóa đon
        public List<chitiethoadon> SearchCtHd(string mahoadon)
        {
            List<chitiethoadon> list = new List<chitiethoadon>();
            string query = string.Format("select * from chitiethoadon ct inner join hoadon hd on ct.mahoadon=hd.ma where hd.ma like N'%{0}%' ", mahoadon);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow i in data.Rows)
            {
                chitiethoadon ct = new chitiethoadon(i);
                list.Add(ct);
            }
            return list;
        }

        public List<chitiethoadon> SearchCtHd1(string mamathang)
        {
            List<chitiethoadon> list = new List<chitiethoadon>();
            string query = string.Format("select * from chitiethoadon ct inner join mathang mh on ct.mamathang=mh.ma where mh.ma like N'%{0}%' ", mamathang);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow i in data.Rows)
            {
                chitiethoadon ct = new chitiethoadon(i);
                list.Add(ct);
            }
            return list;
        }
    }
}
