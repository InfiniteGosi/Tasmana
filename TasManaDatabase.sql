CREATE DATABASE Tasmana
GO
USE Tasmana
GO

use master

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
  noiDung NVARCHAR(100) NOT NULL,
  thoiHan DATE NOT NULL,
  trangThai NVARCHAR(100) NOT NULL,
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
  soDoMatBang IMAGE NOT NULL,
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



-- Insert thông tin tài khoản
INSERT INTO NhanVien VALUES('GD-001', 'jd@gmail.com', 'Ho', 'Khang', '111111111', '1/1/2002', 1, 'TP.HCM', '123456', 'Full-time', N'Độc thân', '1111111', 1, '1/1/2024', NULL, 'TP.HCM', NULL, N'Tốt', NULL)
INSERT INTO TaiKhoan VALUES('GD-001.KHANG.111111111', '123', 'GD-001')

SELECT * FROM TaiKhoan
SELECT * FROM NhanVien
