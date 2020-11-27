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

namespace bai6quanlysieuthi.Views
{
    public partial class ChiTiet_NhapKho : Form
    {
        public ChiTiet_NhapKho()
        {
            InitializeComponent();
        }
#region View chi tiết nhập kho
        private void btnView_CTNK_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            ViewCtNhapKho();
        }
        void ViewCtNhapKho()
        {
            dgvCtNhap.DataSource = CtPhieuNhapController.Instance.XemCtPhieuNhap();
            dgvCtNhap.Columns["stt"].Width = 45;
            dgvCtNhap.Columns["manhap"].HeaderText = @"Mã nhập";
            dgvCtNhap.Columns["manhap"].Width = 80;
            dgvCtNhap.Columns["mamathang"].HeaderText = @"Mã mặt hàng";
            dgvCtNhap.Columns["mamathang"].Width = 80;
            dgvCtNhap.Columns["soluong"].HeaderText = "Số lượng";
            dgvCtNhap.Columns["soluong"].Width = 80;
            dgvCtNhap.Columns["dongia"].HeaderText = @"Đơn giá";
            dgvCtNhap.Columns["dongia"].Width = 80;
        }
#endregion
        private void btnInsert_CTNK_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_CTNK_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_CTNK_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_CTNK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_CTNK_Click(object sender, EventArgs e)
        {

        }

        private void dgvCtNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSTT.Text = dgvCtNhap.CurrentRow.Cells[0].Value.ToString();
            cbMaNhap.Text = dgvCtNhap.CurrentRow.Cells[1].Value.ToString();
            cbMaMatHang.Text = dgvCtNhap.CurrentRow.Cells[2].Value.ToString();
            txtSoLuong.Text = dgvCtNhap.CurrentRow.Cells[3].Value.ToString();
            txtDonGia.Text = dgvCtNhap.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
