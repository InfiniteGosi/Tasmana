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
  ngayGiao SMALLDATETIME NOT NULL,
  thoiHan SMALLDATETime,
  ngayHoanThanh SMALLDATETIME,
  ngayCapNhat SMALLDATETIME,
  trangThai NVARCHAR(100) NOT NULL,
  ghiChu NVARCHAR(200),
  quyenTruyCap int,
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

CREATE TABLE CongViec_PDF
(
	maCongViec VARCHAR(10) NOT NULL,
	pdfFile VARBINARY(MAX) NOT NULL ,
	tenFile VARCHAR(50) NOT NULL,
	fileExten VARCHAR(10) NOT NULL
	PRIMARY KEY (maCongViec),
	FOREIGN KEY (maCongViec) REFERENCES congViec(maCongViec)
)
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
  maBoPhan VARCHAR(10),
  maNhom VARCHAR(10),
  PRIMARY KEY (maNhanVien),
  FOREIGN KEY (maNhom) REFERENCES nhom(maNhom),
  FOREIGN KEY (maBoPhan) REFERENCES PhongBan(maBoPhan),
  UNIQUE (maDinhDanh),
  UNIQUE (maSoBHXH)
);

CREATE TABLE TaiKhoan
(
  maNguoiDung VARCHAR(30) NOT NULL,
  matKhau VARCHAR(100) NOT NULL,
  maNhanVien VARCHAR(10) NOT NULL,
  disable BIT NOT NULL,
  rememberId BIT NOT NULL,
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
  duLieuDangKyThuNuoi NVARCHAR(100),
  quocTich NVARCHAR(50) NOT NULL,
  maCuDanNguoiThan VARCHAR(10),
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
  FOREIGN KEY (maCuDan) REFERENCES cuDan(maCuDan),
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


-- Insert thông tin phòng ban
INSERT INTO PhongBan VALUES('DV', N'Hành chính Nhân sự & Dịch vụ Cư dân','0123456789','BCMP_HCNS@gmail.com')
INSERT INTO PhongBan VALUES('VS', N'Vệ Sinh','0123456889','BCMP_VS@gmail.com')
INSERT INTO PhongBan VALUES('TCKT', N'Tài chính kế toán', '01234444444' ,'BCMP_TCKT@gmail.com')
INSERT INTO PhongBan VALUES('AN', N'An Ninh', '0133333333', 'BCMP_AN@gmail.com')
INSERT INTO PhongBan VALUES('KT', N'Kỹ Thuật Bảo Trì', '01234567912', '@BCM_KT@gmail.com')
INSERT INTO PhongBan VALUES('XD', N'Xây Dựng', '02645816328', '@BCMP_XD@gmail.com')

-- Insert thông tin nhóm
INSERT INTO Nhom VALUES('VSN01', 'VS-002', 'VS')
INSERT INTO Nhom VALUES('VSN02', 'VS-002', 'VS')

SELECT * FROM PhongBan
SELECT * FROM Nhom


-- Insert thông tin tài khoản
INSERT INTO NhanVien VALUES('GD-001', 'jd@gmail.com', 'Ho', 'Khang', '111111111', '1/1/2002', 1, 'TP.HCM', '123456', 'Full-time', N'Độc thân', '1111111', 1, '2024-01-01', '2025-12-31', 'TP.HCM', N'Địa chỉ thường trú GD-001', N'Tốt', 'VS', 'VSN01')
INSERT INTO NhanVien VALUES('VS-002', 'VS002@gmail.com', 'Vu', 'Quang', '1321312', '1/2/2004', 1, 'TP.HCM', '1234576', 'Part-time', N'Độc thân', '1111211', 1, '2024-01-01', '2025-12-31', 'TP.HCM', 'Chua co', N'Tốt', 'VS','VSN02')
INSERT INTO NhanVien VALUES('VS-003', 'email_nv001@example.com', 'Tran', 'An', '0123456669', '2000-01-01', 0, N'Hà Nội', '072947182653', 'Full-time', N'Độc thân', '01231230213', 1, '2024-01-01', '2025-12-31', N'Địa chỉ thường trú NV001', 'Chua co', N'Tốt', 'VS','VSN01')
-- Insert thông tin NV
INSERT INTO TaiKhoan VALUES('GD-001.KHANG.111111111', '123', 'GD-001', 0, 1)
INSERT INTO TaiKhoan VALUES('VS-002.QUANG.1321312', '123', 'VS-002', 0, 0)
INSERT INTO TaiKhoan VALUES('VS-003.AN.0123456669', '123', 'VS-003', 0, 0)

SELECT * FROM TaiKhoan
SELECT * FROM NhanVien


-- Insert dữ liệu mẫu cư dân
INSERT INTO CuDan VALUES('CD-A001','Nguyen Thi An','2024-01-01','195052003','0987654321','nguyenthian@example.com', '9876543','2024-01-01','2022-01-01', 35, 0, 'dog', 'vietnam', null);
INSERT INTO CuDan VALUES('CD-A002','Tran Van Binh','1980-09-10','198092035','0123456789','tranvanbinh@example.com', '1234567','2024-01-02','2022-01-02', 35, 0, 'dog', 'vietnam', null);
INSERT INTO CuDan VALUES('CD-A003','Le Thi Mai','1999-12-25','199912253','0365987412','lethimai@example.com', '9871235','2024-01-03','2022-01-03', 35, 0, 'dog', 'vietnam', null)
INSERT INTO CuDan VALUES('CD-A004','Pham Van Cuong','1988-08-08','198808083','0123456789','phamvancuong@example.com', '4561239','2024-01-04','2022-01-04', 35, 0, 'dog', 'vietnam', null)
INSERT INTO CuDan VALUES('CD-A005','Hoang Thi Thu','1992-03-18','199203182','0987654321','hoangthithu@example.com', '7894561','2024-01-05','2022-01-05', 35, 0, 'dog', 'vietnam', null)
INSERT INTO CuDan VALUES('CD-A006','Vu Duc Trung','1985-11-30','198511302','0365987412','vuductrung@example.com', '1237894','2024-01-06','2022-01-06', 35, 0, 'dog', 'vietnam', null)
INSERT INTO CuDan VALUES('CD-A007','Nguyen Van An','1996-02-14','199602143','0901234567','nguyenvanan@example.com', '1593572','2024-01-07','2022-01-07', 35, 0, 'dog', 'vietnam', null)
INSERT INTO CuDan VALUES('CD-A008','Tran Thi Hoa','1982-07-05','198207053','0987654321','tranthihoa@example.com', '7539514','2024-01-08','2022-01-08', 2, 0, 'dog', 'vietnam', null)
INSERT INTO CuDan VALUES('CD-A009','Le Van Hieu','1976-04-12','197604123','0123456789','levanhieu@example.com', '4569872','2024-01-09','2022-01-09', 0, 0, 'dog', 'vietnam', null)

-- Insert Dữ liệu thử của căn hộ
INSERT INTO CanHo VALUES ('WPHA', 100.5, 36, 5, 2, NULL, 2000000, 2, '2024-01-01', N'Chưa bán', 'CD-A001');
INSERT INTO CanHo VALUES ('WPHB', 90.2, 36, 5, 1, NULL, 1500000, 1, '2024-01-01', N'Đã bán', 'CD-A002');
INSERT INTO CanHo VALUES ('WPHC', 110.8, 37, 5, 2, NULL, 2500000, 2, '2024-01-01', N'Đã bán', 'CD-A003');
INSERT INTO CanHo VALUES ('WPHD', 80.0, 37, 5, 1, NULL, 200000, 1, '2024-01-01', N'Đã bán', 'CD-A004');
INSERT INTO CanHo VALUES ('W3501', 80.0, 35, 5, 1, NULL, 100000, 1, '2024-01-01', N'Chưa bán', 'CD-A005');
INSERT INTO CanHo VALUES ('W3502', 80.0, 35, 5, 1, NULL, 1800000, 1, '2024-01-01', N'Chưa bàn giao - Cư dân đang ở', 'CD-A006');
INSERT INTO CanHo VALUES ('W3503', 80.0, 35, 5, 1, NULL, 310000, 1, '2024-01-01', N'Đã bàn giao - trống', 'CD-A007');
INSERT INTO CanHo VALUES ('W3504', 80.0, 35, 5, 1, NULL, 1800000, 1, '2024-01-01', N'Đã bàn giao - trống', 'CD-A008');
INSERT INTO CanHo VALUES ('W3510', 80.0, 35, 5, 1, NULL, 18000000, 1, '2024-01-01', N'Chưa bàn giao - Cư dân đang ở', 'CD-A009');
select * from CanHo


-- Insert mẫu công việc
INSERT INTO CongViec VALUES('CV1', N'Quét nhà', '2024-04-08 9:12:00','2024-04-04 12:30:00',null, '2024-04-08 9:12:00',N'Chưa bắt đầu',null,2)
Insert into CongViec_NhanVien Values ('VS-003', 'CVVS1')
Insert INTO YeuCau VALUES('CV1', 'WPHA')
go


SELECT * FROM CongViec
SELECT * FROM CongViec_PDF
go
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
	@maBoPhan varchar(10),
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
		@maBoPhan,
        @maNhom
    )
