namespace BanHangLuuNiem.DanhMuc
{
    partial class frmChatLieu
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
            txtTenChatLieu = new TextBox();
            label4 = new Label();
            txtMaChatLieu = new TextBox();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            btnThem = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnBoQua = new Button();
            btnThoat = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 28F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(229, 78);
            label1.Name = "label1";
            label1.Size = new Size(788, 74);
            label1.TabIndex = 0;
            label1.Text = "DANH SÁCH CÁC CHẤT LIỆU";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(txtTenChatLieu);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtMaChatLieu);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(133, 186);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(595, 200);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // txtTenChatLieu
            // 
            txtTenChatLieu.Location = new Point(208, 129);
            txtTenChatLieu.Name = "txtTenChatLieu";
            txtTenChatLieu.Size = new Size(297, 31);
            txtTenChatLieu.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 129);
            label4.Name = "label4";
            label4.Size = new Size(124, 25);
            label4.TabIndex = 3;
            label4.Text = "Tên Chất Liệu: ";
            // 
            // txtMaChatLieu
            // 
            txtMaChatLieu.Location = new Point(208, 60);
            txtMaChatLieu.Name = "txtMaChatLieu";
            txtMaChatLieu.Size = new Size(297, 31);
            txtMaChatLieu.TabIndex = 2;
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
            label2.Location = new Point(55, 60);
            label2.Name = "label2";
            label2.Size = new Size(123, 25);
            label2.TabIndex = 0;
            label2.Text = "Mã Chất Liệu :";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(133, 413);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(595, 199);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(941, 186);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(143, 51);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(941, 266);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(143, 51);
            btnLuu.TabIndex = 4;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(941, 346);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(143, 51);
            btnSua.TabIndex = 5;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(941, 426);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(143, 51);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnBoQua
            // 
            btnBoQua.Location = new Point(941, 506);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(143, 51);
            btnBoQua.TabIndex = 7;
            btnBoQua.Text = "Bỏ Qua";
            btnBoQua.UseVisualStyleBackColor = true;
            btnBoQua.Click += btnBoQua_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(941, 586);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(143, 51);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmChatLieu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.nenChatLieu;
            ClientSize = new Size(1244, 711);
            Controls.Add(btnThoat);
            Controls.Add(btnBoQua);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnLuu);
            Controls.Add(btnThem);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "frmChatLieu";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmChatLieu_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtMaChatLieu;
        private Label label3;
        private Label label2;
        private TextBox txtTenChatLieu;
        private Label label4;
        private DataGridView dataGridView1;
        private Button btnThem;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private Button btnBoQua;
        private Button btnThoat;
    }
}