CREATE DATABASE QLBH
USE [QLBH]
GO
/****** Object:  Table [dbo].[CTHD]    Script Date: 11/23/2022 11:23:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTHD](
	[MaHoaDon] [char](10) NOT NULL,
	[MaMonAn] [char](10) NOT NULL,
	[DonGia] [int] NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [CTHD_pk] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC,
	[MaMonAn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 11/23/2022 11:23:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHoaDon] [char](10) NOT NULL,
	[MaNV] [char](10) NULL,
	[NgayHoaDon] [date] NULL,
	[ThanhTien] [int] NULL,
 CONSTRAINT [HD_MHD_PK] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiMonAn]    Script Date: 11/23/2022 11:23:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiMonAn](
	[MaLoaiMonAn] [char](10) NOT NULL,
	[TenLoaiMonAn] [nvarchar](50) NULL,
 CONSTRAINT [LMA_MALMA_PK] PRIMARY KEY CLUSTERED 
(
	[MaLoaiMonAn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonAn]    Script Date: 11/23/2022 11:23:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonAn](
	[MaMonAn] [char](10) NOT NULL,
	[TenMonAn] [nvarchar](100) NULL,
	[MaLoaiMonAn] [char](10) NULL,
 CONSTRAINT [MonAn_MMA_PK] PRIMARY KEY CLUSTERED 
(
	[MaMonAn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NV]    Script Date: 11/23/2022 11:23:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NV](
	[MaNV] [char](10) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[NamSinh] [date] NULL,
	[DiaChi] [nvarchar](100) NULL,
	[SDT] [nvarchar](15) NULL,
	[NCL] [date] NULL,
	[Luong] [int] NULL,
 CONSTRAINT [NV_MNV_PK] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 11/23/2022 11:23:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[TenTaiKhoan] [varchar](20) NOT NULL,
	[MatKhau] [varchar](15) NOT NULL,
	[HovaTen] [nvarchar](20) NOT NULL,
	[ChucVu] [nvarchar](20) NOT NULL,
 CONSTRAINT [TaiKhoan_ID_PK] PRIMARY KEY CLUSTERED 
(
	[TenTaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CTHD] ([MaHoaDon], [MaMonAn], [DonGia], [SoLuong]) VALUES (N'H01       ', N'1         ', 10000, 10)
INSERT [dbo].[CTHD] ([MaHoaDon], [MaMonAn], [DonGia], [SoLuong]) VALUES (N'H01       ', N'2         ', 20000, 10)
INSERT [dbo].[CTHD] ([MaHoaDon], [MaMonAn], [DonGia], [SoLuong]) VALUES (N'H01       ', N'3         ', 10000, 10)
GO
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaNV], [NgayHoaDon], [ThanhTien]) VALUES (N'H01       ', N'N01       ', CAST(N'2022-11-17' AS Date), 0)
GO
INSERT [dbo].[LoaiMonAn] ([MaLoaiMonAn], [TenLoaiMonAn]) VALUES (N'D01       ', N'Nước uống')
INSERT [dbo].[LoaiMonAn] ([MaLoaiMonAn], [TenLoaiMonAn]) VALUES (N'D02       ', N'Tráng miệng')
INSERT [dbo].[LoaiMonAn] ([MaLoaiMonAn], [TenLoaiMonAn]) VALUES (N'M01       ', N'Món chính')
GO
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [MaLoaiMonAn]) VALUES (N'1         ', N'Bánh mì', N'M01       ')
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [MaLoaiMonAn]) VALUES (N'2         ', N'Cơm sườn', N'M01       ')
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [MaLoaiMonAn]) VALUES (N'3         ', N'Nước suối', N'D01       ')
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [MaLoaiMonAn]) VALUES (N'4         ', N'Nước ngọt', N'D01       ')
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [MaLoaiMonAn]) VALUES (N'5         ', N'Bánh flan', N'D02       ')
INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [MaLoaiMonAn]) VALUES (N'6         ', N'Kem', N'D02       ')
GO
INSERT [dbo].[NV] ([MaNV], [HoTen], [NamSinh], [DiaChi], [SDT], [NCL], [Luong]) VALUES (N'N01       ', N'Nguyễn Văn A', CAST(N'2000-02-01' AS Date), N'Tp Hồ Chí Minh', N'821031245', CAST(N'2021-01-02' AS Date), 3000000)
INSERT [dbo].[NV] ([MaNV], [HoTen], [NamSinh], [DiaChi], [SDT], [NCL], [Luong]) VALUES (N'N02       ', N'Nguyễn Văn B', CAST(N'2002-05-07' AS Date), N'Hà Nội', N'721030945', CAST(N'2022-03-04' AS Date), 2500000)
INSERT [dbo].[NV] ([MaNV], [HoTen], [NamSinh], [DiaChi], [SDT], [NCL], [Luong]) VALUES (N'N03       ', N'Nguyễn Văn C', CAST(N'2001-03-05' AS Date), N'Vĩnh Long', N'921031245', CAST(N'2022-05-06' AS Date), 3250000)
INSERT [dbo].[NV] ([MaNV], [HoTen], [NamSinh], [DiaChi], [SDT], [NCL], [Luong]) VALUES (N'N04       ', N'Nguyễn Văn D', CAST(N'2000-06-09' AS Date), N'Đăk Lăk', N'394851254', CAST(N'2022-07-08' AS Date), 4500000)
GO
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [MatKhau], [HovaTen], [ChucVu]) VALUES (N'Admin', N'Admin', N'Nguyễn Văn Thuận', N'Nhân viên')
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [MatKhau], [HovaTen], [ChucVu]) VALUES (N'Bao', N'Bao', N'Võ Hoài Bảo', N'Nhân viên')
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [MatKhau], [HovaTen], [ChucVu]) VALUES (N'Huy', N'Huy', N'Lê Hoàng Huy', N'Nhân viên')
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [MatKhau], [HovaTen], [ChucVu]) VALUES (N'Nhut', N'Nhut', N'Trương Minh Nhựt', N'Nhân viên')
GO
ALTER TABLE [dbo].[CTHD]  WITH CHECK ADD  CONSTRAINT [CTDH_MHD_FK] FOREIGN KEY([MaHoaDon])
REFERENCES [dbo].[HoaDon] ([MaHoaDon])
GO
ALTER TABLE [dbo].[CTHD] CHECK CONSTRAINT [CTDH_MHD_FK]
GO
ALTER TABLE [dbo].[CTHD]  WITH CHECK ADD  CONSTRAINT [CTDH_MMA_FK] FOREIGN KEY([MaMonAn])
REFERENCES [dbo].[MonAn] ([MaMonAn])
GO
ALTER TABLE [dbo].[CTHD] CHECK CONSTRAINT [CTDH_MMA_FK]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [HD_MHD_FK] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NV] ([MaNV])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [HD_MHD_FK]
GO
ALTER TABLE [dbo].[MonAn]  WITH CHECK ADD  CONSTRAINT [MA_MLMA_FK] FOREIGN KEY([MaLoaiMonAn])
REFERENCES [dbo].[LoaiMonAn] ([MaLoaiMonAn])
GO
ALTER TABLE [dbo].[MonAn] CHECK CONSTRAINT [MA_MLMA_FK]
GO
