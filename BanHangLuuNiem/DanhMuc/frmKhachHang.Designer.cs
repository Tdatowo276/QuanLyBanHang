namespace BanHangLuuNiem.DanhMuc
{
    partial class frmKhachHang
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            label6 = new Label();
            txtDiachi = new TextBox();
            label5 = new Label();
            txtDienthoai = new TextBox();
            txtTenKhach = new TextBox();
            label4 = new Label();
            txtMaKhach = new TextBox();
            label3 = new Label();
            label2 = new Label();
            btnThoat = new Button();
            btnBoQua = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnLuu = new Button();
            btnThem = new Button();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 26F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(206, 40);
            label1.Name = "label1";
            label1.Size = new Size(853, 70);
            label1.TabIndex = 0;
            label1.Text = "DANH SÁCH CÁC KHÁCH HÀNG";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtDiachi);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtDienthoai);
            groupBox1.Controls.Add(txtTenKhach);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtMaKhach);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(161, 138);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(924, 268);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label6.Location = new Point(457, 59);
            label6.Name = "label6";
            label6.Size = new Size(102, 30);
            label6.TabIndex = 8;
            label6.Text = "Địa Chỉ : ";
            // 
            // txtDiachi
            // 
            txtDiachi.Location = new Point(604, 59);
            txtDiachi.Multiline = true;
            txtDiachi.Name = "txtDiachi";
            txtDiachi.Size = new Size(218, 86);
            txtDiachi.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label5.Location = new Point(457, 169);
            label5.Name = "label5";
            label5.Size = new Size(132, 30);
            label5.TabIndex = 6;
            label5.Text = "Điện Thoại :";
            // 
            // txtDienthoai
            // 
            txtDienthoai.Location = new Point(604, 169);
            txtDienthoai.Name = "txtDienthoai";
            txtDienthoai.Size = new Size(218, 31);
            txtDienthoai.TabIndex = 5;
            // 
            // txtTenKhach
            // 
            txtTenKhach.Location = new Point(188, 168);
            txtTenKhach.Name = "txtTenKhach";
            txtTenKhach.Size = new Size(218, 31);
            txtTenKhach.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label4.Location = new Point(54, 169);
            label4.Name = "label4";
            label4.Size = new Size(125, 30);
            label4.TabIndex = 3;
            label4.Text = "Tên Khách :";
            // 
            // txtMaKhach
            // 
            txtMaKhach.Location = new Point(188, 60);
            txtMaKhach.Name = "txtMaKhach";
            txtMaKhach.Size = new Size(218, 31);
            txtMaKhach.TabIndex = 2;
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
            label2.Size = new Size(127, 30);
            label2.TabIndex = 0;
            label2.Text = "Mã Khách : ";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(1073, 796);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(143, 51);
            btnThoat.TabIndex = 14;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnBoQua
            // 
            btnBoQua.Location = new Point(871, 796);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(143, 51);
            btnBoQua.TabIndex = 13;
            btnBoQua.Text = "Bỏ Qua";
            btnBoQua.UseVisualStyleBackColor = true;
            btnBoQua.Click += btnBoQua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(669, 796);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(143, 51);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(467, 796);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(143, 51);
            btnSua.TabIndex = 11;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(265, 796);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(143, 51);
            btnLuu.TabIndex = 10;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(63, 796);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(143, 51);
            btnThem.TabIndex = 9;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(132, 429);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1002, 318);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellContentClick += dataGridView1_CellClick;
            // 
            // frmKhachHang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.nenChatLieu;
            ClientSize = new Size(1285, 949);
            Controls.Add(dataGridView1);
            Controls.Add(btnThoat);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(btnBoQua);
            Controls.Add(btnThem);
            Controls.Add(btnLuu);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Name = "frmKhachHang";
            Text = "Cập nhật danh mục khách hàng";
            Load += frmKhachHang_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label5;
        private TextBox txtDienthoai;
        private TextBox txtTenKhach;
        private Label label4;
        private TextBox txtMaKhach;
        private Label label3;
        private Label label2;
        private Label label6;
        private TextBox txtDiachi;
        private Button btnThoat;
        private Button btnBoQua;
        private Button btnXoa;
        private Button btnSua;
        private Button btnLuu;
        private Button btnThem;
        private DataGridView dataGridView1;
    }
}