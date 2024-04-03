CREATE DATABASE Tasmana
GO
USE Tasmana
GO

CREATE TABLE PhongBan
(
  maBoPhan VARCHAR(10) NOT NULL,
  tenPB NVARCHAR(50) NOT NULL,
  SDT VARCHAR(20) NOT NULL,
  email VARCHAR(100) NOT NULL,
  PRIMARY KEY (maBoPhan)
);

CREATE TABLE Nhom
(
  maNhom VARCHAR(10) NOT NULL,
  maTruongNhom VARCHAR(10) NOT NULL,
  maBoPhan VARCHAR(10) NOT NULL,
  PRIMARY KEY (maNhom),
  FOREIGN KEY (maBoPhan) REFERENCES phongBan(maBoPhan)
);

CREATE TABLE CongViec
(
  maCongViec VARCHAR(10) NOT NULL,
  noiDung NVARCHAR(200) NOT NULL,
  thoiHan SMALLDATETime NOT NULL,
  ngayHoanThanh SMALLDATETIME,
  trangThai NVARCHAR(100) NOT NULL,
  ghiChu NVARCHAR(200),
  PRIMARY KEY (maCongViec)
);

CREATE TABLE Congviec_PhongBan
(
  maCongViec VARCHAR(10) NOT NULL,
  maBoPhan VARCHAR(10) NOT NULL,
  PRIMARY KEY (maCongViec, maBoPhan),
  FOREIGN KEY (maCongViec) REFERENCES congViec(maCongViec),
  FOREIGN KEY (maBoPhan) REFERENCES PhongBan(maBoPhan)
);

CREATE TABLE CongViec_Nhom
(
  maNhom VARCHAR(10) NOT NULL,
  maCongViec VARCHAR(10) NOT NULL,
  PRIMARY KEY (maNhom, maCongViec),
  FOREIGN KEY (maNhom) REFERENCES Nhom(maNhom),
  FOREIGN KEY (maCongViec) REFERENCES congViec(maCongViec)
);

CREATE TABLE NhanVien
(
  maNhanVien VARCHAR(10) NOT NULL,
  email VARCHAR(100) NOT NULL,
  ho NVARCHAR(100) NOT NULL,
  ten NVARCHAR(100) NOT NULL,
  SDT VARCHAR(20) NOT NULL,
  ngaySinh DATE NOT NULL,
  gioiTinh BIT NOT NULL, -- 1 nam, 0 nu
  queQuan NVARCHAR(100) NOT NULL,
  maDinhDanh VARCHAR(20) NOT NULL,
  loaiNhanVien NVARCHAR(20) NOT NULL,
  tinhTrangHonNhan NVARCHAR(20) NOT NULL,
  maSoBHXH VARCHAR(20) NOT NULL,
  daTungLamNV BIT NOT NULL,
  ngayKyHDLD DATE NOT NULL,
  ngayHetHDLD DATE,
  dChiThuongTru NVARCHAR(100) NOT NULL,
  dChiTamTru NVARCHAR(100),
  tinhTrangHDLD NVARCHAR(100) NOT NULL,
  maNhom VARCHAR(10),
  PRIMARY KEY (maNhanVien),
  FOREIGN KEY (maNhom) REFERENCES nhom(maNhom),
  UNIQUE (maDinhDanh),
  UNIQUE (maSoBHXH)
);

CREATE TABLE TaiKhoan
(
  maNguoiDung VARCHAR(30) NOT NULL,
  matKhau VARCHAR(100) NOT NULL,
  maNhanVien VARCHAR(10) NOT NULL,
  PRIMARY KEY (maNguoiDung),
  FOREIGN KEY (maNhanVien) REFERENCES nhanVien(maNhanVien)
);

CREATE TABLE CEO
(
  maNhanVien VARCHAR(10) NOT NULL,
  PRIMARY KEY (maNhanVien),
  FOREIGN KEY (maNhanVien) REFERENCES nhanVien(maNhanVien)
);

CREATE TABLE QuanLy
(
  maNhanVien VARCHAR(10) NOT NULL,
  maBoPhan VARCHAR(10) NOT NULL,
  PRIMARY KEY (maNhanVien),
  FOREIGN KEY (maNhanVien) REFERENCES nhanVien(maNhanVien),
  FOREIGN KEY (maBoPhan) REFERENCES phongBan(maBoPhan)
);