end
go


-- Procedure lấy thông tin nhóm theo mã nhân viên
create procedure [dbo].[SP_LayNhomTheoMaNhanVien]
	@maNhanVien varchar(10)
as
begin
	select n.*
	from NhanVien nv
	inner join Nhom n on n.maNhom = nv.maNhom
	where nv.maNhanVien = @maNhanVien
end
go

select n.*
	from NhanVien nv
	inner join Nhom n on n.maNhom = nv.maNhom
	where nv.maNhanVien = 'AN-111'

select * from Nhom
select * from NhanVien

-- Procedure lấy thông tin phòng ban theo mã phòng ban
create procedure [dbo].[SP_LayPhongBanTheoMaNhom]
	@maNhom varchar(10)
as
begin
	select pb.*
	from Nhom n
	inner join PhongBan pb on pb.maBoPhan = n.maBoPhan
	where n.maNhom = @maNhom
end
go

--Lấy phòng ban theo mã nhân viên
create procedure [dbo].[SP_LayPhongBanTheoMaNhanVien]
	@maNhanVien varchar(10)
as
begin
	select pb.*
	from PhongBan pb
	inner join NhanVien nv on nv.maBoPhan = pb.maBoPhan
	where nv.maNhanVien = @maNhanVien
end


-- Procedure cập nhật thông tin nhân viên
create procedure [dbo].[SP_CapNhatNhanVien]
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
	@maBoPhan varchar(10),
    @maNhom varchar(10)
