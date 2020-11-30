﻿using System;
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

        #region Hóa đơn
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
        #region Thêm hóa đơn
        private void btnInsertHD_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == "" || txtMaNhanVien.Text == "" || txtMaKhachHang.Text == "")
            {
                if (txtMaHD.Text == "")
                    errorProvider1.SetError(txtMaHD, "Chưa có dữ liệu");
                if (txtMaNhanVien.Text == "")
                    errorProvider1.SetError(txtMaNhanVien, "Chưa có dữ liệu");
                if (txtMaKhachHang.Text == "")
                    errorProvider1.SetError(txtMaKhachHang, "Chưa có dữ liệu");
                MessageBox.Show("Phải điền thông tin");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            try
            {
                string ma = txtMaHD.Text;
                string manv = txtMaNhanVien.Text;
                DateTime ngaylap = (DateTime)Convert.ToDateTime(dtpNgayLap.Value.ToString("MM/dd/yyyy"));
                string makh = txtMaKhachHang.Text;
                if (MessageBox.Show("Bạn có muốn thêm hay không", "Thêm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (HoaDonController.Instance.InsertHoaDon(ma, ngaylap, manv, makh))
                    {
                        ViewHoaDon();
                        ChiTiet_HD f = new ChiTiet_HD();
                        f.ShowDialog();
                        MessageBox.Show("Thêm thành công!");
                    }
                }
                else
                {
                    MessageBox.Show("Không thành công");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi thêm dữ liệu");
                return;
            }
        }
        #endregion

        #region Sửa hóa đơn
        private void btnUpdateHD_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == "" || txtMaNhanVien.Text == "" || txtMaKhachHang.Text == "")
            {
                if (txtMaHD.Text == "")
                    errorProvider1.SetError(txtMaHD, "Chưa có dữ liệu");
                if (txtMaNhanVien.Text == "")
                    errorProvider1.SetError(txtMaNhanVien, "Chưa có dữ liệu");
                if (txtMaKhachHang.Text == "")
                    errorProvider1.SetError(txtMaKhachHang, "Chưa có dữ liệu");
                MessageBox.Show("Phải điền thông tin");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            try
            {
                string ma = txtMaHD.Text;
                string manv = txtMaNhanVien.Text;
                DateTime ngaylap = (DateTime)Convert.ToDateTime(dtpNgayLap.Value.ToString("MM/dd/yyyy"));
                string makh = txtMaKhachHang.Text;
                if (MessageBox.Show("Bạn có muốn sửahay không", "Thêm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (HoaDonController.Instance.UpdateHoaDon(ma, ngaylap, manv, makh))
                    {
                        MessageBox.Show("Sửa thành công!");
                        ViewHoaDon();
                    }
                }
                else
                {
                    MessageBox.Show("Không thành công");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi thêm dữ liệu");
                return;
            }
        }
        #endregion

        #region Xóa hóa đơn
        private void btnDeleteHD_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            string ma = txtMaHD.Text;
            if (MessageBox.Show("Bạn có muốn xóa hay không", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (HoaDonController.Instance.DeleteHoaDon(ma))
                {
                    MessageBox.Show("Xóa thành công!");
                    ViewHoaDon();
                }
            }
            else
            {
                MessageBox.Show("Không thành công!");
            }
        }
        #endregion

        #region Tìm kiếm hóa đơn
        private void btnSearchHD_Click(object sender, EventArgs e)
        {
            if (cbbSeachHD.Text == @"Mã hóa đơn")
            {
                if (txtSearchHD.Text != "")
                {
                    dgvHoaDon.DataSource = HoaDonController.Instance.SearchHd(txtSearchHD.Text);
                }
            }
            else if (cbbSeachHD.Text == @"Mã nhân viên")
            {
                if (txtSearchHD.Text != "")
                {
                    dgvHoaDon.DataSource = HoaDonController.Instance.SearchHd1(txtSearchHD.Text);
                }
            }
            else if (cbbSeachHD.Text == @"Mã khách hàng")
            {
                if (txtSearchHD.Text != "")
                {
                    dgvHoaDon.DataSource = HoaDonController.Instance.SearchHd2(txtSearchHD.Text);
                }
            }
        }
        #endregion

        #region chi tiết hóa đon
        private void btnChiTietHD_Click(object sender, EventArgs e)
        {
            ChiTiet_HD f = new ChiTiet_HD();
            f.ShowDialog();
        }
        #endregion

        #region Thoát
        private void btnExitHD_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #endregion
    }
}
