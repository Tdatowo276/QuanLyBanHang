namespace BanHangLuuNiem
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        // 1. Menu Danh mục - Chất liệu
        private void mnuChatLieu_Click(object sender, EventArgs e)
        {
            DanhMuc.frmChatLieu frm = new DanhMuc.frmChatLieu();
            frm.ShowDialog();
        }

        // 2. Menu Danh mục - Nhân viên
        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            DanhMuc.frmNhanVien frm = new DanhMuc.frmNhanVien();
            frm.ShowDialog();
        }

        // 3. Menu Danh mục - Khách hàng
        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            DanhMuc.frmKhachHang frm = new DanhMuc.frmKhachHang();
            frm.ShowDialog();
        }

        // 4. Menu Danh mục - Hàng hóa
        private void mnuHangHoa_Click(object sender, EventArgs e)
        {
            DanhMuc.frmSanPham frm = new DanhMuc.frmSanPham();
            frm.ShowDialog();
        }

        // 5. Menu Hóa đơn - Hóa đơn bán
        private void mnuHDBan_Click(object sender, EventArgs e)
        {
            HoaDon.frmHDBan frm = new HoaDon.frmHDBan();
            frm.ShowDialog();
        }

        // 6. Menu Báo cáo - Doanh thu
        private void mnuBaoCaoDoanhThu_Click(object sender, EventArgs e)
        {
            ThongKe.frmDoanhThu frm = new ThongKe.frmDoanhThu();
            frm.ShowDialog();
        }

        // 7. Menu Thoát
        private void mnuThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }
    }
}