as
begin
    update NhanVien
    set email = @email,
        ho = @ho,
        ten = @ten,
        SDT = @SDT,
        ngaySinh = @ngaySinh,
        gioiTinh = @gioiTinh,
        queQuan = @queQuan,
        maDinhDanh = @maDinhDanh,
        loaiNhanVien = @loaiNhanVien,
        tinhTrangHonNhan = @tinhTrangHonNhan,
        maSoBHXH = @maSoBHXH,
        daTungLamNV = @daTungLamNV,
        ngayKyHDLD = @ngayKyHDLD,
        ngayHetHDLD = @ngayHetHDLD,
        dChiThuongTru = @dChiThuongTru,
        dChiTamTru = @dChiTamTru,
        tinhTrangHDLD = @tinhTrangHDLD,
		maBoPhan = @maBoPhan,
        maNhom = @maNhom
    where maNhanVien = @maNhanVien;
end
go

-- Procedure auto tự tạo mã công việc
CREATE PROCEDURE [dbo].[Auto_Create_Job]
    @nextJobId VARCHAR(10) OUTPUT
AS
BEGIN
    DECLARE @curNumOfJob INT;
    DECLARE @candidateId VARCHAR(10);
    DECLARE @found BIT = 0;

    -- Lấy số lượng công việc hiện tại
    SELECT @curNumOfJob = COUNT(maCongViec) FROM CongViec;

    -- Tạo mã công việc tiếp theo
    SET @candidateId = 'CV' + CAST(@curNumOfJob + 1 AS VARCHAR(3));

    -- Kiểm tra và tăng mã công việc cho đến khi không còn trùng
    WHILE @found = 0
    BEGIN
        -- Kiểm tra xem mã công việc có tồn tại không
        IF NOT EXISTS (SELECT 1 FROM CongViec WHERE maCongViec = @candidateId)
        BEGIN
            -- Nếu không tồn tại, gán giá trị cho @nextJobId và thoát khỏi vòng lặp
            SET @nextJobId = @candidateId;
            SET @found = 1;
        END
        ELSE
        BEGIN
            -- Nếu tồn tại, tăng mã công việc lên 1 và kiểm tra lại
            SET @curNumOfJob = @curNumOfJob + 1;
            SET @candidateId = 'CV' + CAST(@curNumOfJob + 1 AS VARCHAR(3));
        END
    END
