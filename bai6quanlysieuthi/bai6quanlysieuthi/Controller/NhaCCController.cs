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
    }
}
