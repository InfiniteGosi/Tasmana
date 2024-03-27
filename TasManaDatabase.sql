CREATE DATABASE QL_TKNhanVien
GO
USE QL_TKNhanVien
GO


CREATE TABLE PhongBan
(
  maBoPhan VARCHAR(10) NOT NULL,
  tenPB NVARCHAR(50) NOT NULL,
  maTruongPhong VARCHAR(10) NOT NULL,
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

CREATE TABLE KhachThueKhuThuongMai
(
  maKhuVucThue VARCHAR(10) NOT NULL,
  hoTen NVARCHAR(100) NOT NULL,
  ngaySinh DATE NOT NULL,
  maDinhDanh VARCHAR(20) NOT NULL,
  SDT VARCHAR(20) NOT NULL,
  email VARCHAR(100) NOT NULL,
  quocTich NVARCHAR(50) NOT NULL,
  soTheTamTru VARCHAR(20) NOT NULL,
  ngayChuyenVao DATE NOT NULL,
  ngayChuyenDi DATE NOT NULL,
  soLieuDienNuocHangThang FLOAT NOT NULL,
  phiQuanLyHangThang FLOAT NOT NULL,
  phiDichVuKhac FLOAT NOT NULL,
  sdtNguoiThan VARCHAR(20) NOT NULL,
  tinhTrangCongNo FLOAT NOT NULL,
  PRIMARY KEY (maKhuVucThue)
);

CREATE TABLE Congviec_phongban
(
  maCongViec VARCHAR(10) NOT NULL,
  maBoPhan VARCHAR(10) NOT NULL,
  PRIMARY KEY (maCongViec, maBoPhan),
  FOREIGN KEY (maCongViec) REFERENCES congViec(maCongViec),
  FOREIGN KEY (maBoPhan) REFERENCES phongBan(maBoPhan)
);

CREATE TABLE NhanVien
(
  maNhanVien VARCHAR(10) NOT NULL,
  email VARCHAR(100) NOT NULL,
  ho NVARCHAR(100) NOT NULL,
  ten NVARCHAR(100) NOT NULL,
  SDT VARCHAR(20) NOT NULL,
  ngaySinh DATE NOT NULL,
  gioiTinh CHAR NOT NULL,
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
  maBoPhan VARCHAR(10),
  maNhom VARCHAR(10),
  PRIMARY KEY (maNhanVien),
  FOREIGN KEY (maBoPhan) REFERENCES phongBan(maBoPhan),
  FOREIGN KEY (maNhom) REFERENCES nhom(maNhom)
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
  PRIMARY KEY (maNhanVien),
  FOREIGN KEY (maNhanVien) REFERENCES nhanVien(maNhanVien)
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
  sdtNguoiThan VARCHAR(20) NOT NULL,
  duLieuDangKyThuNuoi NVARCHAR(100) NOT NULL,
  quocTich NVARCHAR(50) NOT NULL,
  la_nguoi_than_maCuDan VARCHAR(10) NOT NULL,
  PRIMARY KEY (maCuDan),
  FOREIGN KEY (la_nguoi_than_maCuDan) REFERENCES cuDan(maCuDan)
);

CREATE TABLE KhachNganNgay
(
  maCuDan VARCHAR(10) NOT NULL,
  PRIMARY KEY (maCuDan),
  FOREIGN KEY (maCuDan) REFERENCES cuDan(maCuDan)
);

CREATE TABLE NguoiDcUyQuyenChuHo
(
  maCuDan VARCHAR(10) NOT NULL,
  nguoiUyQuyen VARCHAR(10) NOT NULL,
  soLieuChotDienNuocHangThang FLOAT NOT NULL,
  PRIMARY KEY (maCuDan),
  FOREIGN KEY (maCuDan) REFERENCES cuDan(maCuDan)
);

CREATE TABLE ChuHo
(
  maCuDan VARCHAR(10) NOT NULL,
  ngayNhanBanGiaoCanHo DATE NOT NULL,
  soDienNuocNgayBanGiao FLOAT NOT NULL,
  ngayChuyenNhuongChoChuMoi DATE NOT NULL,
  thongTinChuHoMoi VARCHAR(10) NOT NULL,
  PRIMARY KEY (maCuDan),
  FOREIGN KEY (maCuDan) REFERENCES cuDan(maCuDan)
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
  maKhuVucThue VARCHAR(10),
  PRIMARY KEY (maCanHo),
  FOREIGN KEY (maCuDan) REFERENCES cuDan(maCuDan),
  FOREIGN KEY (maKhuVucThue) REFERENCES khachThueKhuThuongMai(maKhuVucThue)
);

CREATE TABLE PhuongTien
(
  bienSo VARCHAR(50) NOT NULL,
  chungLoai NVARCHAR(50) NOT NULL,
  tinhTrangSoHuu NVARCHAR(50) NOT NULL,
  maCuDan VARCHAR(10) NOT NULL,
  PRIMARY KEY (bienSo),
  FOREIGN KEY (maCuDan) REFERENCES cuDan(maCuDan)
);

CREATE TABLE Congviec_Canho
(
  maCongViec VARCHAR(10) NOT NULL,
  maCanHo VARCHAR(10) NOT NULL,
  PRIMARY KEY (maCongViec, maCanHo),
  FOREIGN KEY (maCongViec) REFERENCES congViec(maCongViec),
  FOREIGN KEY (maCanHo) REFERENCES canHo(maCanHo)
);


-- Insert thông tin tài khoản
INSERT INTO NhanVien VALUES('GD-001', 'jd@gmail.com', 'Ho', 'Khang', '111111111', '1/1/2002', 'M', 'TP.HCM', '123456', 'Full-time', N'Chưa cưới', '1111111', 1, '1/1/2024', NULL, 'TP.HCM', NULL, N'Tốt', NULL, NULL)

INSERT INTO TaiKhoan VALUES('GD-001.KHANG.111111111', '123', 'GD-001')

SELECT * FROM TaiKhoan
SELECT * FROM NhanVien