END
--Declare @maCongViec Varchar(10) Exec Auto_Create_Job @maCongViec OUTPUT Print @maCongViec
go
-- Procedure Thêm Công Việc
CREATE PROCEDURE [dbo].[SP_ThemCongViec]
           @noiDung NVARCHAR(200),
           @ngayGiao SMALLDATETIME,
           @thoiHan SMALLDATETIME,
           @ngayHoanThanh SMALLDATETIME,
           @ngayCapNhat SMALLDATETIME,
           @trangThai NVARCHAR(100),
           @ghiChu NVARCHAR(200),
		   @quyenTruyCap int
AS
BEGIN
    DECLARE @maCongViec VARCHAR(10);
    -- Execute Auto_Create_Job to generate the next job ID
    EXEC [dbo].[Auto_Create_Job] @nextJobId = @maCongViec OUTPUT;
    
    -- Insert the new job into the CongViec table
    INSERT INTO CongViec (maCongViec, noiDung, ngayGiao, thoiHan, ngayHoanThanh, ngayCapNhat, trangThai, ghiChu, quyenTruyCap)
    VALUES (@maCongViec, @noiDung, @ngayGiao, @thoiHan, @ngayHoanThanh, @ngayCapNhat, @trangThai, @ghiChu, @quyenTruyCap);
END
go
	
-- Procedure Thêm CongViec_NhanVien
CREATE PROCEDURE [dbo].[ThemCongViec_NhanVien]
           @maNhanVien varchar(10),
		   @maCongViec varchar(10)
AS
BEGIN
    INSERT INTO Congviec_Nhanvien
    VALUES (
           @maNhanVien,
		   @maCongViec
    )
END
go
-- Procedure Thêm CongViec_Nhom
Create PROCEDURE [dbo].[ThemCongViec_Nhom]
           @maNhom varchar(10),
		   @maCongViec varchar(10)
AS
BEGIN
    INSERT INTO CongViec_Nhom
    VALUES (
           @maNhom,
		   @maCongViec
    )
END
go
-- Procedure Thêm CongViec_PhongBan
Create Procedure [dbo].[ThemCongViec_PhongBan]
		   @maCongViec varchar(10),
		   @maBoPhan varchar(10)
AS
BEGIN
    INSERT INTO Congviec_PhongBan
    VALUES (
		   @maCongViec,
		   @maBoPhan
    )
END
go
Create Procedure [dbo].[ThemyeuCau]
			@maCongViec varchar(10),
			@maCanHo varchar(10)
AS
BEGIN
	INSERT INTO YeuCau
    VALUES (
		   @maCongViec,
		   @maCanHo
    )
