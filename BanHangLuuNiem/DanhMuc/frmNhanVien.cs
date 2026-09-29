using BanHangLuuNiem.Classes;
using System.Data;

namespace BanHangLuuNiem.DanhMuc
{
    public partial class frmNhanVien : Form
    {
        DataProcessor dtBase = new DataProcessor();
        private bool cothem = true; // Biến đánh dấu trạng thái Thêm mới hay Sửa

        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
            ResetValue();
        }

        // Hàm load dữ liệu từ bảng tblNhanvien lên DataGridView
        private void LoadData()
        {
            DataTable dtNhanVien = dtBase.ReadData("SELECT * FROM tblNhanvien");
            dataGridView1.DataSource = dtNhanVien;

            // Đặt tên tiêu đề các cột
            dataGridView1.Columns[0].HeaderText = "Mã NV";
            dataGridView1.Columns[1].HeaderText = "Tên NV";
            dataGridView1.Columns[2].HeaderText = "Giới tính";
            dataGridView1.Columns[3].HeaderText = "Ngày sinh";
            dataGridView1.Columns[4].HeaderText = "Địa chỉ";
            dataGridView1.Columns[5].HeaderText = "Điện thoại";

            dataGridView1.Columns[0].Width = 90;
            dataGridView1.Columns[1].Width = 140;
            dataGridView1.Columns[2].Width = 80;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 150;
            dataGridView1.Columns[5].Width = 100;

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
                txtMaNhanVien.Text = row.Cells["Manhavien"].Value.ToString();
                txtTenNhanVien.Text = row.Cells["Tennnhanvien"].Value.ToString();

                // Xử lý Giới tính (Nam / Nữ)
                string gioitinh = row.Cells["Gioitinh"].Value.ToString();
                if (gioitinh == "Nam")
                    radNam.Checked = true;
                else
                    radNu.Checked = true;

                // Xử lý Ngày sinh
                if (row.Cells["Ngaysinh"].Value != DBNull.Value)
                {
                    DateTime dt = Convert.ToDateTime(row.Cells["Ngaysinh"].Value);
                    msbNgaySinh.Text = dt.ToString("dd/MM/yyyy");
                }
                else
                {
                    msbNgaySinh.Text = "";
                }

                txtDiachi.Text = row.Cells["Diachi"].Value.ToString();
                txtDienthoai.Text = row.Cells["Dienthoai"].Value.ToString();

                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        // Làm mới / Xóa trống các ô nhập liệu
        private void ResetValue()
        {
            txtMaNhanVien.Text = "";
            txtTenNhanVien.Text = "";
            radNam.Checked = false;
            radNu.Checked = false;
            msbNgaySinh.Text = "";
            txtDiachi.Text = "";
            txtDienthoai.Text = "";

            txtMaNhanVien.Enabled = false;
            txtTenNhanVien.Enabled = false;
            radNam.Enabled = false;
            radNu.Enabled = false;
            msbNgaySinh.Enabled = false;
            txtDiachi.Enabled = false;
            txtDienthoai.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
        }

        // Nút THÊM MỚI
        private void btnThem_Click(object sender, EventArgs e)
        {
            cothem = true;
            ResetValue();

            txtMaNhanVien.Enabled = true;
            txtTenNhanVien.Enabled = true;
            radNam.Enabled = true;
            radNu.Enabled = true;
            msbNgaySinh.Enabled = true;
            txtDiachi.Enabled = true;
            txtDienthoai.Enabled = true;
            txtMaNhanVien.Focus();

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
        }

        // Nút SỬA
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaNhanVien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            cothem = false;
            txtMaNhanVien.Enabled = false; // Không cho sửa mã chính
            txtTenNhanVien.Enabled = true;
            radNam.Enabled = true;
            radNu.Enabled = true;
            msbNgaySinh.Enabled = true;
            txtDiachi.Enabled = true;
            txtDienthoai.Enabled = true;
            txtTenNhanVien.Focus();

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
        }

        // Nút LƯU (Xử lý Thêm hoặc Sửa)
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaNhanVien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNhanVien.Focus();
                return;
            }
            if (txtTenNhanVien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNhanVien.Focus();
                return;
            }

            string gioitinh = radNam.Checked ? "Nam" : "Nữ";
            string ngaysinh = Function.ConvertDateTime(msbNgaySinh.Text);

            // TRƯỜNG HỢP THÊM MỚI
            if (cothem == true)
            {
                string sqlCheck = "SELECT Manhavien FROM tblNhanvien WHERE Manhavien = N'" + txtMaNhanVien.Text.Trim() + "'";
                if (Function.CheckKey(sqlCheck))
                {
                    MessageBox.Show("Mã nhân viên này đã tồn tại, vui lòng nhập mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaNhanVien.Focus();
                    return;
                }

                string sqlInsert = "INSERT INTO tblNhanvien(Manhavien, Tennnhanvien, Gioitinh, Ngaysinh, Diachi, Dienthoai) VALUES(" +
                                   "N'" + txtMaNhanVien.Text.Trim() + "', " +
                                   "N'" + txtTenNhanVien.Text.Trim() + "', " +
                                   "N'" + gioitinh + "', " +
                                   "'" + ngaysinh + "', " +
                                   "N'" + txtDiachi.Text.Trim() + "', " +
                                   "'" + txtDienthoai.Text.Trim() + "')";
                dtBase.ChangeData(sqlInsert);
            }
            // TRƯỜNG HỢP SỬA
            else
            {
                string sqlUpdate = "UPDATE tblNhanvien SET " +
                                   "Tennnhanvien = N'" + txtTenNhanVien.Text.Trim() + "', " +
                                   "Gioitinh = N'" + gioitinh + "', " +
                                   "Ngaysinh = '" + ngaysinh + "', " +
                                   "Diachi = N'" + txtDiachi.Text.Trim() + "', " +
                                   "Dienthoai = '" + txtDienthoai.Text.Trim() + "' " +
                                   "WHERE Manhavien = N'" + txtMaNhanVien.Text.Trim() + "'";
                dtBase.ChangeData(sqlUpdate);
            }

            LoadData();
            ResetValue();
        }

        // Nút XÓA
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNhanVien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sqlDelete = "DELETE FROM tblNhanvien WHERE Manhavien = N'" + txtMaNhanVien.Text.Trim() + "'";
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