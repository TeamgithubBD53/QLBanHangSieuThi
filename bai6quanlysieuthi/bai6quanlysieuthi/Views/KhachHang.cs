using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bai6quanlysieuthi.Controller;
using bai6quanlysieuthi.Views;
using bai6quanlysieuthi.Bus;
namespace bai6quanlysieuthi.Views
{
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }


        #region khachhang

        #region xem khách hàng
        private void btnViewKh_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            ViewKhachHang();
        }

        void ViewKhachHang()
        {
            dgvKh.DataSource = KhachhangController.Instance.XemKhachHang();
            dgvKh.Columns["ma"].HeaderText = @"Mã";
            dgvKh.Columns["ma"].Width = 40;
            dgvKh.Columns["ten"].HeaderText = @"Họ và tên";
            dgvKh.Columns["ten"].Width = 160;
            dgvKh.Columns["diachi"].HeaderText = @"Địa chỉ";
            dgvKh.Columns["diachi"].Width = 180;
            dgvKh.Columns["sodienthoai"].HeaderText = @"Số điện thoại";
            dgvKh.Columns["sodienthoai"].Width = 120;
            dgvKh.Columns["uudai"].HeaderText = @"Ưu đãi";
            dgvKh.Columns["uudai"].Width = 55;
        }

        private void dgvKh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMakh.Text = dgvKh.CurrentRow.Cells[0].Value.ToString();
            txtTenkh.Text = dgvKh.CurrentRow.Cells[1].Value.ToString();
            txtDiachi.Text = dgvKh.CurrentRow.Cells[2].Value.ToString();
            txtSodt.Text = dgvKh.CurrentRow.Cells[3].Value.ToString();
            txtUudai.Text = dgvKh.CurrentRow.Cells[4].Value.ToString();
        }

        #endregion
        #endregion
    }
}