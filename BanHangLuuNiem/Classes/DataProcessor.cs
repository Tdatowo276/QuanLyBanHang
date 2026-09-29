using Microsoft.Data.SqlClient;
using System.Data;

namespace BanHangLuuNiem.Classes
{
    internal class DataProcessor
    {
        // Chuỗi kết nối tới cơ sở dữ liệu QLBanHang
        private string connString = "Data Source=SILVER_S\\SQLEXPRESS;Initial Catalog = QLBanHang; Integrated Security = True; Connect Timeout = 30; Encrypt=True;Trust Server Certificate=True;Application Intent = ReadWrite; Multi Subnet Failover=False;Command Timeout = 30";
        private SqlConnection conn = null;

        // Hàm mở kết nối
        public void OpenConnect()
        {
            conn = new SqlConnection(connString);
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }

        // Hàm đóng kết nối
        public void CloseConnect()
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
                conn.Dispose();
            }
        }

        // Hàm lấy dữ liệu (SELECT) trả về DataTable
        public DataTable ReadData(string sqlSelect)
        {
            DataTable dt = new DataTable();
            OpenConnect();
            SqlDataAdapter da = new SqlDataAdapter(sqlSelect, conn);
            da.Fill(dt);
            CloseConnect();
            return dt;
        }

        // Hàm thực thi câu lệnh SQL (INSERT, UPDATE, DELETE)
        public void ChangeData(string sql)
        {
            OpenConnect();
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thao tác dữ liệu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cmd.Dispose();
                CloseConnect();
            }
        }
    }
}