CREATE TABLE Congviec_Nhanvien
(
  maNhanVien VARCHAR(10) NOT NULL,
  maCongViec VARCHAR(10) NOT NULL,
  PRIMARY KEY (maNhanVien, maCongViec),
  FOREIGN KEY (maNhanVien) REFERENCES nhanVien(maNhanVien),
  FOREIGN KEY (maCongViec) REFERENCES congViec(maCongViec)
);

CREATE TABLE CuDan
(
  maCuDan VARCHAR(10) NOT NULL,
  hoTen NVARCHAR(100) NOT NULL,
  ngaySinh DATE NOT NULL,
  maDinhDanh VARCHAR(20) NOT NULL,
  SDT VARCHAR(20) NOT NULL,
  email VARCHAR(100) NOT NULL,
  soTheTamTru VARCHAR(20) NOT NULL,
  ngayChuyenVao DATE NOT NULL,
  ngayChuyenDi DATE NOT NULL,
  soDienNuocHangThang FLOAT NOT NULL,
  tinhTrangCongNo FLOAT NOT NULL,
  duLieuDangKyThuNuoi NVARCHAR(100) NOT NULL,
  quocTich NVARCHAR(50) NOT NULL,
  maCuDanNguoiThan VARCHAR(10) NOT NULL,
  PRIMARY KEY (maCuDan),
  FOREIGN KEY (maCuDanNguoiThan) REFERENCES CuDan(maCuDan),
  UNIQUE (maDinhDanh),
  UNIQUE (soTheTamTru)
);

CREATE TABLE ChuHo
(
  maCuDan VARCHAR(10) NOT NULL,
  ngayNhanBanGiaoCanHo DATE NOT NULL,
  soDienNuocNgayBanGiao FLOAT NOT NULL,
  ngayChuyenNhuongChoChuMoi DATE NOT NULL,
  banGiao_maCuDan VARCHAR(10) NOT NULL,
  PRIMARY KEY (maCuDan),
  FOREIGN KEY (maCuDan) REFERENCES CuDan(maCuDan),
  FOREIGN KEY (banGiao_maCuDan) REFERENCES ChuHo(maCuDan)
);

CREATE TABLE KhachNganNgay
(
  maCuDan VARCHAR(10) NOT NULL,
  maCuDanChuHo VARCHAR(10) NOT NULL,
  PRIMARY KEY (maCuDan),
  FOREIGN KEY (maCuDan) REFERENCES cuDan(maCuDan),
  FOREIGN KEY (maCuDanChuHo) REFERENCES chuHo(maCuDan)
);

CREATE TABLE NguoiDcUyQuyenChuHo
(
  maCuDan VARCHAR(10) NOT NULL,
  maCuDanChuHo VARCHAR(10) NOT NULL,
  PRIMARY KEY (maCuDan),
  FOREIGN KEY (maCuDan) REFERENCES cuDan(maCuDan),
  FOREIGN KEY (maCuDanChuHo) REFERENCES chuHo(maCuDan)
);

CREATE TABLE KhachThueKhuThuongMai
(
  tenCongTy NVARCHAR(100) NOT NULL,
  maCuDan VARCHAR(10) NOT NULL,
  PRIMARY KEY (maCuDan),
  FOREIGN KEY (maCuDan) REFERENCES CuDan(maCuDan)
);

CREATE TABLE CanHo
(
  maCanHo VARCHAR(10) NOT NULL,
  dienTich FLOAT NOT NULL,
  viTriTang INT NOT NULL,
  soLuongPhongNgu INT NOT NULL,
  soLuongToilet INT NOT NULL,
  soDoMatBang IMAGE,
  mucPhiQLHangThang INT NOT NULL,
  soLuongTheThangMay INT NOT NULL,
  lichSuGiaoDich DATE NOT NULL,
  tinhTrangGDHienTai NVARCHAR(100) NOT NULL,
  maCuDan VARCHAR(10),
  PRIMARY KEY (maCanHo),
  FOREIGN KEY (maCuDan) REFERENCES cuDan(maCuDan)
);

CREATE TABLE PhuongTien
(
  bienSo VARCHAR(50) NOT NULL,
  chungLoai NVARCHAR(50) NOT NULL,
  tinhTrangSoHuu NVARCHAR(50) NOT NULL,
  maCuDan VARCHAR(10) NOT NULL,
  PRIMARY KEY (bienSo, maCuDan),
  FOREIGN KEY (maCuDan) REFERENCES cuDan(maCuDan)
);

