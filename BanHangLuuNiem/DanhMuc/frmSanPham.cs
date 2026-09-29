using BanHangLuuNiem.Classes;
using System.Data;

namespace BanHangLuuNiem.DanhMuc
{
    public partial class frmSanPham : Form
    {
        DataProcessor dtBase = new DataProcessor();
        private bool cothem = true;
        string fileAnh = ""; // Biến lưu đường dẫn ảnh chọn

        public frmSanPham()
        {
            InitializeComponent();
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadComboBoxChatLieu();
            ResetValue();
        }

        // 1. Hàm load danh sách hàng hóa lên DataGridView
        private void LoadData()
        {
            DataTable dtHang = dtBase.ReadData("SELECT * FROM tblHang");
            dataGridView1.DataSource = dtHang;

            dataGridView1.Columns[0].HeaderText = "Mã hàng";
            dataGridView1.Columns[1].HeaderText = "Tên hàng";
            dataGridView1.Columns[2].HeaderText = "Mã CL";
            dataGridView1.Columns[3].HeaderText = "Số lượng";
            dataGridView1.Columns[4].HeaderText = "Giá nhập";
            dataGridView1.Columns[5].HeaderText = "Giá bán";
            dataGridView1.Columns[6].HeaderText = "File ảnh";
            dataGridView1.Columns[7].HeaderText = "Ghi chú";

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // 2. Đổ dữ liệu chất liệu vào ComboBox
        private void LoadComboBoxChatLieu()
        {
            string sql = "SELECT * FROM tblChatlieu";
            Function.FillCombo(sql, cboMachatlieu, "MaChatLieu", "TenChatLieu");
            cboMachatlieu.SelectedIndex = -1;
        }

        // 3. Sự kiện Click chọn dòng trên DataGridView
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
                txtMaHang.Text = row.Cells["MaHang"].Value.ToString();
                txtTenHang.Text = row.Cells["Tenhang"].Value.ToString();
                cboMachatlieu.SelectedValue = row.Cells["Machatlieu"].Value.ToString();
                txtSoluong.Text = row.Cells["Soluong"].Value.ToString();
                txtDongianhap.Text = row.Cells["Dongianhap"].Value.ToString();
                txtDongiaban.Text = row.Cells["Dongiaban"].Value.ToString();
                txtGhiChu.Text = row.Cells["GhiChu"].Value.ToString();

                // Xử lý hiển thị hình ảnh sản phẩm
                // Kiểm tra nếu cột ảnh tồn tại và có dữ liệu
                if (row.Cells["Anh"].Value != null && row.Cells["Anh"].Value != DBNull.Value)
                {
                    string tenFileAnh = row.Cells["Anh"].Value.ToString().Trim();
                    string duongDanThuMuc = Path.Combine(Application.StartupPath, "Images\\Hang\\");
                    string duongDanFileAnh = Path.Combine(duongDanThuMuc, tenFileAnh);

                    if (!string.IsNullOrEmpty(tenFileAnh) && File.Exists(duongDanFileAnh))
                    {
                        using (FileStream fs = new FileStream(duongDanFileAnh, FileMode.Open, FileAccess.Read))
                        {
                            picAnh.Image = Image.FromStream(fs);
                        }
                        fileAnh = duongDanFileAnh;
                    }
                    else
                    {
                        picAnh.Image = null;
                        fileAnh = "";
                    }
                }
                else
                {
                    picAnh.Image = null;
                    fileAnh = "";
                }

                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        // 4. Nút chọn Ảnh (btnOpen)
        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";
            dlgOpen.Title = "Chọn hình ảnh sản phẩm";

            // Tạo sẵn đường dẫn trỏ tới thư mục Images\Hang trong thư mục chạy của project
            string folderPath = Path.Combine(Application.StartupPath, "Images\\Hang");

            // Nếu chưa có thư mục thì tự động tạo mới để tránh lỗi không tìm thấy đường dẫn
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            dlgOpen.InitialDirectory = folderPath;

            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                fileAnh = dlgOpen.FileName;

                // Load ảnh lên PictureBox an toàn tránh khóa file
                using (FileStream fs = new FileStream(fileAnh, FileMode.Open, FileAccess.Read))
                {
                    picAnh.Image = Image.FromStream(fs);
                }
            }
        }

