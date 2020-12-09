namespace bai6quanlysieuthi.Views
{
    partial class KhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhachHang));
            this.mnsKhachHang = new System.Windows.Forms.MenuStrip();
            this.menuTrangChu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHangHoa = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbSearchKh = new System.Windows.Forms.ComboBox();
            this.txtSearchKh = new System.Windows.Forms.TextBox();
            this.btnSearchKh = new System.Windows.Forms.Button();
            this.btnExitKH = new System.Windows.Forms.Button();
            this.btnDeleteKh = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsertKh = new System.Windows.Forms.Button();
            this.btnViewKh = new System.Windows.Forms.Button();
            this.dgvKh = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUudai = new System.Windows.Forms.TextBox();
            this.txtSodt = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtTenkh = new System.Windows.Forms.TextBox();
            this.txtMakh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnExitHD = new System.Windows.Forms.Button();
            this.btnDeleteHD = new System.Windows.Forms.Button();
            this.btnUpdateHD = new System.Windows.Forms.Button();
            this.btnInsertHD = new System.Windows.Forms.Button();
            this.btnViewHD = new System.Windows.Forms.Button();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnChiTietHD = new System.Windows.Forms.Button();
            this.txtSearchHD = new System.Windows.Forms.TextBox();
            this.cbbSeachHD = new System.Windows.Forms.ComboBox();
            this.btnSearchHD = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtTongGiaTri = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.mnsKhachHang.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKh)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // mnsKhachHang
            // 
            this.mnsKhachHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnsKhachHang.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsKhachHang.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTrangChu,
            this.menuHangHoa,
            this.menuNhanVien});
            this.mnsKhachHang.Location = new System.Drawing.Point(0, 0);
            this.mnsKhachHang.Name = "mnsKhachHang";
            this.mnsKhachHang.Size = new System.Drawing.Size(1179, 36);
            this.mnsKhachHang.TabIndex = 0;
            this.mnsKhachHang.Text = "menuStrip1";
            // 
            // menuTrangChu
            // 
            this.menuTrangChu.Name = "menuTrangChu";
            this.menuTrangChu.Size = new System.Drawing.Size(110, 32);
            this.menuTrangChu.Text = "Trang chủ";
            this.menuTrangChu.Click += new System.EventHandler(this.menuTrangChu_Click);
            // 
            // menuHangHoa
            // 
            this.menuHangHoa.Name = "menuHangHoa";
            this.menuHangHoa.Size = new System.Drawing.Size(111, 32);
            this.menuHangHoa.Text = "Hàng hóa";
            this.menuHangHoa.Click += new System.EventHandler(this.menuHangHoa_Click);
            // 
            // menuNhanVien
            // 
            this.menuNhanVien.Name = "menuNhanVien";
            this.menuNhanVien.Size = new System.Drawing.Size(114, 32);
            this.menuNhanVien.Text = "Nhân viên";
            this.menuNhanVien.Click += new System.EventHandler(this.menuNhanVien_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 37);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1179, 597);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.btnExitKH);
            this.tabPage1.Controls.Add(this.btnDeleteKh);
            this.tabPage1.Controls.Add(this.btnUpdate);
            this.tabPage1.Controls.Add(this.btnInsertKh);
            this.tabPage1.Controls.Add(this.btnViewKh);
            this.tabPage1.Controls.Add(this.dgvKh);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1171, 559);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Khách hàng";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmbSearchKh);
            this.panel1.Controls.Add(this.txtSearchKh);
            this.panel1.Controls.Add(this.btnSearchKh);
            this.panel1.Location = new System.Drawing.Point(44, 186);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(926, 52);
            this.panel1.TabIndex = 8;
            // 
            // cmbSearchKh
            // 
            this.cmbSearchKh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearchKh.FormattingEnabled = true;
            this.cmbSearchKh.Items.AddRange(new object[] {
            "Mã khách hàng",
            "Số điện thoại"});
            this.cmbSearchKh.Location = new System.Drawing.Point(48, 10);
            this.cmbSearchKh.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSearchKh.Name = "cmbSearchKh";
            this.cmbSearchKh.Size = new System.Drawing.Size(192, 32);
            this.cmbSearchKh.TabIndex = 12;
            // 
            // txtSearchKh
            // 
            this.txtSearchKh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchKh.Location = new System.Drawing.Point(280, 10);
            this.txtSearchKh.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchKh.Name = "txtSearchKh";
            this.txtSearchKh.Size = new System.Drawing.Size(297, 29);
            this.txtSearchKh.TabIndex = 11;
            // 
            // btnSearchKh
            // 
            this.btnSearchKh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearchKh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchKh.Location = new System.Drawing.Point(740, 10);
            this.btnSearchKh.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchKh.Name = "btnSearchKh";
            this.btnSearchKh.Size = new System.Drawing.Size(131, 34);
            this.btnSearchKh.TabIndex = 1;
            this.btnSearchKh.Text = "Tìm kiếm";
            this.btnSearchKh.UseVisualStyleBackColor = false;
            this.btnSearchKh.Click += new System.EventHandler(this.btnSearchKh_Click);
            // 
            // btnExitKH
            // 
            this.btnExitKH.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExitKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitKH.Location = new System.Drawing.Point(1008, 459);
            this.btnExitKH.Margin = new System.Windows.Forms.Padding(4);
            this.btnExitKH.Name = "btnExitKH";
            this.btnExitKH.Size = new System.Drawing.Size(113, 49);
            this.btnExitKH.TabIndex = 7;
            this.btnExitKH.Text = "Thoát";
            this.btnExitKH.UseVisualStyleBackColor = false;
            this.btnExitKH.Click += new System.EventHandler(this.btnExitHD_Click);
            // 
            // btnDeleteKh
            // 
            this.btnDeleteKh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDeleteKh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteKh.Location = new System.Drawing.Point(1008, 393);
            this.btnDeleteKh.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteKh.Name = "btnDeleteKh";
            this.btnDeleteKh.Size = new System.Drawing.Size(113, 49);
            this.btnDeleteKh.TabIndex = 5;
            this.btnDeleteKh.Text = "Xóa";
            this.btnDeleteKh.UseVisualStyleBackColor = false;
            this.btnDeleteKh.Click += new System.EventHandler(this.btnDeleteKh_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(1008, 326);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(113, 49);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsertKh
            // 
            this.btnInsertKh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInsertKh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertKh.Location = new System.Drawing.Point(1008, 263);
            this.btnInsertKh.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertKh.Name = "btnInsertKh";
            this.btnInsertKh.Size = new System.Drawing.Size(113, 49);
            this.btnInsertKh.TabIndex = 3;
            this.btnInsertKh.Text = "Thêm";
            this.btnInsertKh.UseVisualStyleBackColor = false;
            this.btnInsertKh.Click += new System.EventHandler(this.btnInsertKh_Click);
            // 
            // btnViewKh
            // 
            this.btnViewKh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnViewKh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewKh.Location = new System.Drawing.Point(1008, 197);
            this.btnViewKh.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewKh.Name = "btnViewKh";
            this.btnViewKh.Size = new System.Drawing.Size(113, 49);
            this.btnViewKh.TabIndex = 2;
            this.btnViewKh.Text = "Xem";
            this.btnViewKh.UseVisualStyleBackColor = false;
            this.btnViewKh.Click += new System.EventHandler(this.btnViewKh_Click);
            // 
            // dgvKh
            // 
            this.dgvKh.AllowUserToOrderColumns = true;
            this.dgvKh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKh.Location = new System.Drawing.Point(44, 246);
            this.dgvKh.Margin = new System.Windows.Forms.Padding(4);
            this.dgvKh.Name = "dgvKh";
            this.dgvKh.ReadOnly = true;
            this.dgvKh.RowHeadersWidth = 51;
            this.dgvKh.Size = new System.Drawing.Size(927, 271);
            this.dgvKh.TabIndex = 1;
            this.dgvKh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKh_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUudai);
            this.groupBox1.Controls.Add(this.txtSodt);
            this.groupBox1.Controls.Add(this.txtDiachi);
            this.groupBox1.Controls.Add(this.txtTenkh);
            this.groupBox1.Controls.Add(this.txtMakh);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(44, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1077, 171);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Khách hàng";
            // 
            // txtUudai
            // 
            this.txtUudai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUudai.Location = new System.Drawing.Point(741, 81);
            this.txtUudai.Margin = new System.Windows.Forms.Padding(4);
            this.txtUudai.Name = "txtUudai";
            this.txtUudai.Size = new System.Drawing.Size(267, 29);
            this.txtUudai.TabIndex = 10;
            this.txtUudai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSodt
            // 
            this.txtSodt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSodt.Location = new System.Drawing.Point(741, 34);
            this.txtSodt.Margin = new System.Windows.Forms.Padding(4);
            this.txtSodt.Name = "txtSodt";
            this.txtSodt.Size = new System.Drawing.Size(267, 29);
            this.txtSodt.TabIndex = 9;
            this.txtSodt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiachi.Location = new System.Drawing.Point(252, 132);
            this.txtDiachi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(757, 29);
            this.txtDiachi.TabIndex = 8;
            this.txtDiachi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTenkh
            // 
            this.txtTenkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenkh.Location = new System.Drawing.Point(251, 81);
            this.txtTenkh.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenkh.Name = "txtTenkh";
            this.txtTenkh.Size = new System.Drawing.Size(279, 29);
            this.txtTenkh.TabIndex = 7;
            this.txtTenkh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMakh
            // 
            this.txtMakh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMakh.Location = new System.Drawing.Point(251, 34);
            this.txtMakh.Margin = new System.Windows.Forms.Padding(4);
            this.txtMakh.Name = "txtMakh";
            this.txtMakh.Size = new System.Drawing.Size(277, 29);
            this.txtMakh.TabIndex = 6;
            this.txtMakh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(595, 85);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ưu đãi";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(595, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên khách hàng";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khách hàng";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.btnExitHD);
            this.tabPage2.Controls.Add(this.btnDeleteHD);
            this.tabPage2.Controls.Add(this.btnUpdateHD);
            this.tabPage2.Controls.Add(this.btnInsertHD);
            this.tabPage2.Controls.Add(this.btnViewHD);
            this.tabPage2.Controls.Add(this.dgvHoaDon);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1171, 559);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hóa đơn";
            // 
            // btnExitHD
            // 
            this.btnExitHD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExitHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitHD.Location = new System.Drawing.Point(1011, 478);
            this.btnExitHD.Margin = new System.Windows.Forms.Padding(4);
            this.btnExitHD.Name = "btnExitHD";
            this.btnExitHD.Size = new System.Drawing.Size(113, 49);
            this.btnExitHD.TabIndex = 13;
            this.btnExitHD.Text = "Thoát";
            this.btnExitHD.UseVisualStyleBackColor = false;
            this.btnExitHD.Click += new System.EventHandler(this.btnExitHD_Click);
            // 
            // btnDeleteHD
            // 
            this.btnDeleteHD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDeleteHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteHD.Location = new System.Drawing.Point(1011, 405);
            this.btnDeleteHD.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteHD.Name = "btnDeleteHD";
            this.btnDeleteHD.Size = new System.Drawing.Size(113, 49);
            this.btnDeleteHD.TabIndex = 11;
            this.btnDeleteHD.Text = "Xóa";
            this.btnDeleteHD.UseVisualStyleBackColor = false;
            this.btnDeleteHD.Click += new System.EventHandler(this.btnDeleteHD_Click);
            // 
            // btnUpdateHD
            // 
            this.btnUpdateHD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdateHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateHD.Location = new System.Drawing.Point(1011, 331);
            this.btnUpdateHD.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateHD.Name = "btnUpdateHD";
            this.btnUpdateHD.Size = new System.Drawing.Size(113, 49);
            this.btnUpdateHD.TabIndex = 10;
            this.btnUpdateHD.Text = "Sửa";
            this.btnUpdateHD.UseVisualStyleBackColor = false;
            this.btnUpdateHD.Click += new System.EventHandler(this.btnUpdateHD_Click);
            // 
            // btnInsertHD
            // 
            this.btnInsertHD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInsertHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertHD.Location = new System.Drawing.Point(1011, 257);
            this.btnInsertHD.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertHD.Name = "btnInsertHD";
            this.btnInsertHD.Size = new System.Drawing.Size(113, 49);
            this.btnInsertHD.TabIndex = 9;
            this.btnInsertHD.Text = "Thêm";
            this.btnInsertHD.UseVisualStyleBackColor = false;
            this.btnInsertHD.Click += new System.EventHandler(this.btnInsertHD_Click);
            // 
            // btnViewHD
            // 
            this.btnViewHD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnViewHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewHD.Location = new System.Drawing.Point(1011, 188);
            this.btnViewHD.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewHD.Name = "btnViewHD";
            this.btnViewHD.Size = new System.Drawing.Size(113, 49);
            this.btnViewHD.TabIndex = 8;
            this.btnViewHD.Text = "Xem";
            this.btnViewHD.UseVisualStyleBackColor = false;
            this.btnViewHD.Click += new System.EventHandler(this.btnViewHD_Click);
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Location = new System.Drawing.Point(55, 220);
            this.dgvHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.Size = new System.Drawing.Size(921, 303);
            this.dgvHoaDon.TabIndex = 2;
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellClick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnChiTietHD);
            this.panel2.Controls.Add(this.txtSearchHD);
            this.panel2.Controls.Add(this.cbbSeachHD);
            this.panel2.Controls.Add(this.btnSearchHD);
            this.panel2.Location = new System.Drawing.Point(55, 161);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(919, 51);
            this.panel2.TabIndex = 1;
            // 
            // btnChiTietHD
            // 
            this.btnChiTietHD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnChiTietHD.Location = new System.Drawing.Point(743, 9);
            this.btnChiTietHD.Margin = new System.Windows.Forms.Padding(4);
            this.btnChiTietHD.Name = "btnChiTietHD";
            this.btnChiTietHD.Size = new System.Drawing.Size(160, 37);
            this.btnChiTietHD.TabIndex = 1;
            this.btnChiTietHD.Text = "Chi tiết ";
            this.btnChiTietHD.UseVisualStyleBackColor = false;
            this.btnChiTietHD.Click += new System.EventHandler(this.btnChiTietHD_Click);
            // 
            // txtSearchHD
            // 
            this.txtSearchHD.Location = new System.Drawing.Point(241, 10);
            this.txtSearchHD.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchHD.Name = "txtSearchHD";
            this.txtSearchHD.Size = new System.Drawing.Size(227, 30);
            this.txtSearchHD.TabIndex = 26;
            // 
            // cbbSeachHD
            // 
            this.cbbSeachHD.FormattingEnabled = true;
            this.cbbSeachHD.Items.AddRange(new object[] {
            "Mã hóa đơn",
            "Mã nhân viên",
            "Mã khách hàng"});
            this.cbbSeachHD.Location = new System.Drawing.Point(31, 7);
            this.cbbSeachHD.Margin = new System.Windows.Forms.Padding(4);
            this.cbbSeachHD.Name = "cbbSeachHD";
            this.cbbSeachHD.Size = new System.Drawing.Size(175, 33);
            this.cbbSeachHD.TabIndex = 1;
            // 
            // btnSearchHD
            // 
            this.btnSearchHD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearchHD.Location = new System.Drawing.Point(549, 7);
            this.btnSearchHD.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchHD.Name = "btnSearchHD";
            this.btnSearchHD.Size = new System.Drawing.Size(120, 37);
            this.btnSearchHD.TabIndex = 0;
            this.btnSearchHD.Text = "Tìm kiếm";
            this.btnSearchHD.UseVisualStyleBackColor = false;
            this.btnSearchHD.Click += new System.EventHandler(this.btnSearchHD_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMaKhachHang);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtMaNhanVien);
            this.groupBox2.Controls.Add(this.txtThanhTien);
            this.groupBox2.Controls.Add(this.txtTongGiaTri);
            this.groupBox2.Controls.Add(this.txtMaHD);
            this.groupBox2.Controls.Add(this.dtpNgayLap);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(55, 9);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1069, 145);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hóa đơn";
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKhachHang.Location = new System.Drawing.Point(244, 66);
            this.txtMaKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(183, 29);
            this.txtMaKhachHang.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(25, 66);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 24);
            this.label11.TabIndex = 26;
            this.label11.Text = "Mã khách hàng";
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNhanVien.Location = new System.Drawing.Point(244, 107);
            this.txtMaNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(183, 29);
            this.txtMaNhanVien.TabIndex = 25;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhTien.Location = new System.Drawing.Point(689, 63);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(4);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(213, 29);
            this.txtThanhTien.TabIndex = 24;
            // 
            // txtTongGiaTri
            // 
            this.txtTongGiaTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongGiaTri.Location = new System.Drawing.Point(689, 23);
            this.txtTongGiaTri.Margin = new System.Windows.Forms.Padding(4);
            this.txtTongGiaTri.Name = "txtTongGiaTri";
            this.txtTongGiaTri.ReadOnly = true;
            this.txtTongGiaTri.Size = new System.Drawing.Size(213, 29);
            this.txtTongGiaTri.TabIndex = 23;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.Location = new System.Drawing.Point(244, 27);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(183, 29);
            this.txtMaHD.TabIndex = 21;
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayLap.Location = new System.Drawing.Point(691, 107);
            this.dtpNgayLap.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(365, 29);
            this.dtpNgayLap.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(547, 66);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 24);
            this.label10.TabIndex = 19;
            this.label10.Text = "Thành tiền";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(547, 27);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 24);
            this.label7.TabIndex = 18;
            this.label7.Text = "Tổng giá trị";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 107);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 24);
            this.label9.TabIndex = 17;
            this.label9.Text = "Mã nhân viên";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(547, 113);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "Ngày lập";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 629);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.mnsKhachHang);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnsKhachHang;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KhachHang";
            this.Text = "KhachHang";
            this.mnsKhachHang.ResumeLayout(false);
            this.mnsKhachHang.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsKhachHang;
        private System.Windows.Forms.ToolStripMenuItem menuTrangChu;
        private System.Windows.Forms.ToolStripMenuItem menuHangHoa;
        private System.Windows.Forms.ToolStripMenuItem menuNhanVien;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtUudai;
        private System.Windows.Forms.TextBox txtSodt;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtTenkh;
        private System.Windows.Forms.TextBox txtMakh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearchKh;
        private System.Windows.Forms.Button btnExitKH;
        private System.Windows.Forms.Button btnDeleteKh;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsertKh;
        private System.Windows.Forms.Button btnViewKh;
        private System.Windows.Forms.DataGridView dgvKh;
        private System.Windows.Forms.TextBox txtSearchKh;
        private System.Windows.Forms.ComboBox cmbSearchKh;
        private System.Windows.Forms.Button btnExitHD;
        private System.Windows.Forms.Button btnDeleteHD;
        private System.Windows.Forms.Button btnUpdateHD;
        private System.Windows.Forms.Button btnInsertHD;
        private System.Windows.Forms.Button btnViewHD;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearchHD;
        private System.Windows.Forms.ComboBox cbbSeachHD;
        private System.Windows.Forms.Button btnSearchHD;
        private System.Windows.Forms.Button btnChiTietHD;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtTongGiaTri;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.Label label11;
    }
}