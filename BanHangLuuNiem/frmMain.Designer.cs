namespace BanHangLuuNiem
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Label label2;
            menuStrip1 = new MenuStrip();
            mnuDanhmuc = new ToolStripMenuItem();
            mnuChatLieu = new ToolStripMenuItem();
            mnuNhanVien = new ToolStripMenuItem();
            mnuKhacHang = new ToolStripMenuItem();
            mnuHangHoa = new ToolStripMenuItem();
            mnuHoaDon = new ToolStripMenuItem();
            mnuHDBan = new ToolStripMenuItem();
            mnuTimkiem = new ToolStripMenuItem();
            tìmKiếmToolStripMenuItem = new ToolStripMenuItem();
            mnuBaocao = new ToolStripMenuItem();
            mnuBaoCaoDoanhThu = new ToolStripMenuItem();
            trợGiúpToolStripMenuItem = new ToolStripMenuItem();
            mnuThoat = new ToolStripMenuItem();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label1 = new Label();
            label2 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(85, 285);
            label2.Name = "label2";
            label2.Size = new Size(727, 96);
            label2.TabIndex = 2;
            label2.Text = "Bán Hàng Lưu Niệm";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuDanhmuc, mnuHoaDon, mnuTimkiem, mnuBaocao, trợGiúpToolStripMenuItem, mnuThoat });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1505, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuDanhmuc
            // 
            mnuDanhmuc.DropDownItems.AddRange(new ToolStripItem[] { mnuChatLieu, mnuNhanVien, mnuKhacHang, mnuHangHoa });
            mnuDanhmuc.Name = "mnuDanhmuc";
            mnuDanhmuc.Size = new Size(109, 29);
            mnuDanhmuc.Text = "Danh mục";
            // 
            // mnuChatLieu
            // 
            mnuChatLieu.Name = "mnuChatLieu";
            mnuChatLieu.Size = new Size(206, 34);
            mnuChatLieu.Text = "Chất liệu";
            mnuChatLieu.Click += mnuChatLieu_Click;
            // 
            // mnuNhanVien
            // 
            mnuNhanVien.Name = "mnuNhanVien";
            mnuNhanVien.Size = new Size(206, 34);
            mnuNhanVien.Text = "Nhân viên";
            mnuNhanVien.Click += mnuNhanVien_Click;
            // 
            // mnuKhacHang
            // 
            mnuKhacHang.Name = "mnuKhacHang";
            mnuKhacHang.Size = new Size(206, 34);
            mnuKhacHang.Text = "Khách hàng";
            mnuKhacHang.Click += mnuKhachHang_Click;
            // 
            // mnuHangHoa
            // 
            mnuHangHoa.Name = "mnuHangHoa";
            mnuHangHoa.Size = new Size(206, 34);
            mnuHangHoa.Text = "Hàng hóa";
            mnuHangHoa.Click += mnuHangHoa_Click;
            // 
            // mnuHoaDon
            // 
            mnuHoaDon.DropDownItems.AddRange(new ToolStripItem[] { mnuHDBan });
            mnuHoaDon.Name = "mnuHoaDon";
            mnuHoaDon.Size = new Size(98, 29);
            mnuHoaDon.Text = "Hóa đơn";
            mnuHoaDon.Click += mnuHDBan_Click;
            // 
            // mnuHDBan
            // 
            mnuHDBan.Name = "mnuHDBan";
            mnuHDBan.Size = new Size(184, 34);
            mnuHDBan.Text = "Hóa đơn";
            // 
            // mnuTimkiem
            // 
            mnuTimkiem.DropDownItems.AddRange(new ToolStripItem[] { tìmKiếmToolStripMenuItem });
            mnuTimkiem.Name = "mnuTimkiem";
            mnuTimkiem.Size = new Size(100, 29);
            mnuTimkiem.Text = "Tìm kiếm";
            // 
            // tìmKiếmToolStripMenuItem
            // 
            tìmKiếmToolStripMenuItem.Name = "tìmKiếmToolStripMenuItem";
            tìmKiếmToolStripMenuItem.Size = new Size(187, 34);
            tìmKiếmToolStripMenuItem.Text = "Tìm Kiếm";
            // 
            // mnuBaocao
            // 
            mnuBaocao.DropDownItems.AddRange(new ToolStripItem[] { mnuBaoCaoDoanhThu });
            mnuBaocao.Name = "mnuBaocao";
            mnuBaocao.Size = new Size(91, 29);
            mnuBaocao.Text = "Báo cáo";
            // 
            // mnuBaoCaoDoanhThu
            // 
            mnuBaoCaoDoanhThu.Name = "mnuBaoCaoDoanhThu";
            mnuBaoCaoDoanhThu.Size = new Size(201, 34);
            mnuBaoCaoDoanhThu.Text = "Doanh Thu";
            mnuBaoCaoDoanhThu.Click += mnuBaoCaoDoanhThu_Click;
            // 
            // trợGiúpToolStripMenuItem
            // 
            trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            trợGiúpToolStripMenuItem.Size = new Size(93, 29);
            trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // mnuThoat
            // 
            mnuThoat.Name = "mnuThoat";
            mnuThoat.Size = new Size(73, 29);
            mnuThoat.Text = "Thoát";
            mnuThoat.Click += mnuThoat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(171, 210);
            label1.Name = "label1";
            label1.Size = new Size(511, 65);
            label1.TabIndex = 1;
            label1.Text = "Chương trình quản lý";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.main1;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1505, 866);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            Text = "Chương trình quản lý bán hàng";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuDanhmuc;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ToolStripMenuItem mnuChatLieu;
        private ToolStripMenuItem mnuNhanVien;
        private ToolStripMenuItem mnuKhacHang;
        private ToolStripMenuItem mnuHangHoa;
        private ToolStripMenuItem mnuHoaDon;
        private ToolStripMenuItem mnuTimkiem;
        private ToolStripMenuItem mnuBaocao;
        private ToolStripMenuItem trợGiúpToolStripMenuItem;
        private ToolStripMenuItem mnuThoat;
        private ToolStripMenuItem mnuHDBan;
        private ToolStripMenuItem tìmKiếmToolStripMenuItem;
        private ToolStripMenuItem mnuBaoCaoDoanhThu;
        private Label label1;
    }
}
