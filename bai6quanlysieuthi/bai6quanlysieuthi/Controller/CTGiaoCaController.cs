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
    class CTGiaoCaController
    {
        public static CTGiaoCaController instance;
        public static CTGiaoCaController Instance
        {
            get
            {
                if (instance == null)
                    instance = new CTGiaoCaController();
                return CTGiaoCaController.instance;
            }
            private set { CTGiaoCaController.instance = value; }
        }

        public CTGiaoCaController() { }
        // xem chi tiết phiếu giao ca
        public List<chitietphieugiaoca> XemCtGiaoCa()
        {
            List<chitietphieugiaoca> list = new List<chitietphieugiaoca>();
            string query = "select stt, magiaoca,mamathang,soluong from chitietphieugiaoca";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                chitietphieugiaoca hd = new chitietphieugiaoca(item);
                list.Add(hd);
            }
            return list;
        }
        // thêm chi tiết phiếu giao ca
        public bool InsertCtGiaoCa(string magiaoca, string mamathang, int soluong)
        {
            string query = string.Format("insert chitietphieugiaoca(magiaoca,mamathang,soluong) values(N'{0}',N'{1}',N'{2}')", magiaoca, mamathang, soluong);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        // sửa chi tiết giao ca
        public bool UpdateCtGiaoCa(int stt, string magiaoca, string mamathang, int soluong)
        {
            string query = string.Format("update chitietphieugiaoca set magiaoca=N'{0}',mamathang=N'{1}',soluong={2} where stt={3}", magiaoca, mamathang, soluong, stt);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        // xóa chi tiết giao ca
        public bool DeleteCtGiaoCa(int stt)
        {
            string query = string.Format("delete chitietphieugiaoca where stt={0}", stt);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        // tìm kiếm chi tiết phiếu giao ca
        public List<chitietphieugiaoca> SearchCtGiaoCa(string magiaoca, string mamathang)
        {
            List<chitietphieugiaoca> list = new List<chitietphieugiaoca>();
            string query = string.Format("select * from chitietphieugiaoca where magiaoca like N'%{0}%' and mamathang like N'%{1}%'", magiaoca, mamathang);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow i in data.Rows)
            {
                chitietphieugiaoca ct = new chitietphieugiaoca(i);
                list.Add(ct);
            }
            return list;
        }
    }
}
