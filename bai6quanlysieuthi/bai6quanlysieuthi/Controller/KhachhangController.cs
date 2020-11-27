using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bai6quanlysieuthi.Models;
using System.Data;
using bai6quanlysieuthi.Bus;
namespace bai6quanlysieuthi.Controller
{
    class KhachhangController
    {
        private static KhachhangController instance;
        public static KhachhangController Instance
        {
            get
            {
                if (instance == null)
                    instance = new KhachhangController();
                return KhachhangController.instance;
            }
            private set
            {
                KhachhangController.instance = value;
            }
        }
        private KhachhangController() { }
        // xem khach hang
        public List<khachhang> XemKhachHang()
        {
            List<khachhang> list = new List<khachhang>();
            string query = "select ma,ten,diachi,sodienthoai,uudai from khachhang";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                khachhang kh = new khachhang(item);
                list.Add(kh);
            }
            return list;
        }
        // them khach hang
        public bool InsertKhachHang(string ma,string ten,string diachi, string sodt, float uudai)
        {
            string query = string.Format("insert khachhang(ma,ten,diachi,sodienthoai,uudai) values(N'{0}',N'{1}',N'{2}',N'{3}',{4})", ma, ten, diachi, sodt, uudai);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        // sửa  khách hàng
        public bool UpdateKhachHang(string ma, string ten, string diachi, string sodt, float uudai)
        {
            string query = string.Format("update khachhang set ten=N'{0}',diachi='{1}',sodienthoai=N'{2}',uudai={3} where ma=N'{4}'", ten, diachi, sodt, uudai, ma);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        //xóa khách hàng
        public bool DeleteKhachHang(string ma)
        {
            string query = string.Format("delete khachhang where ma=N'{0}' ", ma);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        // tìm kiếm khách hàng
        public List<khachhang> SearchKh(string ma)
        {
            List<khachhang> list = new List<khachhang>();
            string query = string.Format("select * from khachhang kh where kh.ma like N'%{0}%' ", ma);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow i in data.Rows)
            {
                khachhang ct = new khachhang(i);
                list.Add(ct);
            }
            return list;
        }
        public List<khachhang> SearchKh1(string sdt)
        {
            List<khachhang> list = new List<khachhang>();
            string query = string.Format("select * from khachhang kh where kh.sodienthoai like N'%{0}%' ", sdt);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow i in data.Rows)
            {
                khachhang ct = new khachhang(i);
                list.Add(ct);
            }
            return list;
        }
    }
}
