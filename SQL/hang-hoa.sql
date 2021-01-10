USE QL_CuaHangTapHoa
GO

-- Create a new stored procedure called 'usp_HangHoa_GetAll' in schema 'dbo'
-- Drop the stored procedure if it already exists
IF EXISTS (
SELECT *
    FROM INFORMATION_SCHEMA.ROUTINES
WHERE SPECIFIC_SCHEMA = N'dbo'
    AND SPECIFIC_NAME = N'usp_HangHoa_GetAll'
    AND ROUTINE_TYPE = N'PROCEDURE'
)
DROP PROCEDURE dbo.usp_HangHoa_GetAll
GO

CREATE PROCEDURE dbo.usp_HangHoa_GetAll
AS
    SELECT HangHoa.Id, TenHang, TenLoai, TenDonViTinh, GiaVon, GiaBan, TonKho, HinhAnh, MoTa, TrangThai
    FROM HangHoa
    JOIN LoaiHangHoa ON HangHoa.LoaiHangHoaId = LoaiHangHoa.Id
    JOIN DonViTinh ON HangHoa.DonViTinhId = DonViTinh.Id
GO

-- Create a new stored procedure called 'usp_HangHoa_GetAllActive' in schema 'dbo'
-- Drop the stored procedure if it already exists
IF EXISTS (
SELECT *
    FROM INFORMATION_SCHEMA.ROUTINES
WHERE SPECIFIC_SCHEMA = N'dbo'
    AND SPECIFIC_NAME = N'usp_HangHoa_GetAllActive'
    AND ROUTINE_TYPE = N'PROCEDURE'
)
DROP PROCEDURE dbo.usp_HangHoa_GetAllActive
GO

CREATE PROCEDURE dbo.usp_HangHoa_GetAllActive
AS
    SELECT HangHoa.Id, TenHang, TenLoai, TenDonViTinh, GiaVon, GiaBan, TonKho, HinhAnh, MoTa, TrangThai
    FROM HangHoa
    JOIN LoaiHangHoa ON HangHoa.LoaiHangHoaId = LoaiHangHoa.Id
    JOIN DonViTinh ON HangHoa.DonViTinhId = DonViTinh.Id
    WHERE TrangThai = 1
GO

-- Create a new stored procedure called 'usp_HangHoa_GetAllInactive' in schema 'dbo'
-- Drop the stored procedure if it already exists
IF EXISTS (
SELECT *
    FROM INFORMATION_SCHEMA.ROUTINES
WHERE SPECIFIC_SCHEMA = N'dbo'
    AND SPECIFIC_NAME = N'usp_HangHoa_GetAllInactive'
    AND ROUTINE_TYPE = N'PROCEDURE'
)
DROP PROCEDURE dbo.usp_HangHoa_GetAllInactive
GO

CREATE PROCEDURE dbo.usp_HangHoa_GetAllInactive
AS
    SELECT HangHoa.Id, TenHang, TenLoai, TenDonViTinh, GiaVon, GiaBan, TonKho, HinhAnh, MoTa, TrangThai
    FROM HangHoa
    JOIN LoaiHangHoa ON HangHoa.LoaiHangHoaId = LoaiHangHoa.Id
    JOIN DonViTinh ON HangHoa.DonViTinhId = DonViTinh.Id
    WHERE TrangThai = 0
GO

-- Create a new stored procedure called 'usp_HangHoa_SearchByName' in schema 'dbo'
-- Drop the stored procedure if it already exists
IF EXISTS (
SELECT *
    FROM INFORMATION_SCHEMA.ROUTINES
WHERE SPECIFIC_SCHEMA = N'dbo'
    AND SPECIFIC_NAME = N'usp_HangHoa_SearchByName'
    AND ROUTINE_TYPE = N'PROCEDURE'
)
DROP PROCEDURE dbo.usp_HangHoa_SearchByName
GO

CREATE PROCEDURE dbo.usp_HangHoa_SearchByName
    @TenHang NVARCHAR(300)
AS
    SELECT HangHoa.Id, TenHang, TenLoai, TenDonViTinh, GiaVon, GiaBan, TonKho, HinhAnh, MoTa, TrangThai
    FROM HangHoa
    JOIN LoaiHangHoa ON HangHoa.LoaiHangHoaId = LoaiHangHoa.Id
    JOIN DonViTinh ON HangHoa.DonViTinhId = DonViTinh.Id
    WHERE TrangThai = 1 AND dbo.fuConvertToUnsign1(TenHang) LIKE '%' + dbo.fuConvertToUnsign1(@TenHang) + '%'
GO

-- Create a new stored procedure called 'usp_HangHoa_GetByCategory' in schema 'dbo'
-- Drop the stored procedure if it already exists
IF EXISTS (
SELECT *
    FROM INFORMATION_SCHEMA.ROUTINES
WHERE SPECIFIC_SCHEMA = N'dbo'
    AND SPECIFIC_NAME = N'usp_HangHoa_GetByCategory'
    AND ROUTINE_TYPE = N'PROCEDURE'
)
DROP PROCEDURE dbo.usp_HangHoa_GetByCategory
GO
-- Create the stored procedure in the specified schema
CREATE PROCEDURE dbo.usp_HangHoa_GetByCategory
    @LoaiHangHoaId INT
AS
    SELECT HangHoa.Id, TenHang, TenLoai, TenDonViTinh, GiaVon, GiaBan, TonKho, HinhAnh, MoTa, TrangThai
    FROM HangHoa
    JOIN LoaiHangHoa ON HangHoa.LoaiHangHoaId = LoaiHangHoa.Id
    JOIN DonViTinh ON HangHoa.DonViTinhId = DonViTinh.Id
    WHERE TrangThai = 1 AND LoaiHangHoaId = @LoaiHangHoaId
GO


