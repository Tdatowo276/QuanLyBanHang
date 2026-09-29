Lưu ý quan trọng dành cho bạn của bạn khi Clone về
Vì dự án của bạn có sử dụng thư mục chứa ảnh (Images\Hang) và Cơ sở dữ liệu SQL Server, khi bạn của bạn git clone về máy, họ cần lưu ý 2 điểm sau để chạy được ngay:

Thư mục ảnh:

Do thư mục bin đã được cấu hình ẩn đi trên Git, khi bạn của bạn mở project lên lần đầu, bên trong thư mục bin\Debug\net10.0-windows có thể chưa có sẵn thư mục Images\Hang.

Họ cần copy thủ công thư mục Images (chứa các file ảnh sản phẩm) vào đúng đường dẫn bin\Debug\net10.0-windows\ (hoặc tạo sẵn trong source để Visual Studio tự động copy).

Cơ sở dữ liệu (SQL Server):

Trong thư mục dự án của bạn có file script SQL (như file QLBanHang.sql nằm ở thư mục gốc).

Bạn của bạn cần mở file này bằng SQL Server Management Studio (SSMS) và chạy (Execute) để tạo lại database trên máy của họ thì ứng dụng mới có dữ liệu để kết nối và hiển thị!

Có, phiên bản phần mềm là yếu tố rất quan trọng để bạn của bạn có thể mở và chạy được project. Cụ thể, bạn của bạn cần lưu ý các yêu cầu về phiên bản sau:

.NET SDK / Runtime: Máy của bạn ấy bắt buộc phải cài đặt .NET 10.0 (hoặc .NET 10 SDK/Runtime), vì dự án của bạn đang cấu hình target là .NET 10.0-windows. Nếu máy của bạn ấy chỉ có các phiên bản cũ hơn (như .NET 8 hay .NET 9) và chưa cài .NET 10, Visual Studio sẽ báo lỗi không tìm thấy SDK hoặc không build được project.

Visual Studio: Nên sử dụng Visual Studio 2022 (đã được cập nhật các phiên bản vá mới nhất hỗ trợ .NET 10) để mở file .slnx hoặc .sln.

SQL Server: Cần có SQL Server hoặc SQL Server LocalDB tương đương để đồng bộ và chạy câu lệnh tạo cơ sở dữ liệu từ file script SQL mà bạn cung cấp.

Mẹo nhỏ: Trước khi đưa code lên Git, bạn có thể nhắc bạn mình kiểm tra xem đã cài .NET 10 chưa (có thể kiểm tra bằng lệnh dotnet --version trong Terminal/Command Prompt). Nếu chưa, bạn ấy chỉ cần tải và cài đặt .NET 10 SDK từ trang chủ Microsoft là có thể clone code về chạy mượt mà ngay!
