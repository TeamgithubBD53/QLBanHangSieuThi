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
    class MatHangController
    {
        private static MatHangController instance;
        public static MatHangController Instance
        {
            get
            {
                if (instance == null)
                    instance = new MatHangController();
                return MatHangController.instance;
            }
            private set { MatHangController.instance = value; }
        }

        private MatHangController() { }
        // xem mat hang
        public List<mathang> XemMatHang()
        {
            List<mathang> list = new List<mathang>();
            string query = "select ma,ten,loaimathang,donvitinh,maquay,manhacc,gia from mathang";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                mathang mh = new mathang(item);
                list.Add(mh);
            }
            return list;
        }

        // thêm mặt hàng
        public bool InsertMatHang(string ma, string ten, string loaimh, string donvitinh, string maquay, string mancc, float gia)
        {
            string query = string.Format("insert mathang(ma,ten,loaimathang,donvitinh,maquay,manhacc,gia) values(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',{6})", ma, ten, loaimh, donvitinh, maquay, mancc, gia);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        // sửa mặt hàng
        public bool UpdateMatHang(string ma, string ten, string loaimh, string donvitinh, string maquay, string mancc, float gia)
        {
            string query = string.Format("update mathang set ten=N'{0}',loaimathang=N'{1}',donvitinh=N'{2}',maquay=N'{3}',manhacc=N'{4}',gia={5} where ma=N'{5}'", ten, loaimh, donvitinh, maquay, mancc, gia, ma);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        // xoas mặt hàng
        public bool DeleteMatHang(string ma)
        {
            string query = string.Format("delete mathang where ma=N'{0}'", ma);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        // tìm mặt hàng
        public List<mathang> SearchMatHang(string ma, string ten, string loaimathang, string maquay, string mancc)
        {
            List<mathang> list = new List<mathang>();
            string query = string.Format("select * from mathang mh where mh.ma like N'%{0}%' and mh.ten like N'%{1}%' and mh.loaimathang like N'%{2}%' and mh.maquay like N'%{3}%' and mh.manhacc like N'%{4}%'", ma, ten, loaimathang, maquay, mancc);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow i in data.Rows)
            {
                mathang mh = new mathang(i);
                list.Add(mh);
            }
            return list;
        }
    }
}