END
go

--Thêm file PDF
Create Procedure [dbo].[ThemFile]
			@maCongViec varchar(10),
			@pdfFile VARBINARY(MAX),
			@tenFile VARCHAR(50),
			@fileExten VARCHAR(10)
AS
BEGIN
	INSERT INTO CongViec_PDF
    VALUES (
		   @maCongViec,
		   @pdfFile,
		   @tenFile,
		   @fileExten
    )
END
go
-- Procedure Lấy dữ liệu công việc của nhân viên theo ngày
Create Procedure [dbo].[LayCongViecNVTheoNgay]
           @maNhanVien varchar(10),
		   @thoiHan SmallDateTime
AS
BEGIN
    Select CV.*
	From CongViec CV, Congviec_Nhanvien CNV
	Where CV.maCongViec = CNV.maCongViec and CNV.maNhanVien = @maNhanVien and CONVERT(date, CV.thoiHan) = @thoiHan
END
go

-- Procedure thêm tài khoản
create procedure [dbo].[SP_ThemTaiKhoan]
	@maNguoiDung varchar(30),
	@matKhau varchar(100),
	@maNhanVien varchar(10),
	@disable bit
as
begin
	insert into TaiKhoan
	values(@maNguoiDung,
		   @matKhau,
		   @maNhanVien,
		   @disable,
		   0)
end
go

-- Procedure sửa tài khoản nhân viên
create procedure [dbo].[SP_SuaTaiKhoan]
	@maNguoiDung varchar(30),
	@matKhau varchar(100),
	@maNhanVien varchar(10),
	@disable bit
as
begin
	update TaiKhoan
	set maNguoiDung = @maNguoiDung,
		matKhau = @matKhau,
		disable = @disable
	where maNhanVien = @maNhanVien
end
go

--Procedure thay đổi mật khẩu tài khoản
create procedure [dbo].[SP_DoiMatKhau]
	@maNguoiDung varchar(30),
	@matKhau varchar(100)
as
begin
	update TaiKhoan
	set matKhau = @matKhau
	where maNguoiDung = @maNguoiDung
end
go
-- Procedure Cập nhật Công Việc
Create Procedure [dbo].[SP_EditCongViec]
	@maCongViec Varchar(10),
	@noiDung NVARCHAR(200),
	@thoiHan SMALLDATETIME,
	@ngayHoanThanh SMALLDATETIME,
	@ngayCapNhat SMALLDATETIME,
	@trangThai NVARCHAR(100),
	@ghiChu NVARCHAR(200),
	@quyenTruyCap int
as
begin
	Update CongViec
	SET noiDung = @noiDung, thoiHan = @thoiHan, ngayHoanThanh = @ngayHoanThanh, ngayCapNhat = @ngayCapNhat, trangThai = @trangThai, ghiChu = @ghiChu, quyenTruyCap = @quyenTruyCap
	WHERE maCongViec = @maCongViec
end
go
Create Procedure [dbo].[SP_XoaCongViec_NhanVien]
	@maCongViec Varchar(10)
as
begin
	-- Xóa File công việc
	if Exists (Select * From CongViec_PDF Where maCongViec = @maCongViec)
	Begin
		Delete From CongViec_PDF
		Where maCongViec = @maCongViec
	End
	-- Xóa Yêu cầu Công việc
	Delete From YeuCau
	Where maCongViec = @maCongViec
	-- Xóa Công việc nhân viên
	Delete From Congviec_Nhanvien
	Where maCongViec = @maCongViec
	-- Xóa Công việc 
	Delete From CongViec
	Where maCongViec = @maCongViec
end
go


--Procedure thêm nhân viên
create procedure [dbo].[SP_ThemCanHo]
	@maCanHo varchar(10),
	@dienTich float,
	@viTriTang int,
	@soLuongPhongNgu int,
	@soLuongToilet int,
	@soDoMatBang image,
	@mucPhiQLHangThang int,
	@soLuongTheThangMay int,
	@lichSuGiaoDich Date,
	@tinhTrangGDHienTai varchar(100),
	@maCuDan varchar(10)
