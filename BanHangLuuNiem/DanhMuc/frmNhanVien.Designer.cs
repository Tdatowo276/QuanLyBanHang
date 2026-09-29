namespace BanHangLuuNiem.DanhMuc
{
    partial class frmNhanVien
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
            radNu = new RadioButton();
            radNam = new RadioButton();
            msbNgaySinh = new MaskedTextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            txtDiachi = new TextBox();
            label5 = new Label();
            txtDienthoai = new TextBox();
            txtTenNhanVien = new TextBox();
            label4 = new Label();
            txtMaNhanVien = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnBoQua = new Button();
            btnThem = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(167, 578);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1302, 374);
            dataGridView1.TabIndex = 24;
            dataGridView1.CellContentClick += dataGridView1_CellClick;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(1242, 994);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(143, 51);
            btnThoat.TabIndex = 23;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(radNu);
            groupBox1.Controls.Add(radNam);
            groupBox1.Controls.Add(msbNgaySinh);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtDiachi);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtDienthoai);
            groupBox1.Controls.Add(txtTenNhanVien);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtMaNhanVien);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(167, 133);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1302, 403);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            // 
            // radNu
            // 
            radNu.AutoSize = true;
            radNu.Location = new Point(373, 326);
            radNu.Name = "radNu";
            radNu.Size = new Size(61, 29);
            radNu.TabIndex = 13;
            radNu.TabStop = true;
            radNu.Text = "Nữ";
            radNu.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            radNam.AutoSize = true;
            radNam.Location = new Point(240, 326);
            radNam.Name = "radNam";
            radNam.Size = new Size(75, 29);
            radNam.TabIndex = 12;
            radNam.TabStop = true;
            radNam.Text = "Nam";
            radNam.UseVisualStyleBackColor = true;
            // 
            // msbNgaySinh
            // 
            msbNgaySinh.Location = new Point(227, 251);
            msbNgaySinh.Mask = "00/00/0000";
            msbNgaySinh.Name = "msbNgaySinh";
            msbNgaySinh.Size = new Size(221, 31);
            msbNgaySinh.TabIndex = 11;
            msbNgaySinh.ValidatingType = typeof(DateTime);
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label8.Location = new Point(57, 324);
            label8.Name = "label8";
            label8.Size = new Size(114, 30);
            label8.TabIndex = 10;
            label8.Text = "Giới Tính :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label7.Location = new Point(54, 252);
            label7.Name = "label7";
            label7.Size = new Size(126, 30);
            label7.TabIndex = 9;
            label7.Text = "Ngày Sinh :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label6.Location = new Point(749, 61);
            label6.Name = "label6";
            label6.Size = new Size(102, 30);
            label6.TabIndex = 8;
            label6.Text = "Địa Chỉ : ";
            // 
            // txtDiachi
            // 
            txtDiachi.Location = new Point(896, 61);
            txtDiachi.Multiline = true;
            txtDiachi.Name = "txtDiachi";
            txtDiachi.Size = new Size(333, 138);
            txtDiachi.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label5.Location = new Point(749, 253);
            label5.Name = "label5";
            label5.Size = new Size(132, 30);
            label5.TabIndex = 6;
            label5.Text = "Điện Thoại :";
            // 
            // txtDienthoai
            // 
            txtDienthoai.Location = new Point(896, 253);
            txtDienthoai.Name = "txtDienthoai";
            txtDienthoai.Size = new Size(333, 31);
            txtDienthoai.TabIndex = 5;
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.Location = new Point(227, 168);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.Size = new Size(372, 31);
            txtTenNhanVien.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label4.Location = new Point(54, 169);
            label4.Name = "label4";
            label4.Size = new Size(170, 30);
            label4.TabIndex = 3;
            label4.Text = "Tên Nhân Viên :";
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Location = new Point(227, 62);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(372, 31);
            txtMaNhanVien.TabIndex = 2;
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
            label2.Size = new Size(166, 30);
            label2.TabIndex = 0;
            label2.Text = "Mã Nhân Viên :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 26F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(407, 35);
            label1.Name = "label1";
            label1.Size = new Size(793, 70);
            label1.TabIndex = 16;
            label1.Text = "DANH SÁCH CÁC NHÂN VIÊN";
            // 
            // btnBoQua
            // 
            btnBoQua.Location = new Point(1040, 994);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(143, 51);
            btnBoQua.TabIndex = 22;
            btnBoQua.Text = "Bỏ Qua";
            btnBoQua.UseVisualStyleBackColor = true;
            btnBoQua.Click += btnBoQua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(232, 994);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(143, 51);
            btnThem.TabIndex = 18;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(434, 994);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(143, 51);
            btnLuu.TabIndex = 19;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(838, 994);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(143, 51);
            btnXoa.TabIndex = 21;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(636, 994);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(143, 51);
            btnSua.TabIndex = 20;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.nenChatLieu;
            ClientSize = new Size(1639, 1118);
            Controls.Add(dataGridView1);
            Controls.Add(btnThoat);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(btnBoQua);
            Controls.Add(btnThem);
            Controls.Add(btnLuu);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Name = "frmNhanVien";
            Text = "Cập nhật danh mục Nhân viên";
            Load += frmNhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnThoat;
        private GroupBox groupBox1;
        private Label label6;
        private TextBox txtDiachi;
        private Label label5;
        private TextBox txtDienthoai;
        private TextBox txtTenNhanVien;
        private Label label4;
        private TextBox txtMaNhanVien;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnBoQua;
        private Button btnThem;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Label label8;
        private Label label7;
        private RadioButton radNu;
        private RadioButton radNam;
        private MaskedTextBox msbNgaySinh;
    }
}