IF EXISTS (
    SELECT [name]
        FROM sys.databases
        WHERE [name] = N'QL_CuaHangTapHoa'
)
USE QL_CuaHangTapHoa
GO

ALTER TABLE TaiKhoan
   ADD CONSTRAINT FK_TaiKhoan_LoaiTaiKhoan FOREIGN KEY (LoaiTaiKhoanId)
      REFERENCES LoaiTaiKhoan (Id)
      ON DELETE CASCADE
      ON UPDATE CASCADE
;


ALTER TABLE HangHoa
   ADD CONSTRAINT FK_HangHoa_LoaiHangHoa FOREIGN KEY (LoaiHangHoaId)
      REFERENCES LoaiHangHoa (Id)
      ON DELETE CASCADE
      ON UPDATE CASCADE
;


ALTER TABLE HangHoa
   ADD CONSTRAINT FK_HangHoa_DonViTinh FOREIGN KEY (DonViTinhId)
      REFERENCES DonViTinh (Id)
      ON DELETE CASCADE
      ON UPDATE CASCADE
;


ALTER TABLE DonHang
   ADD CONSTRAINT FK_DonHang_NguoiMua FOREIGN KEY (NguoiMuaId)
      REFERENCES NguoiMua (Id)
      ON DELETE CASCADE
      ON UPDATE CASCADE
;


ALTER TABLE DonHang
   ADD CONSTRAINT FK_DonHang_TaiKhoan FOREIGN KEY (NguoiBanId)
      REFERENCES TaiKhoan (Id)
      ON DELETE CASCADE
      ON UPDATE CASCADE
;


ALTER TABLE ChiTietDonHang
   ADD CONSTRAINT FK_ChiTietDonHang_DonHang FOREIGN KEY (DonHangId)
      REFERENCES DonHang (Id)
      ON DELETE CASCADE
      ON UPDATE CASCADE
;


ALTER TABLE ChiTietDonHang
   ADD CONSTRAINT FK_ChiTietDonHang_HangHoa FOREIGN KEY (HangHoaId)
      REFERENCES HangHoa (Id)
      ON DELETE CASCADE
      ON UPDATE CASCADE
;