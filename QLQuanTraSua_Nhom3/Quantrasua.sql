create database db_Quantrasua
use db_Quantrasua

create table tblLoaiDoUong
(
	PK_LoaiDoUong int identity (1,1) primary key,
	sTenLoaiDoUong nvarchar (100)
);
create table tblDoUong
(
	PK_DoUong int identity (1,1) primary key,
	sTenDoUong nvarchar (100),
	mGia money,
	FK_LoaiDoUong int
);
create table tblTopping
(
	PK_Topping int identity (1,1) primary key,
	sTenTopping nvarchar (100),
	mGia money
);
create table tblNguyenLieu
(
	PK_NguyenLieu int identity (1,1) primary key,
	sTenNguyenLieu nvarchar (100)
);
alter table tblNguyenLieu add sDonViTinh nvarchar (50)

create table tblQuyen
(
	PK_Quyen int identity (1,1) primary key,
	sTenQuyen nvarchar (50)
);
create table tblNhanVien
(
	PK_MaNV int identity (1,1) primary key,
	sTenNV nvarchar (50),
	dNgaySinh date,
	sGioiTinh nvarchar (10),
	sSDT nvarchar (10)
);
create table tblTaiKhoan
(
	PK_TaiKhoan int identity (1,1) primary key,
	sTenDangNhap nvarchar (50),
	sMatKhau nvarchar (50),
	FK_MaNV int not null,
	FK_Quyen int not null
);
create table tblNhaCungCap
(
	PK_NCC int identity (1,1) primary key,
	sTenNCC nvarchar (100),
	sDiaChi nvarchar (255),
	sSDT nvarchar (10)
);
create table tblP_YeuCauNNL
(
	PK_PYCNNL int identity (1,1) primary key,
	FK_MaNV int not null,
	FK_NCC int not null,
	dTGLap datetime
);
create table tblCT_PYCNNL
(
	FK_PYCNNL int not null,
	FK_NguyenLieu int not null,
	iSoLuong int
);
create table tblPhieuNhap
(
	PK_PhieuNhap int identity (1,1) primary key,
	FK_NCC int not null,
	FK_MaNV int not null,
	dTGLap datetime
);
create table tblCT_PhieuNhap
(
	FK_PhieuNhap int not null,
	FK_NguyenLieu int not null,
	iSoLuong int,
	mGia money
);
create table tblHoaDon
(
	PK_SoHD int identity (1,1) primary key,
	dNgayLap date,
	FK_MaNV int not null,
	iSoBan int
);
create table tblCT_HoaDon
(
	FK_SoHD int not null,
	FK_DoUong int not null,
	FK_Topping int not null,
	iSoLuongDouong int,
	iSoLuongTopping int,
	sGhiChu nvarchar (255)
);

create table tblTopping_DoUong
(
	FK_DoUong int not null,
	FK_Topping int not null,
);
create table tblTopping_HoaDon
(
	FK_SoHD int not null,
	FK_Topping int not null,
	iSoLuongTopping int
);

alter table tblDoUong add constraint FK_DU_LDU foreign key (FK_LoaiDoUong) references tblLoaiDoUong(PK_LoaiDoUong)

alter table tblTaiKhoan add constraint FK_TK_NV foreign key (FK_MaNV) references tblNhanVien(PK_MaNV)
alter table tblTaiKhoan add constraint FK_TK_Q foreign key (FK_Quyen) references tblQuyen(PK_Quyen)

alter table tblP_YeuCauNNL add constraint FK_YCNNL_NV foreign key (FK_MaNV) references tblNhanVien(PK_MaNV)
alter table tblP_YeuCauNNL add constraint FK_YCNNL_NCC foreign key (FK_NCC) references tblNhaCungCap(PK_NCC)

alter table tblCT_PYCNNL add constraint PK_CTYCNNL primary key (FK_PYCNNL,FK_NguyenLieu);
alter table tblCT_PYCNNL add constraint FK_CTYCNNL_YCNNL foreign key (FK_PYCNNL) references tblP_YeuCauNNL(PK_PYCNNL)
alter table tblCT_PYCNNL add constraint FK_CTYCNNL_NL foreign key (FK_NguyenLieu) references tblNguyenLieu(PK_NguyenLieu)

alter table tblPhieuNhap add constraint FK_PN_NV foreign key (FK_MaNV) references tblNhanVien(PK_MaNV)
alter table tblPhieuNhap add constraint FK_PN_NCC foreign key (FK_NCC) references tblNhaCungCap(PK_NCC)

alter table tblCT_PhieuNhap add constraint PK_CTPN primary key (FK_PhieuNhap,FK_NguyenLieu);
alter table tblCT_PhieuNhap add constraint FK_CTPN_PN foreign key (FK_PhieuNhap) references tblPhieuNhap(PK_PhieuNhap)
alter table tblCT_PhieuNhap add constraint FK_CTPN_NL foreign key (FK_NguyenLieu) references tblNguyenLieu(PK_NguyenLieu)

alter table tblHoaDon add constraint FK_HD_NV foreign key (FK_MaNV) references tblNhanVien(PK_MaNV)

alter table tblCT_HoaDon add constraint PK_CTHD primary key (FK_SoHD,FK_DoUong,FK_Topping);
alter table tblCT_HoaDon add constraint FK_CTHD_DU foreign key (FK_DoUong) references tblDoUong(PK_DoUong)
alter table tblCT_HoaDon add constraint FK_CTHD_HD foreign key (FK_SoHD) references tblHoaDon(PK_SoHD)
alter table tblCT_HoaDon add constraint FK_CTHD_TP foreign key (FK_Topping) references tblTopping(PK_Topping)

alter table tblTopping_DoUong add constraint PK_Topping_DoUong primary key (FK_DoUong,FK_Topping);
alter table tblTopping_DoUong add constraint FK_Topping_Douong_DU foreign key (FK_DoUong) references tblDoUong(PK_DoUong)
alter table tblTopping_DoUong add constraint FK_Topping_DoUong_TP foreign key (FK_Topping) references tblTopping(PK_Topping)

alter table tblTopping_HoaDon add constraint PK_Topping_HoaDon primary key (FK_Topping,FK_SoHD );
alter table tblTopping_HoaDon add constraint FK_Topping_HoaDon_HD foreign key (FK_SoHD ) references tblHoaDon(PK_SoHD )
alter table tblTopping_HoaDon add constraint FK_Topping_HoaDon_TP foreign key (FK_Topping) references tblTopping(PK_Topping)

-- tạo proc đăng nhập
create proc sp_dangnhap
@taikhoan nvarchar(255),
@matkhau nvarchar(255)
as
begin
	select * from tblTaiKhoan where sTenDangNhap = @taikhoan and sMatKhau = @matkhau;
end
