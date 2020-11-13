create proc sp_loadLoaiDoUong
as
begin
	select * from tblLoaiDoUong
end

exec sp_loadLoaiDoUong

go
create proc sp_addDoUong
@ten nvarchar(100),
@gia money,
@fkLoai int
as
begin
	insert into tblDoUong(sTenDoUong, mGia, FK_LoaiDoUong) values(@ten, @gia, @fkLoai)
end

go
create proc sp_viewDoUong
@searchKey nvarchar(100)
as
begin
	if(@searchKey IS NOT NULL) OR (LEN(@searchKey) > 0)
		begin
			select * from tblDoUong inner join tblLoaiDoUong on FK_LoaiDoUong = PK_LoaiDoUong
			where sTenDoUong like '%' + @searchKey + '%'
			order by PK_DoUong desc
		end
	else
		begin
			select * from tblDoUong inner join tblLoaiDoUong on FK_LoaiDoUong = PK_LoaiDoUong
			order by PK_DoUong desc
		end
end

go
exec sp_viewDoUong ''

go 
create proc sp_editDoUong
@ma int,
@ten nvarchar(100),
@gia money,
@fkLoai int
as 
begin
	update tblDoUong
	set sTenDoUong = @ten, mGia = @gia, FK_LoaiDoUong = @fkLoai
	where tblDoUong.PK_DoUong = @ma
end

go 
create proc sp_deleteDoUong
@ma int
as
begin
	delete from tblDoUong where PK_DoUong = @ma
end

go
create proc sp_getIdLoaiDoUong
@ten nvarchar(100)
as
begin
	select tblLoaiDoUong.PK_LoaiDoUong from tblLoaiDoUong where sTenLoaiDoUong = @ten
end

exec sp_getIdLoaiDoUong N'Nước Ép'

-- PROCESSDURE NGUYÊN LIỆU
go
create proc sp_addNguyenLieu
@ten nvarchar(100),
@dvt nvarchar(50)
as
begin
	insert into tblNguyenLieu (sTenNguyenLieu, sDonViTinh) values(@ten, @dvt)
end

go
create proc sp_viewNguyenLieu
@key nvarchar(100)
as
begin
	if (@key is not null) or (len(@key) > 0)
	begin
		select * from tblNguyenLieu
		where sTenNguyenLieu like '%' + @key + '%'
		order by PK_NguyenLieu desc
	end

	else
	begin
		select * from tblNguyenLieu order by PK_NguyenLieu desc
	end
end

go
create proc sp_editNguyenLieu
@ma int,
@ten nvarchar(100),
@dvt nvarchar(50)
as
begin
	update tblNguyenLieu 
	set sTenNguyenLieu = @ten, sDonViTinh = @dvt
	where PK_NguyenLieu = @ma
end


go
create proc sp_deleteNguyenLieu
@ma int 
as
begin
	delete from tblNguyenLieu where PK_NguyenLieu = @ma
end

-- Đổi Mật khẩu 
go
alter proc sp_checkOldPassword
@username nvarchar(50),
@password nvarchar(50)
as
begin
	 select count(*) from tblTaiKhoan where sTenDangNhap = @username and sMatKhau = @password
end

exec sp_checkOldPassword 'admin', '1231234'

go 
create proc sp_changePassword
@username nvarchar(50),
@newpass nvarchar(50)
as
begin
	update tblTaiKhoan
	set sMatKhau = @newpass
	where sTenDangNhap = @username
end

-- Tài khoản
go
create proc checkPermission
@username nvarchar(50)
as
begin
	select tblTaiKhoan.FK_Quyen
	from tblTaiKhoan
	where sTenDangNhap = @username
end

go 
create proc sp_loadCmbRule
as
begin
	select * from tblQuyen
end

go

create proc sp_loadAccountData
@key nvarchar(50)
as
begin
	if (@key is not null) or (len(@key) > 0)
	begin
		select * from tblTaiKhoan inner join tblQuyen on FK_Quyen = PK_Quyen
		where sTenDangNhap like '%' + @key + '%'
		order by PK_TaiKhoan desc
	end

	else
	begin
		select * from tblTaiKhoan inner join tblQuyen on FK_Quyen = PK_Quyen order by PK_TaiKhoan desc
	end
end
exec sp_loadAccountData null








go
create proc sp_addAcount
@username nvarchar(50),
@password nvarchar(50),
@fkquyen int
as
begin
	insert into tblTaiKhoan (sTenDangNhap, sMatKhau, FK_MaNV, FK_Quyen)
	values (@username, @password, 1 , @fkquyen)
end

go
create proc sp_getIdLoaiTK
@username nvarchar(50)
as
begin
	select tblQuyen.PK_Quyen from tblQuyen where sTenQuyen = @username
end

exec sp_getIdLoaiTK N'ADMIN'

go
create proc sp_editTaiKhoan
@ma int,
@username nvarchar(50),
@password nvarchar(50),
@fkquyen int
as 
begin
	update tblTaiKhoan
	set sTenDangNhap = @username, sMatKhau = @password, FK_Quyen = @fkquyen
	where tblTaiKhoan.PK_TaiKhoan = @ma
end

go
create proc sp_deleteAccount
@ma int
as
begin
	delete from tblTaiKhoan where PK_TaiKhoan = @ma
end