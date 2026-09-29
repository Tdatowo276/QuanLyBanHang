namespace BanHangLuuNiem.DanhMuc
{
    partial class frmSanPham
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
            dataGridView1 = new DataGridView();
            btnThoat = new Button();
            groupBox1 = new GroupBox();
            btnOpen = new Button();
            picAnh = new PictureBox();
            btnChatLieu = new Button();
            cboMachatlieu = new ComboBox();
            label10 = new Label();
            txtDongiaban = new TextBox();
            label9 = new Label();
            txtDongianhap = new TextBox();
            label8 = new Label();
            txtSoluong = new TextBox();
            label7 = new Label();
            label6 = new Label();
            txtGhiChu = new TextBox();
            txtTenHang = new TextBox();
            label4 = new Label();
            txtMaHang = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnBoQua = new Button();
            btnThem = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnTimKiem = new Button();
            btnXuatExcel = new Button();
            btnReload = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAnh).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(168, 919);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1302, 237);
            dataGridView1.TabIndex = 33;
            dataGridView1.CellContentClick += dataGridView1_CellClick;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(1243, 1198);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(143, 51);
            btnThoat.TabIndex = 32;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(btnOpen);
            groupBox1.Controls.Add(picAnh);
            groupBox1.Controls.Add(btnChatLieu);
            groupBox1.Controls.Add(cboMachatlieu);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtDongiaban);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtDongianhap);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtSoluong);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtGhiChu);
            groupBox1.Controls.Add(txtTenHang);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtMaHang);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(114, 145);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1382, 711);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(725, 52);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(143, 51);
            btnOpen.TabIndex = 37;
            btnOpen.Text = "Ảnh :";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // picAnh
            // 
            picAnh.Location = new Point(896, 52);
            picAnh.Name = "picAnh";
            picAnh.Size = new Size(394, 400);
            picAnh.SizeMode = PictureBoxSizeMode.Zoom;
            picAnh.TabIndex = 36;
            picAnh.TabStop = false;
            // 
            // btnChatLieu
            // 
            btnChatLieu.Location = new Point(456, 268);
            btnChatLieu.Name = "btnChatLieu";
            btnChatLieu.Size = new Size(143, 36);
            btnChatLieu.TabIndex = 35;
            btnChatLieu.Text = "Chất Liệu";
            btnChatLieu.UseVisualStyleBackColor = true;
            btnChatLieu.Click += btnChatLieu_Click;
            // 
            // cboMachatlieu
            // 
            cboMachatlieu.FormattingEnabled = true;
            cboMachatlieu.Location = new Point(227, 268);
            cboMachatlieu.Name = "cboMachatlieu";
            cboMachatlieu.Size = new Size(182, 33);
            cboMachatlieu.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label10.Location = new Point(54, 268);
            label10.Name = "label10";
            label10.Size = new Size(118, 30);
            label10.TabIndex = 15;
            label10.Text = "Chất Liệu :";
            // 
            // txtDongiaban
            // 
            txtDongiaban.Location = new Point(227, 561);
            txtDongiaban.Name = "txtDongiaban";
            txtDongiaban.Size = new Size(372, 31);
            txtDongiaban.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label9.Location = new Point(54, 562);
            label9.Name = "label9";
            label9.Size = new Size(147, 30);
            label9.TabIndex = 13;
            label9.Text = "Đơn Giá Bán :";
            // 
            // txtDongianhap
            // 
            txtDongianhap.Location = new Point(227, 464);
            txtDongianhap.Name = "txtDongianhap";
            txtDongianhap.Size = new Size(372, 31);
            txtDongianhap.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label8.Location = new Point(54, 465);
            label8.Name = "label8";
            label8.Size = new Size(164, 30);
            label8.TabIndex = 11;
            label8.Text = "Đơn Giá Nhập :";
            // 
            // txtSoluong
            // 
            txtSoluong.Location = new Point(227, 355);
            txtSoluong.Name = "txtSoluong";
            txtSoluong.Size = new Size(372, 31);
            txtSoluong.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label7.Location = new Point(54, 356);
            label7.Name = "label7";
            label7.Size = new Size(119, 30);
            label7.TabIndex = 9;
            label7.Text = "Số Lượng :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label6.Location = new Point(764, 560);
            label6.Name = "label6";
            label6.Size = new Size(104, 30);
            label6.TabIndex = 8;
            label6.Text = "Ghi Chú :";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(903, 556);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(387, 138);
            txtGhiChu.TabIndex = 7;
            // 
            // txtTenHang
            // 
            txtTenHang.Location = new Point(227, 168);
            txtTenHang.Name = "txtTenHang";
            txtTenHang.Size = new Size(372, 31);
            txtTenHang.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label4.Location = new Point(54, 169);
            label4.Name = "label4";
            label4.Size = new Size(118, 30);
            label4.TabIndex = 3;
            label4.Text = "Tên Hàng :";
            // 
            // txtMaHang
            // 
            txtMaHang.Location = new Point(227, 62);
            txtMaHang.Name = "txtMaHang";
            txtMaHang.Size = new Size(372, 31);
            txtMaHang.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 84);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label2.Location = new Point(55, 60);
            label2.Name = "label2";
            label2.Size = new Size(114, 30);
            label2.TabIndex = 0;
            label2.Text = "Mã Hàng :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 26F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(487, 21);
            label1.Name = "label1";
            label1.Size = new Size(641, 70);
            label1.TabIndex = 25;
            label1.Text = "DANH MỤC HÀNG HÓA";
            // 
            // btnBoQua
            // 
            btnBoQua.Location = new Point(1041, 1198);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(143, 51);
            btnBoQua.TabIndex = 31;
            btnBoQua.Text = "Bỏ Qua";
            btnBoQua.UseVisualStyleBackColor = true;
            btnBoQua.Click += btnBoQua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(233, 1198);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(143, 51);
            btnThem.TabIndex = 27;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(435, 1198);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(143, 51);
            btnLuu.TabIndex = 28;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(839, 1198);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(143, 51);
            btnXoa.TabIndex = 30;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(637, 1198);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(143, 51);
            btnSua.TabIndex = 29;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(168, 862);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(143, 51);
            btnTimKiem.TabIndex = 34;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.Location = new Point(526, 862);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(143, 51);
            btnXuatExcel.TabIndex = 35;
            btnXuatExcel.Text = "Xuất ra Excel";
            btnXuatExcel.UseVisualStyleBackColor = true;
            btnXuatExcel.Click += btnXuatExcel_Click;
            // 
            // btnReload
            // 
            btnReload.Location = new Point(341, 862);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(143, 51);
            btnReload.TabIndex = 36;
            btnReload.Text = "Reload";
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += btnReload_Click;
            // 
            // frmSanPham
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.nenChatLieu;
            ClientSize = new Size(1673, 1274);
            Controls.Add(btnReload);
            Controls.Add(btnXuatExcel);
            Controls.Add(btnTimKiem);
            Controls.Add(dataGridView1);
            Controls.Add(btnThoat);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(btnBoQua);
            Controls.Add(btnThem);
            Controls.Add(btnLuu);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Name = "frmSanPham";
            Text = "Cập nhật danh mục sản phẩm ";
            Load += frmSanPham_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAnh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnThoat;
        private GroupBox groupBox1;
        private RadioButton radNu;
        private RadioButton radNam;
        private MaskedTextBox msbNgaySinh;
        private Label label6;
        private TextBox txtGhiChu;
        private TextBox txtTenHang;
        private Label label4;
        private TextBox txtMaHang;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnBoQua;
        private Button btnThem;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnTimKiem;
        private Button btnXuatExcel;
        private Label label10;
        private TextBox txtDongiaban;
        private Label label9;
        private TextBox txtDongianhap;
        private Label label8;
        private TextBox txtSoluong;
        private Label label7;
        private Button btnChatLieu;
        private ComboBox cboMachatlieu;
        private Button btnOpen;
        private PictureBox picAnh;
        private Button btnReload;
    }
}