USE [banhangsieuthi]
GO
/****** Object:  Table [dbo].[chitiepphieunhap]    Script Date: 11/26/2020 7:24:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chitiepphieunhap](
	[stt] [int] IDENTITY(1,1) NOT NULL,
	[manhap] [nvarchar](20) NULL,
	[mamathang] [nvarchar](20) NULL,
	[soluong] [int] NULL,
	[dongia] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[stt] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[chitiethoadon]    Script Date: 11/26/2020 7:24:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chitiethoadon](
	[stt] [int] IDENTITY(1,1) NOT NULL,
	[mahoadon] [nvarchar](20) NULL,
	[mamathang] [nvarchar](20) NULL,
	[soluong] [int] NULL,
	[dongia] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[stt] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[chitietphieugiaoca]    Script Date: 11/26/2020 7:24:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chitietphieugiaoca](
	[stt] [int] IDENTITY(1,1) NOT NULL,
	[magiaoca] [nvarchar](20) NULL,
	[mamathang] [nvarchar](20) NULL,
	[soluong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[stt] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[chitietphieuxuat]    Script Date: 11/26/2020 7:24:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chitietphieuxuat](
	[stt] [int] IDENTITY(1,1) NOT NULL,
	[maxuat] [nvarchar](20) NULL,
	[mamathang] [nvarchar](20) NULL,
	[soluong] [int] NULL,
	[dongia] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[stt] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[chucvu]    Script Date: 11/26/2020 7:24:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chucvu](
	[ma] [nvarchar](20) NOT NULL,
	[ten] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hoadon]    Script Date: 11/26/2020 7:24:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hoadon](
	[ma] [nvarchar](20) NOT NULL,
	[ngaylap] [datetime] NULL,
	[tonggiatri] [float] NULL,
	[thanhtien] [float] NULL,
	[manhanvien] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[khachhang]    Script Date: 11/26/2020 7:24:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[khachhang](
	[ma] [nvarchar](20) NOT NULL,
	[ten] [nvarchar](50) NOT NULL,
	[diachi] [nvarchar](200) NULL,
	[sodienthoai] [nvarchar](15) NULL,
	[uudai] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[khachmuahang]    Script Date: 11/26/2020 7:24:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[khachmuahang](
	[stt] [int] IDENTITY(1,1) NOT NULL,
	[makhachhang] [nvarchar](20) NULL,
	[mahoadon] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[stt] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[khohang]    Script Date: 11/26/2020 7:24:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[khohang](
	[ma] [nvarchar](20) NOT NULL,
	[ten] [nvarchar](50) NOT NULL,
	[diachi] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[mathang]    Script Date: 11/26/2020 7:24:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[mathang](
	[ma] [nvarchar](20) NOT NULL,
	[ten] [nvarchar](50) NOT NULL,
	[loaimathang] [nvarchar](50) NULL,
	[donvitinh] [nvarchar](10) NULL,
	[maquay] [nvarchar](20) NULL,
	[manhacc] [nvarchar](20) NULL,
	[gia] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nhacungcap]    Script Date: 11/26/2020 7:24:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhacungcap](
	[ma] [nvarchar](20) NOT NULL,
	[ten] [nvarchar](100) NOT NULL,
	[diachi] [nvarchar](200) NULL,
	[sodienthoai] [nvarchar](15) NULL,
	[email] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nhanvien]    Script Date: 11/26/2020 7:24:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhanvien](
	[ma] [nvarchar](20) NOT NULL,
	[ten] [nvarchar](50) NOT NULL,
	[ngaysinh] [datetime] NULL,
	[diachi] [nvarchar](200) NULL,
	[sodienthoai] [nvarchar](15) NULL,
	[machucvu] [nvarchar](20) NULL,
	[taikhoan] [nvarchar](50) NULL,
	[matkhau] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[phieugiaoca]    Script Date: 11/26/2020 7:24:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[phieugiaoca](
	[ma] [nvarchar](20) NOT NULL,
	[ngay] [datetime] NULL,
	[ca] [int] NULL,
	[maquay] [nvarchar](20) NULL,
	[manhanvien] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[phieukiemke]    Script Date: 11/26/2020 7:24:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[phieukiemke](
	[ma] [nvarchar](20) NOT NULL,
	[ngaylap] [datetime] NULL,
	[mamathang] [nvarchar](20) NULL,
	[soluong] [int] NULL,
	[manhanvien] [nvarchar](20) NULL,
	[makhohang] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[phieunhapkho]    Script Date: 11/26/2020 7:24:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[phieunhapkho](
	[ma] [nvarchar](20) NOT NULL,
	[makhohang] [nvarchar](20) NULL,
	[ngaynhap] [datetime] NULL,
	[tonggiatri] [float] NULL,
	[manhacungcap] [nvarchar](20) NULL,
	[manhanvien] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[phieuxuatkho]    Script Date: 11/26/2020 7:24:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[phieuxuatkho](
	[ma] [nvarchar](20) NOT NULL,
	[ngayxuat] [datetime] NULL,
	[tonggiatri] [float] NULL,
	[makhohang] [nvarchar](20) NULL,
	[manhanvien] [nvarchar](20) NULL,
	[maquay] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[quayhang]    Script Date: 11/26/2020 7:24:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[quayhang](
	[ma] [nvarchar](20) NOT NULL,
	[ten] [nvarchar](50) NOT NULL,
	[vitri] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[chitiepphieunhap] ON 
GO
INSERT [dbo].[chitiepphieunhap] ([stt], [manhap], [mamathang], [soluong], [dongia]) VALUES (1, N'PN01', N'MH01', 10, 12000)
GO
SET IDENTITY_INSERT [dbo].[chitiepphieunhap] OFF
GO
SET IDENTITY_INSERT [dbo].[chitiethoadon] ON 
GO
INSERT [dbo].[chitiethoadon] ([stt], [mahoadon], [mamathang], [soluong], [dongia]) VALUES (1, N'HD01', N'MH01', 1, 12000)
GO
SET IDENTITY_INSERT [dbo].[chitiethoadon] OFF
GO
SET IDENTITY_INSERT [dbo].[chitietphieugiaoca] ON 
GO
INSERT [dbo].[chitietphieugiaoca] ([stt], [magiaoca], [mamathang], [soluong]) VALUES (1, N'GC01', N'MH01', 100)
GO
SET IDENTITY_INSERT [dbo].[chitietphieugiaoca] OFF
GO
SET IDENTITY_INSERT [dbo].[chitietphieuxuat] ON 
GO
INSERT [dbo].[chitietphieuxuat] ([stt], [maxuat], [mamathang], [soluong], [dongia]) VALUES (5, N'PX01', N'MH01', 10, 13000)
GO
SET IDENTITY_INSERT [dbo].[chitietphieuxuat] OFF
GO
INSERT [dbo].[chucvu] ([ma], [ten]) VALUES (N'CV01', N'tổ trưởng')
GO
INSERT [dbo].[chucvu] ([ma], [ten]) VALUES (N'CV02', N'nhân viên')
GO
INSERT [dbo].[chucvu] ([ma], [ten]) VALUES (N'CV03', N'nhân viên bán hàng')
GO
INSERT [dbo].[chucvu] ([ma], [ten]) VALUES (N'CV04', N'nhân viên thu ngân')
GO
INSERT [dbo].[hoadon] ([ma], [ngaylap], [tonggiatri], [thanhtien], [manhanvien]) VALUES (N'HD01', CAST(N'2020-10-10T00:00:00.000' AS DateTime), 300000, 300000, N'NV02')
GO
INSERT [dbo].[hoadon] ([ma], [ngaylap], [tonggiatri], [thanhtien], [manhanvien]) VALUES (N'HD02', CAST(N'2020-10-01T00:00:00.000' AS DateTime), 1000000, 1000000, N'NV03')
GO
INSERT [dbo].[khachhang] ([ma], [ten], [diachi], [sodienthoai], [uudai]) VALUES (N'KH01', N'Nguyễn Anh Dũng', N'Hà Nội', N'123456789', 0.1)
GO
INSERT [dbo].[khachhang] ([ma], [ten], [diachi], [sodienthoai], [uudai]) VALUES (N'KH02', N'Nguyễn Anh Dũng', N'Hà Tĩnh', N'123456789', 0.1)
GO
INSERT [dbo].[khachhang] ([ma], [ten], [diachi], [sodienthoai], [uudai]) VALUES (N'KH03', N'Mai Ngọc Long', N'Hà Nội', N'12345678', 0.5)
GO
INSERT [dbo].[khachhang] ([ma], [ten], [diachi], [sodienthoai], [uudai]) VALUES (N'KH04', N'Nguyễn Thị Thanh Thuỳ', N'Vũng Tàu', N'098765432', 0)
GO
INSERT [dbo].[khachhang] ([ma], [ten], [diachi], [sodienthoai], [uudai]) VALUES (N'KH05', N'Huỳnh Văn Tá', N'H?u Giang', N'098756789', 0.8)
GO
INSERT [dbo].[khachhang] ([ma], [ten], [diachi], [sodienthoai], [uudai]) VALUES (N'KH06', N'Phạm Trọng Linh', N'Hà Nội', N'033768980', 0)
GO
INSERT [dbo].[khachhang] ([ma], [ten], [diachi], [sodienthoai], [uudai]) VALUES (N'KH07', N'Nguyễn Ngọc Anh', N'Nam Định', N'098768986', 0)
GO
SET IDENTITY_INSERT [dbo].[khachmuahang] ON 
GO
INSERT [dbo].[khachmuahang] ([stt], [makhachhang], [mahoadon]) VALUES (1, N'KH01', N'HD01')
GO
INSERT [dbo].[khachmuahang] ([stt], [makhachhang], [mahoadon]) VALUES (3, N'KH02', N'HD02')
GO
SET IDENTITY_INSERT [dbo].[khachmuahang] OFF
GO
INSERT [dbo].[khohang] ([ma], [ten], [diachi]) VALUES (N'K01', N'Kho 1', N'Đống Đa')
GO
INSERT [dbo].[khohang] ([ma], [ten], [diachi]) VALUES (N'K02', N'Kho 2', N'Hà Đông')
GO
INSERT [dbo].[mathang] ([ma], [ten], [loaimathang], [donvitinh], [maquay], [manhacc], [gia]) VALUES (N'MH01', N'Rau cải ngọt', N'Rau củ', N'cân', N'Q01', N'NCC02', 12000)
GO
INSERT [dbo].[mathang] ([ma], [ten], [loaimathang], [donvitinh], [maquay], [manhacc], [gia]) VALUES (N'MH02', N'tôm đông lạnh', N'Ướp lạnh', N'hộp', N'Q01', N'NCC01', 50000)
GO
INSERT [dbo].[mathang] ([ma], [ten], [loaimathang], [donvitinh], [maquay], [manhacc], [gia]) VALUES (N'MH03', N'bào ngư', N'Hải sản', N'cân', N'Q01', N'NCC01', 10000)
GO
INSERT [dbo].[mathang] ([ma], [ten], [loaimathang], [donvitinh], [maquay], [manhacc], [gia]) VALUES (N'MH04', N'gà', N'Gia cầm', N'cân', N'Q02', NULL, NULL)
GO
INSERT [dbo].[mathang] ([ma], [ten], [loaimathang], [donvitinh], [maquay], [manhacc], [gia]) VALUES (N'MH05', N'bò khô', N'Đồ khô', N'gói', N'Q02', NULL, NULL)
GO
INSERT [dbo].[mathang] ([ma], [ten], [loaimathang], [donvitinh], [maquay], [manhacc], [gia]) VALUES (N'MH06', N'cá hộp', N'Đồ hộp', N'hộp', N'Q02', NULL, NULL)
GO
INSERT [dbo].[mathang] ([ma], [ten], [loaimathang], [donvitinh], [maquay], [manhacc], [gia]) VALUES (N'MH07', N'tiêu', N'Gia vị', N'lọ', N'Q02', NULL, NULL)
GO
INSERT [dbo].[mathang] ([ma], [ten], [loaimathang], [donvitinh], [maquay], [manhacc], [gia]) VALUES (N'MH08', N'Rau cải đắng', N'Rau củ', N'Cân', N'Q01', N'NCC01', 12000)
GO
INSERT [dbo].[nhacungcap] ([ma], [ten], [diachi], [sodienthoai], [email]) VALUES (N'NCC01', N'Chinsu', N'Hạ Long', N'12345', N'chinsuhalong@gmail.com')
GO
INSERT [dbo].[nhacungcap] ([ma], [ten], [diachi], [sodienthoai], [email]) VALUES (N'NCC02', N'Aloha', N'Ninh Bình', N'123', N'aloha')
GO
INSERT [dbo].[nhacungcap] ([ma], [ten], [diachi], [sodienthoai], [email]) VALUES (N'NCC03', N'VEDAN', N'Hà Nội', N'033456789', N'vedan')
GO
INSERT [dbo].[nhanvien] ([ma], [ten], [ngaysinh], [diachi], [sodienthoai], [machucvu], [taikhoan], [matkhau]) VALUES (N'NV01', N'Kim Khánh', CAST(N'2020-01-01T00:00:00.000' AS DateTime), N'Hà Nội', N'012345678', N'CV01', N'admin', N'admin')
GO
INSERT [dbo].[nhanvien] ([ma], [ten], [ngaysinh], [diachi], [sodienthoai], [machucvu], [taikhoan], [matkhau]) VALUES (N'NV02', N'Mai Anh Đào', CAST(N'1999-01-13T00:00:00.000' AS DateTime), N'Hà Nội', N'1234567', N'CV02', N'anhdao', N'anhdao')
GO
INSERT [dbo].[nhanvien] ([ma], [ten], [ngaysinh], [diachi], [sodienthoai], [machucvu], [taikhoan], [matkhau]) VALUES (N'NV03', N'Nguyễn Anh Dũng', CAST(N'1999-02-13T00:00:00.000' AS DateTime), N'Hà Nội', N'032456789', N'CV02', N'anhdung', N'123')
GO
INSERT [dbo].[nhanvien] ([ma], [ten], [ngaysinh], [diachi], [sodienthoai], [machucvu], [taikhoan], [matkhau]) VALUES (N'NV04', N'Lê Thị Linh', CAST(N'1999-02-05T00:00:00.000' AS DateTime), N'Thái Nguyên', N'0367654321', N'CV02', N'lelinh', N'123')
GO
INSERT [dbo].[nhanvien] ([ma], [ten], [ngaysinh], [diachi], [sodienthoai], [machucvu], [taikhoan], [matkhau]) VALUES (N'NV05', N'Lê Anh Thắng', CAST(N'1999-10-16T00:00:00.000' AS DateTime), N'Quảng Trị', N'033456723', N'CV02', N'anhthang', N'123')
GO
INSERT [dbo].[nhanvien] ([ma], [ten], [ngaysinh], [diachi], [sodienthoai], [machucvu], [taikhoan], [matkhau]) VALUES (N'NV06', N'Bùi Văn Dương', CAST(N'1999-07-10T00:00:00.000' AS DateTime), N'Thanh Hoá', N'098765432', N'CV03', N'duongbui', N'123')
GO
INSERT [dbo].[phieugiaoca] ([ma], [ngay], [ca], [maquay], [manhanvien]) VALUES (N'GC01', CAST(N'2019-01-01T00:00:00.000' AS DateTime), 1, N'Q01', N'NV01')
GO
INSERT [dbo].[phieukiemke] ([ma], [ngaylap], [mamathang], [soluong], [manhanvien], [makhohang]) VALUES (N'PKK01', CAST(N'2020-01-01T00:00:00.000' AS DateTime), N'MH01', 100, N'NV02', N'K01')
GO
INSERT [dbo].[phieukiemke] ([ma], [ngaylap], [mamathang], [soluong], [manhanvien], [makhohang]) VALUES (N'PKK02', CAST(N'2020-01-01T00:00:00.000' AS DateTime), N'MH02', 200, N'NV01', N'K01')
GO
INSERT [dbo].[phieunhapkho] ([ma], [makhohang], [ngaynhap], [tonggiatri], [manhacungcap], [manhanvien]) VALUES (N'PN01', N'K02', CAST(N'2019-01-12T00:00:00.000' AS DateTime), 12000000, N'NCC01', N'NV04')
GO
INSERT [dbo].[phieuxuatkho] ([ma], [ngayxuat], [tonggiatri], [makhohang], [manhanvien], [maquay]) VALUES (N'PX01', CAST(N'2020-01-02T00:00:00.000' AS DateTime), 13000000, N'K01', N'NV03', N'Q01')
GO
INSERT [dbo].[quayhang] ([ma], [ten], [vitri]) VALUES (N'Q01', N'Quầy 1', N'Tang 1')
GO
INSERT [dbo].[quayhang] ([ma], [ten], [vitri]) VALUES (N'Q02', N'Quầy 2', N'Tang 2')
GO
ALTER TABLE [dbo].[chitiepphieunhap]  WITH CHECK ADD FOREIGN KEY([mamathang])
REFERENCES [dbo].[mathang] ([ma])
GO
ALTER TABLE [dbo].[chitiepphieunhap]  WITH CHECK ADD FOREIGN KEY([manhap])
REFERENCES [dbo].[phieunhapkho] ([ma])
GO
ALTER TABLE [dbo].[chitiethoadon]  WITH CHECK ADD FOREIGN KEY([mahoadon])
REFERENCES [dbo].[hoadon] ([ma])
GO
ALTER TABLE [dbo].[chitiethoadon]  WITH CHECK ADD FOREIGN KEY([mamathang])
REFERENCES [dbo].[mathang] ([ma])
GO
ALTER TABLE [dbo].[chitietphieugiaoca]  WITH CHECK ADD FOREIGN KEY([magiaoca])
REFERENCES [dbo].[phieugiaoca] ([ma])
GO
ALTER TABLE [dbo].[chitietphieugiaoca]  WITH CHECK ADD FOREIGN KEY([mamathang])
REFERENCES [dbo].[mathang] ([ma])
GO
ALTER TABLE [dbo].[chitietphieuxuat]  WITH CHECK ADD FOREIGN KEY([maxuat])
REFERENCES [dbo].[phieuxuatkho] ([ma])
GO
ALTER TABLE [dbo].[hoadon]  WITH CHECK ADD FOREIGN KEY([manhanvien])
REFERENCES [dbo].[nhanvien] ([ma])
GO
ALTER TABLE [dbo].[khachmuahang]  WITH CHECK ADD FOREIGN KEY([mahoadon])
REFERENCES [dbo].[hoadon] ([ma])
GO
ALTER TABLE [dbo].[khachmuahang]  WITH CHECK ADD FOREIGN KEY([makhachhang])
REFERENCES [dbo].[khachhang] ([ma])
GO
ALTER TABLE [dbo].[mathang]  WITH CHECK ADD FOREIGN KEY([maquay])
REFERENCES [dbo].[quayhang] ([ma])
GO
ALTER TABLE [dbo].[mathang]  WITH CHECK ADD  CONSTRAINT [FK_mathang_nhacungcap1] FOREIGN KEY([manhacc])
REFERENCES [dbo].[nhacungcap] ([ma])
GO
ALTER TABLE [dbo].[mathang] CHECK CONSTRAINT [FK_mathang_nhacungcap1]
GO
ALTER TABLE [dbo].[nhanvien]  WITH CHECK ADD FOREIGN KEY([machucvu])
REFERENCES [dbo].[chucvu] ([ma])
GO
ALTER TABLE [dbo].[phieugiaoca]  WITH CHECK ADD FOREIGN KEY([manhanvien])
REFERENCES [dbo].[nhanvien] ([ma])
GO
ALTER TABLE [dbo].[phieugiaoca]  WITH CHECK ADD FOREIGN KEY([maquay])
REFERENCES [dbo].[quayhang] ([ma])
GO
ALTER TABLE [dbo].[phieukiemke]  WITH CHECK ADD FOREIGN KEY([makhohang])
REFERENCES [dbo].[khohang] ([ma])
GO
ALTER TABLE [dbo].[phieukiemke]  WITH CHECK ADD FOREIGN KEY([mamathang])
REFERENCES [dbo].[mathang] ([ma])
GO
ALTER TABLE [dbo].[phieukiemke]  WITH CHECK ADD FOREIGN KEY([manhanvien])
REFERENCES [dbo].[nhanvien] ([ma])
GO
ALTER TABLE [dbo].[phieunhapkho]  WITH CHECK ADD FOREIGN KEY([makhohang])
REFERENCES [dbo].[khohang] ([ma])
GO
ALTER TABLE [dbo].[phieunhapkho]  WITH CHECK ADD FOREIGN KEY([manhacungcap])
REFERENCES [dbo].[nhacungcap] ([ma])
GO
ALTER TABLE [dbo].[phieunhapkho]  WITH CHECK ADD FOREIGN KEY([manhanvien])
REFERENCES [dbo].[nhanvien] ([ma])
GO
ALTER TABLE [dbo].[phieuxuatkho]  WITH CHECK ADD FOREIGN KEY([makhohang])
REFERENCES [dbo].[khohang] ([ma])
GO
ALTER TABLE [dbo].[phieuxuatkho]  WITH CHECK ADD FOREIGN KEY([manhanvien])
REFERENCES [dbo].[nhanvien] ([ma])
GO
ALTER TABLE [dbo].[phieuxuatkho]  WITH CHECK ADD FOREIGN KEY([maquay])
REFERENCES [dbo].[quayhang] ([ma])
GO
/****** Object:  StoredProcedure [dbo].[sp_dangnhap]    Script Date: 11/26/2020 7:24:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_dangnhap] @username nvarchar(50), @password nvarchar(50)
as
begin
	select taikhoan, matkhau from nhanvien where
	taikhoan=@username and matkhau=@password
end 
GO
create trigger xoagiaoca on phieugiaoca instead of delete
as
begin
  declare @ma nvarchar(20)
  select @ma = ma
  from deleted
  delete chitietphieugiaoca where magiaoca = @ma
  
end