using BanHangLuuNiem.Classes;
using System.Data;

namespace BanHangLuuNiem.DanhMuc
{
    public partial class frmKhachHang : Form
    {
        DataProcessor dtBase = new DataProcessor();
        private bool cothem = true; // Biến đánh dấu trạng thái Thêm mới hay Sửa

        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
            ResetValue();
        }

        // Hàm load dữ liệu từ bảng tblKhach lên DataGridView
        private void LoadData()
        {
            DataTable dtKhach = dtBase.ReadData("SELECT * FROM tblKhach");
            dataGridView1.DataSource = dtKhach;

            // Đặt tên tiêu đề các cột
            dataGridView1.Columns[0].HeaderText = "Mã Khách";
            dataGridView1.Columns[1].HeaderText = "Tên khách";
            dataGridView1.Columns[2].HeaderText = "Địa chỉ";
            dataGridView1.Columns[3].HeaderText = "Điện thoại";

            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].Width = 120;

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Sự kiện khi click chọn một dòng trên DataGridView
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (btnThem.Enabled == false)
                {
                    MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtMaKhach.Text = row.Cells["Makhach"].Value.ToString();
                txtTenKhach.Text = row.Cells["Tenkhach"].Value.ToString();
                txtDiachi.Text = row.Cells["Diachi"].Value.ToString();
                txtDienthoai.Text = row.Cells["Dienthoai"].Value.ToString();

                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        // Làm mới / Xóa trống các ô nhập liệu
        private void ResetValue()
        {
            txtMaKhach.Text = "";
            txtTenKhach.Text = "";
            txtDiachi.Text = "";
            txtDienthoai.Text = "";

            txtMaKhach.Enabled = false;
            txtTenKhach.Enabled = false;
            txtDiachi.Enabled = false;
            txtDienthoai.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
        }

        // Nút THÊM
        private void btnThem_Click(object sender, EventArgs e)
        {
            cothem = true;
            ResetValue();

            txtMaKhach.Enabled = true;
            txtTenKhach.Enabled = true;
            txtDiachi.Enabled = true;
            txtDienthoai.Enabled = true;
            txtMaKhach.Focus();

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
        }

        // Nút SỬA
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaKhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            cothem = false;
            txtMaKhach.Enabled = false; // Không cho sửa mã chính
            txtTenKhach.Enabled = true;
            txtDiachi.Enabled = true;
            txtDienthoai.Enabled = true;
            txtTenKhach.Focus();

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
        }

        // Nút LƯU (Xử lý Thêm hoặc Sửa)
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaKhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã khách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaKhach.Focus();
                return;
            }
            if (txtTenKhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenKhach.Focus();
                return;
            }

            // TRƯỜNG HỢP THÊM MỚI
            if (cothem == true)
            {
                string sqlCheck = "SELECT Makhach FROM tblKhach WHERE Makhach = N'" + txtMaKhach.Text.Trim() + "'";
                if (Function.CheckKey(sqlCheck))
                {
                    MessageBox.Show("Mã khách này đã tồn tại, vui lòng nhập mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaKhach.Focus();
                    return;
                }

                string sqlInsert = "INSERT INTO tblKhach(Makhach, Tenkhach, Diachi, Dienthoai) VALUES(N'" + txtMaKhach.Text.Trim() + "', N'" + txtTenKhach.Text.Trim() + "', N'" + txtDiachi.Text.Trim() + "', '" + txtDienthoai.Text.Trim() + "')";
                dtBase.ChangeData(sqlInsert);
            }
            // TRƯỜNG HỢP SỬA
            else
            {
                string sqlUpdate = "UPDATE tblKhach SET Tenkhach = N'" + txtTenKhach.Text.Trim() + "', Diachi = N'" + txtDiachi.Text.Trim() + "', Dienthoai = '" + txtDienthoai.Text.Trim() + "' WHERE Makhach = N'" + txtMaKhach.Text.Trim() + "'";
                dtBase.ChangeData(sqlUpdate);
            }

            LoadData();
            ResetValue();
        }

        // Nút XÓA
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaKhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sqlDelete = "DELETE FROM tblKhach WHERE Makhach = N'" + txtMaKhach.Text.Trim() + "'";
                dtBase.ChangeData(sqlDelete);
                LoadData();
                ResetValue();
            }
        }

        // Nút BỎ QUA
        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValue();
        }

        // Nút THOÁT
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}