as
begin
	insert into CanHo
	values(
		@maCanHo,
		@dienTich,
		@viTriTang,
		@soLuongPhongNgu,
		@soLuongToilet,
		@soDoMatBang,
		@mucPhiQLHangThang,
		@soLuongTheThangMay,
		@lichSuGiaoDich,
		@tinhTrangGDHienTai,
		@maCuDan)
end
GO
-- Procedure thêm Nhóm
Create PROCEDURE [dbo].[SP_ThemNhom]
	@maNhom VARCHAR(10),
	@maTruongNhom VARCHAR(10),
	@maBoPhan VARCHAR(10)
AS
BEGIN
	INSERT INTO Nhom
	Values (@maNhom, @maTruongNhom, @maBoPhan)
END
GO
---Lấy danh sách nhân viên
CREATE PROCEDURE [dbo].[Count_Job_State]
AS
BEGIN
    SELECT NV.maNhanVien,
           NV.ho,
           NV.ten,
           NV.maBoPhan,
           ISNULL(TongCongViec.Count, 0) AS tongCongViec,
           ISNULL(HoanThanh.Count, 0) AS hoanThanh,
           ISNULL(ChuaBatDau.Count, 0) AS chuaBatDau,
           ISNULL(DangThucHien.Count, 0) AS dangThucHien,
           ISNULL(TreHan.Count, 0) AS treHan
    FROM NhanVien NV
        LEFT JOIN (
            SELECT maNhanVien, COUNT(*) AS Count
            FROM Congviec_Nhanvien CNV
            GROUP BY maNhanVien
        ) AS TongCongViec ON NV.maNhanVien = TongCongViec.maNhanVien
        LEFT JOIN (
            SELECT maNhanVien, COUNT(*) AS Count
            FROM Congviec_Nhanvien CNV
            JOIN CongViec CV ON CNV.maCongViec = CV.maCongViec
            WHERE CV.trangThai = N'Hoàn thành'
            GROUP BY maNhanVien
        ) AS HoanThanh ON NV.maNhanVien = HoanThanh.maNhanVien
        LEFT JOIN (
            SELECT maNhanVien, COUNT(*) AS Count
            FROM Congviec_Nhanvien CNV
            JOIN CongViec CV ON CNV.maCongViec = CV.maCongViec
            WHERE CV.trangThai = N'Chưa bắt đầu'
            GROUP BY maNhanVien
        ) AS ChuaBatDau ON NV.maNhanVien = ChuaBatDau.maNhanVien
        LEFT JOIN (
            SELECT maNhanVien, COUNT(*) AS Count
            FROM Congviec_Nhanvien CNV
            JOIN CongViec CV ON CNV.maCongViec = CV.maCongViec
            WHERE CV.trangThai = N'Đang thực hiện'
            GROUP BY maNhanVien
        ) AS DangThucHien ON NV.maNhanVien = DangThucHien.maNhanVien
        LEFT JOIN (
            SELECT maNhanVien, COUNT(*) AS Count
            FROM Congviec_Nhanvien CNV
            JOIN CongViec CV ON CNV.maCongViec = CV.maCongViec
            WHERE CV.trangThai = N'Trễ hạn'
            GROUP BY maNhanVien
        ) AS TreHan ON NV.maNhanVien = TreHan.maNhanVien;
END
GO

