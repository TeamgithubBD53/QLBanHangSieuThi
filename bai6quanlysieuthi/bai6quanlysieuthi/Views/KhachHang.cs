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


        #region Xem Hóa Đơn
        private void btnViewHD_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            ViewHoaDon();
        }
        // xem hóa đơn
        void ViewHoaDon()
        {
            dgvHoaDon.DataSource = HoaDonController.Instance.XemHoaDon();
            dgvHoaDon.Columns["ma"].HeaderText = @"Mã";
            dgvHoaDon.Columns["ma"].Width = 45;
            dgvHoaDon.Columns["makhachhang"].HeaderText = @"Mã khách hàng";
            dgvHoaDon.Columns["makhachhang"].Width = 80;
            dgvHoaDon.Columns["manhanvien"].HeaderText = @"Mã nhân viên";
            dgvHoaDon.Columns["manhanvien"].Width = 80;
            dgvHoaDon.Columns["ngaylap"].HeaderText = @"Ngày lập";
            dgvHoaDon.Columns["ngaylap"].Width = 90;
            dgvHoaDon.Columns["tonggiatri"].HeaderText = @"Tổng giá trị";
            dgvHoaDon.Columns["tonggiatri"].Width = 80;
            dgvHoaDon.Columns["thanhtien"].HeaderText = @"Thành tiền";
            dgvHoaDon.Columns["thanhtien"].Width = 80;
        }
        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHD.Text = dgvHoaDon.CurrentRow.Cells[0].Value.ToString();
            dtpNgayLap.Text = dgvHoaDon.CurrentRow.Cells[1].Value.ToString();
            txtMaNhanVien.Text = dgvHoaDon.CurrentRow.Cells[4].Value.ToString();
            txtTongGiaTri.Text = dgvHoaDon.CurrentRow.Cells[2].Value.ToString();
            txtThanhTien.Text = dgvHoaDon.CurrentRow.Cells[3].Value.ToString();
            txtMaKhachHang.Text = dgvHoaDon.CurrentRow.Cells[4].Value.ToString();
        }
        #endregion
        private void btnInsertHD_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateHD_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteHD_Click(object sender, EventArgs e)
        {

        }

        private void btnExitHD_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchHD_Click(object sender, EventArgs e)
        {

        }

        private void btnChiTietHD_Click(object sender, EventArgs e)
        {

        }
    }
}
