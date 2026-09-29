using System.Data;

namespace BanHangLuuNiem.Classes
{
    public class Function
    {
        private static DataProcessor dtBase = new DataProcessor();

        // 1. Kiểm tra một mã/khóa đã tồn tại trong bảng hay chưa
        public static bool CheckKey(string sql)
        {
            DataTable dt = dtBase.ReadData(sql);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        // 2. Đổ dữ liệu từ SQL vào ComboBox (ví dụ: danh sách Chất liệu, Nhân viên...)
        public static void FillCombo(string sql, ComboBox cbo, string ma, string ten)
        {
            DataTable dt = dtBase.ReadData(sql);
            cbo.DataSource = dt;
            cbo.ValueMember = ma;   // Giá trị thực tế (VD: MaChatLieu)
            cbo.DisplayMember = ten; // Giá trị hiển thị (VD: TenChatLieu)
        }

        // 3. Chuyển đổi định dạng ngày tháng chuẩn SQL (yyyy/MM/dd)
        public static string ConvertDateTime(string date)
        {
            // Kiểm tra xem chuỗi ngày dùng dấu '-' hay '/' để tách mảng cho chính xác
            char separator = date.Contains("-") ? '-' : '/';
            string[] array = date.Split(separator);

            if (array.Length < 3)
            {
                return date; // Trả về nguyên bản nếu định dạng không hợp lệ
            }

            // Định dạng dd/MM/yyyy hoặc dd-MM-yyyy -> yyyy/MM/dd
            return String.Format("{0}/{1}/{2}", array[2], array[1], array[0]);
        }

        // 4. Lấy một giá trị đơn từ câu lệnh SELECT (VD: lấy tên hàng từ mã hàng)
        public static string GetFieldValues(string sql)
        {
            string ma = "";
            DataTable dt = dtBase.ReadData(sql);
            if (dt.Rows.Count > 0)
            {
                ma = dt.Rows[0][0].ToString();
            }
            return ma;
        }
    }
}