CREATE TABLE NhanVienCuaChuHo
(
  maCuDan VARCHAR(10) NOT NULL,
  maCuDanChuHo VARCHAR(10) NOT NULL,
  PRIMARY KEY (maCuDan),
  FOREIGN KEY (maCuDan) REFERENCES CuDan(maCuDan),
  FOREIGN KEY (maCuDanChuHo) REFERENCES chuHo(maCuDan)
);

CREATE TABLE KhuThuongMai
(
  maCanHo VARCHAR(10) NOT NULL,
  maNhanVien VARCHAR(10) NOT NULL,
  PRIMARY KEY (maCanHo),
  FOREIGN KEY (maCanHo) REFERENCES CanHo(maCanHo),
  FOREIGN KEY (maNhanVien) REFERENCES NhanVien(maNhanVien)
);

CREATE TABLE YeuCau
(
  maCongViec VARCHAR(10) NOT NULL,
  maCanHo VARCHAR(10) NOT NULL,
  PRIMARY KEY (maCongViec, maCanHo),
  FOREIGN KEY (maCongViec) REFERENCES congViec(maCongViec),
  FOREIGN KEY (maCanHo) REFERENCES canHo(maCanHo)
);

CREATE TABLE CuDan_sdtNguoiThan
(
  sdtNguoiThan VARCHAR(20) NOT NULL,
  maCuDan VARCHAR(10) NOT NULL,
  PRIMARY KEY (sdtNguoiThan, maCuDan),
  FOREIGN KEY (maCuDan) REFERENCES CuDan(maCuDan)
);
go

-- Insert thông tin tài khoản
INSERT INTO NhanVien VALUES('GD-001', 'jd@gmail.com', 'Ho', 'Khang', '111111111', '1/1/2002', 1, 'TP.HCM', '123456', 'Full-time', N'Độc thân', '1111111', 1, '1/1/2024', NULL, 'TP.HCM', NULL, N'Tốt', NULL)
INSERT INTO TaiKhoan VALUES('GD-001.KHANG.111111111', '123', 'GD-001')

-- Insert thông tin phòng ban
INSERT INTO PhongBan VALUES('HCNS', N'Hành chính Nhân sự & Dịch vụ Cư dân','0123456789','BCMP_HCNS@gmail.com')
INSERT INTO PhongBan VALUES('VS', N'Vệ Sinh','0123456889','BCMP_VS@gmail.com')
INSERT INTO PhongBan VALUES('TCKT', N'Tài chính kế toán', '01234444444' ,'BCMP_TCKT@gmail.com')
INSERT INTO PhongBan VALUES('AN', N'An Ninh', '0133333333', 'BCMP_AN@gmail.com')
INSERT INTO PhongBan VALUES('KT', N'Kỹ Thuật Bảo Trì', '01234567912', '@BCM_KT@gmail.com')
INSERT INTO PhongBan VALUES('XD', N'Xây Dựng', '02645816328', '@BCMP_XD@gmail.com')

-- Insert thông tin nhóm
INSERT INTO Nhom VALUES('VSN01', 'VS-002', 'VS')
INSERT INTO Nhom VALUES('VSN02', 'VS-002', 'VS')

-- Insert thông tin nhóm
INSERT INTO Nhom VALUES('VSN01', 'VS-002', 'VS')
INSERT INTO Nhom VALUES('VSN02', 'VS-002', 'VS')

SELECT * FROM PhongBan
SELECT * FROM Nhom

-- Insert thông tin tài khoản
INSERT INTO NhanVien VALUES('GD-001', 'jd@gmail.com', 'Ho', 'Khang', '111111111', '1/1/2002', 1, 'TP.HCM', '123456', 'Full-time', N'Độc thân', '1111111', 1, '2024-01-01', '2025-12-31', 'TP.HCM', N'Địa chỉ thường trú GD-001', N'Tốt', 'VSN01')
INSERT INTO TaiKhoan VALUES('GD-001.KHANG.111111111', '123', 'GD-001')
-- Insert thông tin NV
INSERT INTO NhanVien VALUES('VS-002', 'VS002@gmail.com', 'Vu', 'Quang', '1321312', '1/2/2004', 1, 'TP.HCM', '1234576', 'Full-time', N'Độc thân', '1111211', 1, '2024-01-01', '2025-12-31', 'TP.HCM', 'Chua co', N'Tốt', 'VSN01')
INSERT INTO TaiKhoan VALUES('VS-002.MinhQuang.1321312', '123', 'VS-002')
INSERT INTO NhanVien VALUES('VS-003', 'email_nv001@example.com', 'Tran', 'An', '0123456669', '2000-01-01', 1, N'Hà Nội', '072947182653', 'Full-time', N'Độc thân', '01231230213', 1, '2024-01-01', '2025-12-31', N'Địa chỉ thường trú NV001', 'Chua co', N'Tốt', 'VSN01')

