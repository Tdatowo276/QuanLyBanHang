using BanHangLuuNiem.Classes; // Gọi namespace chứa lớp DataProcesser và Function
using System.Data;

namespace BanHangLuuNiem.DanhMuc
{
    public partial class frmChatLieu : Form
    {
        DataProcessor dtBase = new DataProcessor(); // Khởi tạo đối tượng thao tác CSDL
        private bool cothem = true;
        public frmChatLieu()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            // Lấy dữ liệu từ bảng chất liệu
            DataTable dtChatLieu = dtBase.ReadData("SELECT * FROM tblChatlieu");

            // Gán trực tiếp vào DataSource của DataGridView
            dataGridView1.DataSource = dtChatLieu;

            // Đặt lại tên tiêu đề cột hiển thị tiếng Việt cho đẹp
            dataGridView1.Columns[0].HeaderText = "Mã chất liệu";
            dataGridView1.Columns[1].HeaderText = "Tên chất liệu";

            // Chỉnh độ rộng cột
            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].Width = 250;

            // Không cho phép người dùng tự thêm dòng trống cuối bảng
            dataGridView1.AllowUserToAddRows = false;
            // Không cho sửa trực tiếp trên lưới (phải ấn nút Sửa)
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            // Đặt chiều cao mặc định cho một dòng (thường khoảng 22-25 pixel) và chiều cao tiêu đề cột
        }

        private void frmChatLieu_Load(object sender, EventArgs e)
        {
            LoadData(); // Load dữ liệu lên DataGridView khi mở form
            ResetValue(); // Khóa các ô nhập liệu và nút Lưu/Bỏ qua ban đầu
        }



        // Sự kiện khi click chọn một dòng trên DataGridView
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có click vào dòng hợp lệ không (tránh click nhầm vào tiêu đề cột e.RowIndex = -1)
            if (e.RowIndex >= 0)
            {
                // Lấy dòng đang được chọn
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Đưa dữ liệu lên 2 TextBox tương ứng
                txtMaChatLieu.Text = row.Cells["MaChatLieu"].Value.ToString();
                txtTenChatLieu.Text = row.Cells["TenChatLieu"].Value.ToString();

                // Bật nút Sửa và Xóa lên cho phép người dùng thao tác
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        // Làm mới / Xóa trống các ô nhập liệu
        private void ResetValue()
        {
            txtMaChatLieu.Text = "";
            txtTenChatLieu.Text = "";
            txtMaChatLieu.Enabled = false;
            txtTenChatLieu.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
        }

        // Nút THÊM
        private void btnThem_Click(object sender, EventArgs e)
        {
            cothem = true; // Đánh dấu là đang thêm mới

            // Xóa trống các ô nhập liệu
            txtMaChatLieu.Text = "";
            txtTenChatLieu.Text = "";

            // Bật/tắt trạng thái các nút và ô nhập
            txtMaChatLieu.Enabled = true;   // Cho phép nhập mã mới
            txtTenChatLieu.Enabled = true;
            txtMaChatLieu.Focus();

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
        }

        // Nút LƯU (Xử lý cả Thêm mới hoặc Sửa)
        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra ràng buộc nhập dữ liệu
            if (txtMaChatLieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã chất liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaChatLieu.Focus();
                return;
            }
            if (txtTenChatLieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên chất liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenChatLieu.Focus();
                return;
            }

            // TRƯỜNG HỢP 1: THÊM MỚI
            if (cothem == true)
            {
                // Kiểm tra xem mã chất liệu đã tồn tại trong CSDL chưa
                string sqlCheck = "SELECT MaChatLieu FROM tblChatlieu WHERE MaChatLieu = N'" + txtMaChatLieu.Text.Trim() + "'";
                if (Function.CheckKey(sqlCheck))
                {
                    MessageBox.Show("Mã chất liệu này đã có, bạn phải nhập mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaChatLieu.Focus();
                    return;
                }

                // Thực hiện câu lệnh INSERT
                string sqlInsert = "INSERT INTO tblChatlieu(MaChatLieu, TenChatLieu) VALUES(N'" + txtMaChatLieu.Text.Trim() + "', N'" + txtTenChatLieu.Text.Trim() + "')";
                dtBase.ChangeData(sqlInsert);
            }
            // TRƯỜNG HỢP 2: SỬA (Cập nhật tên theo mã)
            else
            {
                string sqlUpdate = "UPDATE tblChatlieu SET TenChatLieu = N'" + txtTenChatLieu.Text.Trim() + "' WHERE MaChatLieu = N'" + txtMaChatLieu.Text.Trim() + "'";
                dtBase.ChangeData(sqlUpdate);
            }

            // Load lại dữ liệu lên DataGridView và reset trạng thái nút bấm
            LoadData();
            ResetValue();
        }

        // Nút SỬA
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaChatLieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            cothem = false; // Đánh dấu là đang ở chế độ Sửa

            txtMaChatLieu.Enabled = false; // KHÔNG cho phép sửa mã chính (tránh lỗi khóa chính)
            txtTenChatLieu.Enabled = true; // Chỉ cho phép sửa tên chất liệu
            txtTenChatLieu.Focus();

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
        }

        // Nút XÓA
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaChatLieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Bạn có muốn xóa bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sqlDelete = "DELETE FROM tblChatlieu WHERE MaChatLieu = N'" + txtMaChatLieu.Text.Trim() + "'";
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

        // Nút ĐÓNG / THOÁT FORM
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}