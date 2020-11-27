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
    class KiemKeController
    {
        private static KiemKeController instance;
        public static KiemKeController Instance
        {
            get
            {
                if (instance == null)
                    instance = new KiemKeController();
                return KiemKeController.instance;
            }
            private set { KiemKeController.instance = value; }
        }

        private KiemKeController() { }

        public List<phieukiemke> XemKiemKe()
        {
            List<phieukiemke> list = new List<phieukiemke>();
            string query = "select ma,ngaylap,mamathang,soluong,makhohang,manhanvien from phieukiemke";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                phieukiemke kk = new phieukiemke(item);
                list.Add(kk);
            }
            return list;
        }
    }
}
