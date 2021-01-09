USE QL_CuaHangTapHoa
GO

DELETE FROM LoaiHangHoa;

SET IDENTITY_INSERT LoaiHangHoa ON
INSERT INTO LoaiHangHoa(Id, TenLoai) 
    VALUES 
        (1, N'Thuốc lá'),
        (2, N'Sữa'),
        (3, N'Nước ngọt'),
        (4, N'Mỹ phẩm'),
        (5, N'Bánh kẹo'),
        (6, N'Đồ uống có cồn'),
        (7, N'Thực phẩm ăn liền'),
        (8, N'Snack');

SET IDENTITY_INSERT LoaiHangHoa OFF


DELETE FROM DonViTinh;

SET IDENTITY_INSERT DonViTinh ON
INSERT INTO DonViTinh(Id, TenDonViTinh)
    VALUES
        (1, N'Gói'),
        (2, N'Cây'),
        (3, N'Chai'),
        (4, N'Lon'),
        (5, N'Bịch'),
        (6, N'Hủ'),
        (7, N'Lốc');
SET IDENTITY_INSERT DonViTinh OFF

SET IDENTITY_INSERT HangHoa ON
INSERT INTO HangHoa(Id, TenHang, LoaiHangHoaId, DonViTinhId, GiaVon, GiaBan, TonKho, HinhAnh)
    VALUES
        (1, N'Mì hảo hảo', 7, 1, 3100, 3500, 100, 'mi-hao-hao'),
        (2, N'Nước coca lon', 3, 4, 9800, 10000, 100, 'coca'),
        (3, N'Nước pepsi lon', 3, 4, 9800, 10000, 100, 'pepsi'),
        (4, N'Thuốc lá Seven', 1, 1, 12900, 13000, 20, 'thuoc-seven'),
        (5, N'Bịch Snack bí đỏ', 8, 1, 4800, 5000, 20, 'snack-bi-do');
SET IDENTITY_INSERT HangHoa OFF