SELECT * FROM TaiKhoan
SELECT * FROM NhanVien


=========
-- Insert mẫu công việc
INSERT INTO CongViec VALUES('CVVS1', N'Quét nhà', '2024-04-04 12:30:00',null, N'Chưa bắt đầu',null)
Insert into CongViec_NhanVien Values ('VS-003', 'CVVS1')
Insert INTO YeuCau VALUES('CVVS1', 'WPHA')


-- Insert Dữ liệu thử của căn hộ
INSERT INTO CanHo VALUES ('WPHA', 100.5, 5, 3, 2, NULL, 200, 2, '2024-01-01', N'Còn trống', NULL);
INSERT INTO CanHo VALUES ('WPHB', 90.2, 8, 2, 1, NULL, 150, 1, '2024-01-01', N'Còn trống', NULL);
INSERT INTO CanHo VALUES ('WPHC', 110.8, 3, 4, 2, NULL, 250, 2, '2024-01-01', N'Còn trống', NULL);
INSERT INTO CanHo VALUES ('WPHD', 80.0, 10, 1, 1, NULL, 180, 1, '2024-01-01', N'Còn trống', NULL);

-- Insert mẫu công việc
INSERT INTO CongViec VALUES('CVVS1', N'Quét nhà', '2024-04-04 12:30:00',null, N'Chưa bắt đầu',null)
Insert into CongViec_NhanVien Values ('VS-003', 'CVVS1')
Insert INTO YeuCau VALUES('CVVS1', 'WPHA')
go
 select * from NhanVien

--Procedure thêm một nhân viên mới
create procedure [dbo].[SP_ThemNhanVien]
	@maNhanVien varchar(10),
	@email varchar(100),
	@ho nvarchar(100),
	@ten nvarchar(100),
	@SDT varchar(20),
	@ngaySinh date,
	@gioiTinh bit,
	@queQuan nvarchar(100),
	@maDinhDanh varchar(20),
	@loaiNhanVien nvarchar(20),
	@tinhTrangHonNhan nvarchar(20),
	@maSoBHXH varchar(20),
	@daTungLamNV bit,
	@ngayKyHDLD date,
	@ngayHetHDLD date,
	@dChiThuongTru nvarchar(100),
	@dChiTamTru nvarchar(100),
	@tinhTrangHDLD nvarchar(100),
	@maNhom varchar(10)
as
begin
	insert into NhanVien 
    values(
        @maNhanVien,
        @email,
        @ho,
		@ten,
        @SDT,
        @ngaySinh,
        @gioiTinh,
        @queQuan,
        @maDinhDanh,
        @loaiNhanVien,
        @tinhTrangHonNhan,
        @maSoBHXH,
        @daTungLamNV,
        @ngayKyHDLD,
        @ngayHetHDLD,
        @dChiThuongTru,
        @dChiTamTru,
        @tinhTrangHDLD,
        @maNhom
    )
end
go

SELECT * FROM CanHo
SELECT * FROM CongViec
go

-- Procedure lấy công việc
-- Procedure lấy công việc
CREATE procedure [dbo].[SP_LayCV]
as 
begin
	SELECT Congviec_Nhanvien.maNhanVien as N'Mã nhân viên', (NhanVien.ho + NhanVien.ten) as N'Họ và tên', CongViec.noiDung as N'Nội dung',YeuCau.maCanHo as N'Mã căn hộ' , CongViec.thoiHan as N'Thời hạn', CongViec.ngayHoanThanh as N'Ngày hoàn thành', CongViec.trangThai as N'Trạng thái', CongViec.ghiChu as N'Ghi chú'
	from NhanVien, CongViec, Congviec_Nhanvien, YeuCau
	WHERE NhanVien.maNhanVien = Congviec_Nhanvien.maNhanVien and Congviec_Nhanvien.maCongViec=CongViec.maCongViec and YeuCau.maCongViec = CongViec.maCongViec
END
