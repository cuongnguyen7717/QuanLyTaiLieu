create database QUANLYTAILIEU
use QUANLYTAILIEU

create table NHANVIEN
([ MÃ NHÂN VIÊN ] nvarchar(10) primary key,
 [ TÊN NHÂN VIÊN ] nvarchar(50),
[ SỐ ĐIỆN THOẠI ] nvarchar(15),
[ CHỨC VỤ ] nvarchar(50),
[ PHÒNG BAN ] nvarchar(50),
[ ĐỊA CHỈ ] nvarchar(200),
)
create table TAILIEU
(
[ MÃ TÀI LIỆU ] nvarchar(20),
[ MÔ TẢ ] nvarchar(50) ,
[ TÊN TÀI LIỆU ] nvarchar(50) ,
[ LOẠI TÀI LIỆU ] nvarchar(100) foreign key references LOAITAILIEU ([ LOẠI TÀI LIỆU ]),
[ URL ] nvarchar(200),
[ NGÀY ] datetime,
[ NGƯỜI ĐĂNG ] nvarchar(100),
primary key ([ MÃ TÀI LIỆU ]),
)

create table LOAITAILIEU
([ MÃ LOẠI ] nvarchar(10) ,
[ LOẠI TÀI LIỆU ] nvarchar(100) primary key ,
[ GHI CHÚ ] nvarchar(100) ,
)

create table TAIKHOAN(
[ TÀI KHOẢN ] nvarchar(50) primary key,
[ MẬT KHẨU ] nvarchar(50),
[ QUYỀN ] nvarchar(30)
)