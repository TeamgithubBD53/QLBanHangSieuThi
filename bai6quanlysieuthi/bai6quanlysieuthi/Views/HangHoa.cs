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
        #region tìm kiếm
        private void btnSearch_KQ_Click(object sender, EventArgs e)
        {

            if (cbSearch.Text == @"Quầy hàng")
            {
                if (txtMaQuayH.Text == "" && txtTenQuayH.Text == "")
                {
                    if (txtMaQuayH.Text == "")
                        errorProvider1.SetError(txtMaQuayH, "Chưa nhập mã cần tìm");
                    if (txtTenQuayH.Text == "")
                        errorProvider1.SetError(txtTenQuayH, "Chưa nhập tên cần tìm");
                    MessageBox.Show("Phải nhập mã hoặc tên cần tìm");
                }
                else
                {
                    errorProvider1.Clear();
                }
                string ma = txtMaQuayH.Text;
                string ten = txtTenQuayH.Text;
                if (txtMaQuayH.Text != "" || txtTenQuayH.Text != "")
                {
                    dgvQuayHang.DataSource = QuayHangController.Instance.SearchQuayHang(ma, ten);
                }
            }
            else if (cbSearch.Text == @"Kho hàng")
            {
                if (txtMaKho.Text == "" && txtTenKho.Text == "")
                {
                    if (txtMaKho.Text == "")
                        errorProvider1.SetError(txtMaKho, "Chưa nhập mã cần tìm");
                    if (txtTenKho.Text == "")
                        errorProvider1.SetError(txtTenKho, "Chưa nhập tên cần tìm");
                    MessageBox.Show("Phải nhập vào mã hoặc tên cần tìm");
                    return;
                }
                else
                {
                    errorProvider1.Clear();
                }
                string ma = txtMaKho.Text;
                string ten = txtTenKho.Text;
                if (txtMaKho.Text != "" || txtTenKho.Text != "")
                {
                    dgvKhoHang.DataSource = KhoHangController.Instance.SearchKhoHang(ma, ten);
                }
            }
        }
        #endregion
        #region  Xem Quầy hàng
        private void btnView_QH_Click(object sender, EventArgs e)
        {
            dgvQuayHang.DataSource = QuayHangController.Instance.XemQuayHang();
            dgvQuayHang.Columns["ma"].HeaderText = @"Mã quầy";
            dgvQuayHang.Columns["ma"].Width = 45;
            dgvQuayHang.Columns["ten"].HeaderText = @"Tên quầy";
            dgvQuayHang.Columns["ten"].Width = 80;
            dgvQuayHang.Columns["vitri"].HeaderText = @"Vị trí";
            dgvQuayHang.Columns["vitri"].Width = 80;
        }

        void ViewQuayHang()
        {
            dgvQuayHang.DataSource = QuayHangController.Instance.XemQuayHang();
            dgvQuayHang.Columns["ma"].HeaderText = @"Mã quầy";
            dgvQuayHang.Columns["ma"].Width = 45;
            dgvQuayHang.Columns["ten"].HeaderText = @"Tên quầy";
            dgvQuayHang.Columns["ten"].Width = 80;
            dgvQuayHang.Columns["vitri"].HeaderText = @"Vị trí";
            dgvQuayHang.Columns["vitri"].Width = 80;
        }
        #endregion

        private void dgvQuayHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaQuayH.Text = dgvQuayHang.CurrentRow.Cells[0].Value.ToString();
            txtTenQuayH.Text = dgvQuayHang.CurrentRow.Cells[1].Value.ToString();
            rtbViTriQh.Text = dgvQuayHang.CurrentRow.Cells[2].Value.ToString();
        }
        #region thêm quầy hàng
        private void btnInsert_QH_Click(object sender, EventArgs e)
        {
            if (txtMaQuayH.Text == "" || txtTenQuayH.Text == "" || rtbViTriQh.Text == "")
            {
                if (txtMaQuayH.Text == "")
                    errorProvider1.SetError(txtMaQuayH, "Chưa có mã quầy");
                if (txtTenQuayH.Text == "")
                    errorProvider1.SetError(txtTenQuayH, "Chưa có tên quầy");
                if (rtbViTriQh.Text == "")
                    errorProvider1.SetError(rtbViTriQh, "Chưa có địa chỉ");
                MessageBox.Show("Phải điền thông tin đầy đủ!");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            try
            {
                string ma = txtMaQuayH.Text;
                string ten = txtTenQuayH.Text;
                string vitri = rtbViTriQh.Text;

                if (MessageBox.Show("Bạn có muốn thêm hay không", "Thêm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (QuayHangController.Instance.InsertQuayHang(ma, ten, vitri))
                    {
                        MessageBox.Show("Thêm thành công");
                        ViewQuayHang();
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
        #region sử quầy hàng
        private void btnUpdate_QH_Click(object sender, EventArgs e)
        {
            if (txtTenQuayH.Text == "" || rtbViTriQh.Text == "")
            {
                if (txtTenQuayH.Text == "")
                    errorProvider1.SetError(txtTenQuayH, "Chưa có tên quầy");
                if (rtbViTriQh.Text == "")
                    errorProvider1.SetError(rtbViTriQh, "Chưa có địa chỉ");
                MessageBox.Show("Phải điền thông tin đầy đủ!");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            try
            {
                string ma = txtMaQuayH.Text;
                string ten = txtTenQuayH.Text;
                string vitri = rtbViTriQh.Text;

                if (MessageBox.Show("Bạn có muốn sửa hay không", "Sửa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (QuayHangController.Instance.UpdateQuayHang(ma, ten, vitri))
                    {
                        MessageBox.Show("Sửa thành công");
                        ViewQuayHang();
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
        #region xoá quầy hàng
        private void btnDelete_QH_Click(object sender, EventArgs e)
        {
            if (txtMaQuayH.Text == "")
            {
                errorProvider1.SetError(txtMaQuayH, "Chưa có mã cần xóa");
                MessageBox.Show("Phải nhập vào mã cần xóa");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            try
            {
                string ma = txtMaQuayH.Text;
                if (MessageBox.Show("Bạn có muốn xóa hay không", "xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (QuayHangController.Instance.DeleteQuayHang(ma))
                    {
                        MessageBox.Show("Sửa thành công");
                        ViewQuayHang();
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

        private void btnExit_KQ_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