-- Tạo Trigger tự động kiểm tra tình trạng công việc
CREATE TRIGGER CheckLateJob
ON CongViec
AFTER UPDATE
AS
BEGIN
    -- Kiểm tra các bản ghi bị cập nhật
    IF UPDATE(trangThai) OR UPDATE(ngayHoanThanh) OR UPDATE(thoiHan)
    BEGIN
        -- Cập nhật trạng thái thành 'Trễ hạn' nếu trạng thái không phải 'Hoàn thành', ngày hoàn thành là NULL, và thời hạn đã qua hoặc ngày hoàn thành muộn hơn thời hạn
        UPDATE CongViec
        SET trangThai = N'Trễ hạn'
        WHERE (CAST(thoiHan AS datetime) < CAST(GETDATE() AS datetime) OR CAST(ngayHoanThanh AS datetime) > CAST(thoiHan AS datetime));
    END
END;

Select * From CongViec

---Lấy công việc của nhân viên
CREATE PROCEDURE [dbo].[Job_Of_Employees]
AS
BEGIN
	SELECT CongViec.maCongViec as N'Mã công việc', Congviec_Nhanvien.maNhanVien as N'Mã nhân viên', NhanVien.ho as N'Họ', NhanVien.ten as N'Tên', CongViec.noiDung as N'Nội dung', YeuCau.maCanHo as N'Mã căn hộ' ,CongViec.ngayGiao as N'Ngày giao', CongViec.ngayCapNhat as N'Ngày cập nhật', CongViec.thoiHan as N'Thời hạn', CongViec.ngayHoanThanh as N'Ngày hoàn thành', CongViec.trangThai as N'Trạng thái', CongViec.ghiChu as N'Ghi chú' 
	FROM NhanVien, CongViec, Congviec_Nhanvien, YeuCau 
	WHERE NhanVien.maNhanVien = Congviec_Nhanvien.maNhanVien and Congviec_Nhanvien.maCongViec=CongViec.maCongViec and YeuCau.maCongViec = CongViec.maCongViec;
END
GO

---Lấy công việc của nhóm
CREATE PROCEDURE [dbo].[Job_Of_Groups]
AS
BEGIN
	SELECT CongViec.maCongViec as N'Mã công việc', CongViec_Nhom.maNhom as N'Mã nhóm', Nhom.maTruongNhom as N'Mã Trưởng Nhóm', Nhom.maBoPhan as N'Mã Bộ phận', CongViec.noiDung as N'Nội dung', YeuCau.maCanHo as N'Mã căn hộ' ,CongViec.ngayGiao as N'Ngày giao', CongViec.ngayCapNhat as N'Ngày cập nhật', CongViec.thoiHan as N'Thời hạn', CongViec.ngayHoanThanh as N'Ngày hoàn thành', CongViec.trangThai as N'Trạng thái', CongViec.ghiChu as N'Ghi chú' 
	FROM Nhom, CongViec, Congviec_Nhom, YeuCau 
	WHERE Nhom.maNhom = Congviec_Nhom.maNhom and Congviec_Nhom.maCongViec=CongViec.maCongViec and YeuCau.maCongViec = CongViec.maCongViec;
END
GO
--Lấy công việc phòng ban
CREATE PROCEDURE [dbo].[Job_Of_Divisions]
AS
BEGIN
	SELECT CongViec.maCongViec as N'Mã công việc', Congviec_PhongBan.maBoPhan as N'Mã bộ phận', QuanLy.maNhanVien as N'Mã quản lý', CongViec.noiDung as N'Nội dung', YeuCau.maCanHo as N'Mã căn hộ' ,CongViec.ngayGiao as N'Ngày giao', CongViec.ngayCapNhat as N'Ngày cập nhật', CongViec.thoiHan as N'Thời hạn', CongViec.ngayHoanThanh as N'Ngày hoàn thành', CongViec.trangThai as N'Trạng thái', CongViec.ghiChu as N'Ghi chú' 
	FROM PhongBan, CongViec, Congviec_PhongBan, YeuCau, QuanLy
	WHERE PhongBan.maBoPhan = Congviec_PhongBan.maBoPhan and Congviec_PhongBan.maCongViec=CongViec.maCongViec and YeuCau.maCongViec = CongViec.maCongViec and QuanLy.maBoPhan = Congviec_PhongBan.maBoPhan;
END
GO
