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
    public partial class HangHoa : Form
    {
        public HangHoa()
        {
            InitializeComponent();
        }









        private void HangHoa_Load(object sender, EventArgs e)
        {

        }
        #region View kho hàng
        private void btnView_KH_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            ViewKhoHang();
        }
        void ViewKhoHang()
        {
            dgvKhoHang.DataSource = KhoHangController.Instance.XemKhoHang();
            dgvKhoHang.Columns["ma"].HeaderText = @"Mã kho";
            dgvKhoHang.Columns["ma"].Width = 45;
            dgvKhoHang.Columns["ten"].HeaderText = @"Tên kho";
            dgvKhoHang.Columns["ten"].Width = 100;
            dgvKhoHang.Columns["diachi"].HeaderText = @"Địa chỉ";
            dgvKhoHang.Columns["diachi"].Width = 150;
        }

        private void dgvKhoHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKho.Text = dgvKhoHang.CurrentRow.Cells[0].Value.ToString();
            txtTenKho.Text = dgvKhoHang.CurrentRow.Cells[1].Value.ToString();
            rtbDiaChiKho.Text = dgvKhoHang.CurrentRow.Cells[2].Value.ToString();
        }
        #endregion
        #region thêm kho hàng
        private void btnInsert_KH_Click(object sender, EventArgs e)
        {
            if(txtMaKho.Text ==""||txtTenKho.Text==""||rtbDiaChiKho.Text=="")
            {
                if (txtMaKho.Text == "")
                    errorProvider1.SetError(txtMaKho, "Chưa có mã kho");
                if (txtTenKho.Text == "")
                    errorProvider1.SetError(txtTenKho, "Chưa có tên kho");
                if (rtbDiaChiKho.Text == "")
                    errorProvider1.SetError(rtbDiaChiKho, "Chưa có địa chỉ");
                MessageBox.Show("Phải điền đầy đủ thông tin");
                return;
            } 
            else
            {
                errorProvider1.Clear();
            }
            try
            {
                string ma = txtMaKho.Text;
                string ten = txtTenKho.Text;
                string diachi = rtbDiaChiKho.Text;

                if (MessageBox.Show("Bạn có muốn thêm hay không", "Thêm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (KhoHangController.Instance.InsertKhoHang(ma, ten, diachi))
                    {
                        MessageBox.Show("Thêm thành công");
                        ViewKhoHang();
                    }
                }
                else
                {
                    MessageBox.Show("Không thành công!");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi dữ liệu");
                return;
            }
        }
        #endregion
        #region sửa kho hàng
        private void btnUpdate_KH_Click(object sender, EventArgs e)
        {
            if (txtTenKho.Text == "" || rtbDiaChiKho.Text == "")
            {
                if (txtTenKho.Text == "")
                    errorProvider1.SetError(txtTenKho, "Chưa có tên kho");
                if (rtbDiaChiKho.Text == "")
                    errorProvider1.SetError(rtbDiaChiKho, "Chưa có địa chỉ");
                MessageBox.Show("Phải điền thông tin sửa!");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            try
            {
                string ma = txtMaKho.Text;
                string ten = txtTenKho.Text;
                string diachi = rtbDiaChiKho.Text;
                if (MessageBox.Show("Bạn có muốn sửa hay không", "Sửa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (KhoHangController.Instance.UpdateKhoHang(ma, ten, diachi))
                    {
                        MessageBox.Show("Sửa thành công");
                        ViewKhoHang();
                    }
                }
                else
                {
                    MessageBox.Show("Không thành công!");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi dữ liệu");
                return;
            }
        }
        #endregion
        #region xoá kho hàng
        private void btnDelete_KH_Click(object sender, EventArgs e)
        {
            if (txtMaKho.Text == "")
            {
                errorProvider1.SetError(txtMaKho, "Chưa có mã kho cần xóa");
                MessageBox.Show("Phải có mã kho cần xóa");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            try
            {
                string ma = txtMaKho.Text;
                if (MessageBox.Show("Bạn có muốn xóa hay không", "Sửa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (KhoHangController.Instance.DeleteKhoHang(ma))
                    {
                        MessageBox.Show("Xóa thành công");
                        ViewKhoHang();
                    }
                }
                else
                {
                    MessageBox.Show("Không thành công");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi dữ liệu");
                return;
            }
        }
        #endregion
    }
}