        // 5. Làm mới / Xóa trống
        private void ResetValue()
        {
            txtMaHang.Text = "";
            txtTenHang.Text = "";
            cboMachatlieu.SelectedIndex = -1;
            txtSoluong.Text = "";
            txtDongianhap.Text = "";
            txtDongiaban.Text = "";
            txtGhiChu.Text = "";
            picAnh.Image = null;
            fileAnh = "";

            txtMaHang.Enabled = false;
            txtTenHang.Enabled = false;
            cboMachatlieu.Enabled = false;
            txtSoluong.Enabled = false;
            txtDongianhap.Enabled = false;
            txtDongiaban.Enabled = false;
            txtGhiChu.Enabled = false;
            btnOpen.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
        }

        // 6. Nút THÊM MỚI
        private void btnThem_Click(object sender, EventArgs e)
        {
            cothem = true;
            ResetValue();

            txtMaHang.Enabled = true;
            txtTenHang.Enabled = true;
            cboMachatlieu.Enabled = true;
            txtSoluong.Enabled = true;
            txtDongianhap.Enabled = true;
            txtDongiaban.Enabled = true;
            txtGhiChu.Enabled = true;
            btnOpen.Enabled = true;
            txtMaHang.Focus();

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
        }

        // 7. Nút SỬA
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            cothem = false;
            txtMaHang.Enabled = false; // Không cho sửa mã chính
            txtTenHang.Enabled = true;
            cboMachatlieu.Enabled = true;
            txtSoluong.Enabled = true;
            txtDongianhap.Enabled = true;
            txtDongiaban.Enabled = true;
            txtGhiChu.Enabled = true;
            btnOpen.Enabled = true;
            txtTenHang.Focus();

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
        }

        // 8. Nút LƯU
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaHang.Focus();
                return;
            }
            if (txtTenHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenHang.Focus();
                return;
            }
            if (cboMachatlieu.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn phải chọn chất liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMachatlieu.Focus();
                return;
            }

            // Xử lý lưu tên file ảnh vào thư mục Images\Hang\
            string fileName = "";
            if (!string.IsNullOrEmpty(fileAnh))
            {
                FileInfo fi = new FileInfo(fileAnh);
                fileName = fi.Name; // Lấy tên file ảnh (VD: H01.jpg)
                string destinationFolder = Application.StartupPath.Substring(0, Application.StartupPath.IndexOf("bin")) + "Images\\Hang\\";

                if (!Directory.Exists(destinationFolder))
                {
                    Directory.CreateDirectory(destinationFolder);
                }

                // Copy ảnh vào thư mục dự án nếu chưa có
                string destFile = Path.Combine(destinationFolder, fileName);
                if (!File.Exists(destFile))
                {
                    File.Copy(fileAnh, destFile, true);
                }
            }

            // Xử lý giá trị số
            string soluong = string.IsNullOrEmpty(txtSoluong.Text) ? "0" : txtSoluong.Text;
            string gianhap = string.IsNullOrEmpty(txtDongianhap.Text) ? "0" : txtDongianhap.Text;
            string giaban = string.IsNullOrEmpty(txtDongiaban.Text) ? "0" : txtDongiaban.Text;

            if (cothem == true)
            {
                string sqlCheck = "SELECT MaHang FROM tblHang WHERE MaHang = N'" + txtMaHang.Text.Trim() + "'";
                if (Function.CheckKey(sqlCheck))
                {
                    MessageBox.Show("Mã hàng này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaHang.Focus();
                    return;
                }

                string sqlInsert = "INSERT INTO tblHang(MaHang, Tenhang, Machatlieu, Soluong, Dongianhap, Dongiaban, Anh, GhiChu) VALUES(" +
                                   "N'" + txtMaHang.Text.Trim() + "', " +
                                   "N'" + txtTenHang.Text.Trim() + "', " +
                                   "N'" + cboMachatlieu.SelectedValue.ToString() + "', " +
                                   soluong + ", " + gianhap + ", " + giaban + ", " +
                                   "N'" + fileName + "', " +
                                   "N'" + txtGhiChu.Text.Trim() + "')";
                dtBase.ChangeData(sqlInsert);
            }
            else
            {
                // Nếu sửa mà không chọn ảnh mới thì giữ nguyên ảnh cũ trên database
                string sqlUpdate = "";
                if (string.IsNullOrEmpty(fileName))
                {
                    sqlUpdate = "UPDATE tblHang SET " +
                                "Tenhang = N'" + txtTenHang.Text.Trim() + "', " +
                                "Machatlieu = N'" + cboMachatlieu.SelectedValue.ToString() + "', " +
                                "Soluong = " + soluong + ", " +
                                "Dongianhap = " + gianhap + ", " +
                                "Dongiaban = " + giaban + ", " +
                                "GhiChu = N'" + txtGhiChu.Text.Trim() + "' " +
                                "WHERE MaHang = N'" + txtMaHang.Text.Trim() + "'";
                }
                else
                {
                    sqlUpdate = "UPDATE tblHang SET " +
                                "Tenhang = N'" + txtTenHang.Text.Trim() + "', " +
                                "Machatlieu = N'" + cboMachatlieu.SelectedValue.ToString() + "', " +
                                "Soluong = " + soluong + ", " +
                                "Dongianhap = " + gianhap + ", " +
                                "Dongiaban = " + giaban + ", " +
                                "Anh = N'" + fileName + "', " +
                                "GhiChu = N'" + txtGhiChu.Text.Trim() + "' " +
                                "WHERE MaHang = N'" + txtMaHang.Text.Trim() + "'";
                }
                dtBase.ChangeData(sqlUpdate);
            }

            LoadData();
            ResetValue();
        }

        // 9. Nút XÓA
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Bạn có muốn xóa mặt hàng này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sqlDelete = "DELETE FROM tblHang WHERE MaHang = N'" + txtMaHang.Text.Trim() + "'";
                dtBase.ChangeData(sqlDelete);
                LoadData();
                ResetValue();
            }
        }

        // 10. Nút BỎ QUA
        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValue();
        }

        // 11. Nút THOÁT
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChatLieu_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem các ô nhập liệu có đang bị khóa không. 
            // Nếu đang khóa (Enabled = false), ta mở khóa ra cho người dùng nhập điều kiện tìm kiếm
            if (txtMaHang.Enabled == false)
            {
                ResetValue(); // Xóa trống các ô trước đó

                // Mở khóa các ô phục vụ cho việc tìm kiếm
                txtMaHang.Enabled = true;
                txtTenHang.Enabled = true;
                cboMachatlieu.Enabled = true;
                txtMaHang.Focus();

                MessageBox.Show("Hãy nhập thông tin cần tìm kiếm vào các ô, sau đó bấm Tìm kiếm lần nữa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Nếu các ô đã được mở khóa, tiến hành lấy điều kiện và lọc dữ liệu
            if (txtMaHang.Text.Trim().Length == 0 && txtTenHang.Text.Trim().Length == 0 && cboMachatlieu.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn phải nhập ít nhất một điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaHang.Focus();
                return;
            }

            string sql = "SELECT * FROM tblHang WHERE 1=1";

            if (txtMaHang.Text.Trim().Length > 0)
            {
                sql += " AND MaHang LIKE N'%" + txtMaHang.Text.Trim() + "%'";
            }
            if (txtTenHang.Text.Trim().Length > 0)
            {
                sql += " AND Tenhang LIKE N'%" + txtTenHang.Text.Trim() + "%'";
            }
            if (cboMachatlieu.SelectedIndex != -1)
            {
                sql += " AND Machatlieu = N'" + cboMachatlieu.SelectedValue.ToString() + "'";
            }

            DataTable dtHang = dtBase.ReadData(sql);
            dataGridView1.DataSource = dtHang;

            if (dtHang.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Đã tìm thấy " + dtHang.Rows.Count + " bản ghi thỏa mãn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
            ResetValue();
        }
    }
}