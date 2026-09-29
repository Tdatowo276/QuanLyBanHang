-- Tạo cơ sở dữ liệu
CREATE DATABASE QLBanHang;
GO

USE QLBanHang;
GO

-- 1. Bảng Chất Liệu
CREATE TABLE tblChatlieu (
    MaChatLieu NVARCHAR(10) PRIMARY KEY,
    TenChatLieu NVARCHAR(50) NOT NULL
);
GO

-- 2. Bảng Nhân Viên
CREATE TABLE tblNhanvien (
    Manhavien NVARCHAR(10) PRIMARY KEY,
    Tennnhanvien NVARCHAR(50) NOT NULL,
    Gioitinh NVARCHAR(10),
    Diachi NVARCHAR(100),
    Dienthoai VARCHAR(15),
    Ngaysinh DATE
);
GO

-- 3. Bảng Khách Hàng
CREATE TABLE tblKhach (
    Makhach NVARCHAR(10) PRIMARY KEY,
    Tenkhach NVARCHAR(50) NOT NULL,
    Diachi NVARCHAR(100),
    Dienthoai VARCHAR(15)
);
GO

-- 4. Bảng Hàng Hóa
CREATE TABLE tblHang (
    MaHang NVARCHAR(10) PRIMARY KEY,
    Tenhang NVARCHAR(50) NOT NULL,
    Machatlieu NVARCHAR(10),
    Soluong INT CHECK (Soluong >= 0),
    Dongianhap DECIMAL(18,2),
    Dongiaban DECIMAL(18,2),
    Anh NVARCHAR(200),
    GhiChu NVARCHAR(MAX),
    FOREIGN KEY (Machatlieu) REFERENCES tblChatlieu(MaChatLieu)
);
GO

-- 5. Bảng Hóa Đơn Bán
CREATE TABLE tblHDBan (
    MaHDBan NVARCHAR(20) PRIMARY KEY,
    Manhavien NVARCHAR(10),
    Ngayban DATE,
    Makhach NVARCHAR(10),
    TongTien DECIMAL(18,2),
    FOREIGN KEY (Manhavien) REFERENCES tblNhanvien(Manhavien),
    FOREIGN KEY (Makhach) REFERENCES tblKhach(Makhach)
);
GO

-- 6. Bảng Chi Tiết Hóa Đơn Bán
CREATE TABLE tblChitietHDBan (
    MaHDBan NVARCHAR(20),
    Mahang NVARCHAR(10),
    Soluong INT CHECK (Soluong > 0),
    Giamgia DECIMAL(5,2), -- Tỷ lệ hoặc giá trị giảm giá
    Thanhtien DECIMAL(18,2),
    PRIMARY KEY (MaHDBan, Mahang),
    FOREIGN KEY (MaHDBan) REFERENCES tblHDBan(MaHDBan),
    FOREIGN KEY (Mahang) REFERENCES tblHang(MaHang)
);
GO


-- 1. Thêm dữ liệu vào bảng Chất Liệu (tblChatlieu)
INSERT INTO tblChatlieu (MaChatLieu, TenChatLieu) VALUES
('CL01', N'Cotton'),
('CL02', N'Kaki'),
('CL03', N'Jean'),
('CL04', N'Lụa');
GO

-- 2. Thêm dữ liệu vào bảng Nhân Viên (tblNhanvien)
INSERT INTO tblNhanvien (Manhavien, Tennnhanvien, Gioitinh, Diachi, Dienthoai, Ngaysinh) VALUES
('NV01', N'Nguyễn Văn An', N'Nam', N'Hà Nội', '0912345678', '1998-05-12'),
('NV02', N'Trần Thị Mai', N'Nữ', N'Hà Nội', '0987654321', '2000-08-20'),
('NV03', N'Lê Hoàng Long', N'Nam', N'Thái Bình', '0905123456', '1999-11-02');
GO

-- 3. Thêm dữ liệu vào bảng Khách Hàng (tblKhach)
INSERT INTO tblKhach (Makhach, Tenkhach, Diachi, Dienthoai) VALUES
('KH01', N'Phạm Văn Hùng', N'Hà Nội', '0933111222'),
('KH02', N'Lê Thị Hương', N'Hồ Chí Minh', '0944555666'),
('KH03', N'Hoàng Minh Tuấn', N'Đà Nẵng', '0955888999');
GO

-- 4. Thêm dữ liệu vào bảng Hàng Hóa (tblHang)
INSERT INTO tblHang (MaHang, Tenhang, Machatlieu, Soluong, Dongianhap, Dongiaban, Anh, GhiChu) VALUES
('H01', N'Áo sơ mi nam', 'CL01', 50, 150000, 250000, 'aosomi.jpg', N'Hàng mới về, chất thoáng mát'),
('H02', N'Quần tây nam', 'CL02', 30, 200000, 350000, 'quantay.jpg', N'Chất liệu đứng form, lịch sự'),
('H03', N'Áo khoác Jean', 'CL03', 20, 300000, 480000, 'aokhoacjean.jpg', N'Phong cách trẻ trung'),
('H04', N'Vải lụa cao cấp', 'CL04', 100, 100000, 180000, 'vailua.jpg', N'Hàng nhập khẩu chất lượng cao');
GO

-- 5. Thêm dữ liệu vào bảng Hóa Đơn Bán (tblHDBan)
INSERT INTO tblHDBan (MaHDBan, Manhavien, Ngayban, Makhach, TongTien) VALUES
('HDB01', 'NV01', '2026-06-01', 'KH01', 600000),
('HDB02', 'NV02', '2026-06-02', 'KH02', 480000),
('HDB03', 'NV01', '2026-06-03', 'KH03', 500000);
GO

-- 6. Thêm dữ liệu vào bảng Chi Tiết Hóa Đơn Bán (tblChitietHDBan)
INSERT INTO tblChitietHDBan (MaHDBan, Mahang, Soluong, Giamgia, Thanhtien) VALUES
('HDB01', 'H01', 1, 0, 250000),
('HDB01', 'H02', 1, 0, 350000),
('HDB02', 'H03', 1, 0, 480000),
('HDB03', 'H01', 2, 0, 500000);
GO