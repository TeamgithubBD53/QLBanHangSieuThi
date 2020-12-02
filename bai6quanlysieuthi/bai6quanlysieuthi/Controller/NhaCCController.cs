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
    class NhaCCController
    {
        private static NhaCCController instance;
        public static NhaCCController Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhaCCController();
                return NhaCCController.instance;
            }
            private set { NhaCCController.instance = value; }
        }

        public NhaCCController() { }
        // xem nhà cung cấp
        public List<nhacungcap> XemNhaCC()
        {
            List<nhacungcap> list = new List<nhacungcap>();
            string query = "select ma, ten, diachi,sodienthoai, email from nhacungcap";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                nhacungcap ncc = new nhacungcap(item);
                list.Add(ncc);
            }
            return list;
        }

        // thêm nhà cung cấp
        public bool InsertNhaCC(string ma, string ten, string diachi, string sdt, string email)
        {
            string query = string.Format("insert nhacungcap(ma,ten,diachi,sodienthoai,email) values(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}')", ma, ten, diachi, sdt, email);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        // sửa nhà cung cấp
        public bool UpdateNhaCC(string ma, string ten, string diachi, string sdt, string email)
        {
            string query = string.Format("update nhacungcap a set a.ten=N'{0}',a.diachi=N'{1}',a.sodienthoai=N'{2}',a.email=N'{3}' where a.ma=N'{4}'", ten, diachi, sdt, email, ma);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        // xóa nhà cung cấp
        public bool DeleteNhaCC(string ma)
        {
            string query = string.Format("delete nhacungcap where ma=N'{0}'", ma);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
    }
}
