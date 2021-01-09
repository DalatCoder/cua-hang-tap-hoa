-- Create a new database called 'QL_CuaHangTapHoa'
-- Connect to the 'master' database to run this snippet
USE master
GO
-- Create the new database if it does not exist already
IF NOT EXISTS (
    SELECT [name]
        FROM sys.databases
        WHERE [name] = N'QL_CuaHangTapHoa'
)
CREATE DATABASE QL_CuaHangTapHoa
GO

USE QL_CuaHangTapHoa
GO

-- Create a new table called '[LoaiTaiKhoan]' in schema '[dbo]'
-- Drop the table if it already exists
IF OBJECT_ID('[dbo].[LoaiTaiKhoan]', 'U') IS NOT NULL
DROP TABLE [dbo].[LoaiTaiKhoan]
GO
-- Create the table in the specified schema
CREATE TABLE [dbo].[LoaiTaiKhoan]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), -- Primary Key column
    TenLoai NVARCHAR(100) NOT NULL,
);
GO

-- Create a new table called '[TaiKhoan]' in schema '[dbo]'
-- Drop the table if it already exists
IF OBJECT_ID('[dbo].[TaiKhoan]', 'U') IS NOT NULL
DROP TABLE [dbo].[TaiKhoan]
GO
-- Create the table in the specified schema
CREATE TABLE [dbo].[TaiKhoan]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), -- Primary Key column    
    TenDangNhap NVARCHAR(100) NOT NULL,
    MatKhau NVARCHAR(100) NOT NULL,
    LoaiTaiKhoanId INT NOT NULL,
    CreatedAt DATETIME NOT NULL DEFAULT GETDATE()
);
GO

-- Create a new table called '[NguoiMua]' in schema '[dbo]'
-- Drop the table if it already exists
IF OBJECT_ID('[dbo].[NguoiMua]', 'U') IS NOT NULL
DROP TABLE [dbo].[NguoiMua]
GO
-- Create the table in the specified schema
CREATE TABLE [dbo].[NguoiMua]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), -- Primary Key column
    Ten NVARCHAR(200) NOT NULL,
    DiaChi NVARCHAR(300) NULL,
    Thon NVARCHAR(100) NULL,
    Xa NVARCHAR(100) NULL,
    MoTa NVARCHAR(1000) NULL,
    DienThoai VARCHAR(30) NULL,
    HinhAnh VARCHAR(200) NULL DEFAULT 'default',
);
GO

-- Create a new table called '[LoaiHangHoa]' in schema '[dbo]'
-- Drop the table if it already exists
IF OBJECT_ID('[dbo].[LoaiHangHoa]', 'U') IS NOT NULL
DROP TABLE [dbo].[LoaiHangHoa]
GO
-- Create the table in the specified schema
CREATE TABLE [dbo].[LoaiHangHoa]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), -- Primary Key column
    TenLoai NVARCHAR(100) NOT NULL,    
);
GO

-- Create a new table called '[DonViTinh]' in schema '[dbo]'
-- Drop the table if it already exists
IF OBJECT_ID('[dbo].[DonViTinh]', 'U') IS NOT NULL
DROP TABLE [dbo].[DonViTinh]
GO
-- Create the table in the specified schema
CREATE TABLE [dbo].[DonViTinh]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), -- Primary Key column    
    TenDonViTinh NVARCHAR(100) NOT NULL
);
GO

-- Create a new table called '[HangHoa]' in schema '[dbo]'
-- Drop the table if it already exists
IF OBJECT_ID('[dbo].[HangHoa]', 'U') IS NOT NULL
DROP TABLE [dbo].[HangHoa]
GO
-- Create the table in the specified schema
CREATE TABLE [dbo].[HangHoa]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), -- Primary Key column
    TenHang NVARCHAR NOT NULL,
    LoaiHangHoaId INT NOT NULL,
    GiaVon DECIMAL NOT NULL,
    GiaBan DECIMAL NOT NULL,
    DonViTinhId INT NOT NULL,
    TonKho INT NOT NULL,
    HinhAnh VARCHAR(200) NOT NULL DEFAULT 'default',
    MoTa NVARCHAR(1000) NULL,
    TrangThai BIT NOT NULL DEFAULT 1,
);
GO

-- Create a new table called '[DonHang]' in schema '[dbo]'
-- Drop the table if it already exists
IF OBJECT_ID('[dbo].[DonHang]', 'U') IS NOT NULL
DROP TABLE [dbo].[DonHang]
GO
-- Create the table in the specified schema
CREATE TABLE [dbo].[DonHang]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), -- Primary Key column
    NguoiMuaId INT NOT NULL,
    NguoiBanId INT NOT NULL,
    TongTien DECIMAL NOT NULL,
    GiamGia DECIMAL NOT NULL DEFAULT 0,
    ThoiGian DATETIME NOT NULL DEFAULT GETDATE(),
    TrangThai BIT NOT NULL DEFAULT 0,
    GhiChu NVARCHAR(1000) NULL
);
GO

-- Create a new table called '[ChiTietDonHang]' in schema '[dbo]'
-- Drop the table if it already exists
IF OBJECT_ID('[dbo].[ChiTietDonHang]', 'U') IS NOT NULL
DROP TABLE [dbo].[ChiTietDonHang]
GO
-- Create the table in the specified schema
CREATE TABLE [dbo].[ChiTietDonHang]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), -- Primary Key column
    DonHangId INT NOT NULL,
    HangHoaId INT NOT NULL,
    TrangThai INT NOT NULL DEFAULT 0, -- 0: Bán đủ, 1: Bán lẻ
    GiaTaiThoiDiemBan DECIMAL NOT NULL,
    SoLuong INT NOT NULL,    
    GhiChu NVARCHAR(1000) NULL,    
);
GO