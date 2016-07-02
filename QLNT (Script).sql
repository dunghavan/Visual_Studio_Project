USE [master]
GO
/****** Object:  Database [QLNT]    Script Date: 02-Jul-16 4:55:59 PM ******/
CREATE DATABASE [QLNT]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLNT', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QLNT.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLNT_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QLNT_log.ldf' , SIZE = 2560KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLNT] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLNT].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLNT] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLNT] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLNT] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLNT] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLNT] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLNT] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLNT] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLNT] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLNT] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLNT] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLNT] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLNT] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLNT] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLNT] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLNT] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLNT] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLNT] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLNT] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLNT] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLNT] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLNT] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLNT] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLNT] SET RECOVERY FULL 
GO
ALTER DATABASE [QLNT] SET  MULTI_USER 
GO
ALTER DATABASE [QLNT] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLNT] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLNT] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLNT] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QLNT] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLNT', N'ON'
GO
USE [QLNT]
GO
/****** Object:  Table [dbo].[Bang_Cham_Cong]    Script Date: 02-Jul-16 4:56:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bang_Cham_Cong](
	[Ma_Bang] [nvarchar](10) NOT NULL,
	[Ma_NV] [nvarchar](10) NOT NULL,
	[Danh_Gia] [nvarchar](100) NULL,
	[Ngay] [date] NULL,
	[Ma_Nguoi_Tao] [nvarchar](10) NULL,
	[Ngay_Tao] [date] NULL,
 CONSTRAINT [PK_Bang_Cham_Cong] PRIMARY KEY CLUSTERED 
(
	[Ma_Bang] ASC,
	[Ma_NV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Bang_Diem_Danh]    Script Date: 02-Jul-16 4:56:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bang_Diem_Danh](
	[Ma_BDD] [nvarchar](10) NOT NULL,
	[Ma_Lop] [nvarchar](10) NULL,
	[Si_So] [int] NULL,
	[Ma_GV] [nvarchar](10) NULL,
	[Ma_Tre] [nvarchar](10) NULL,
	[Ghi_Chu] [nvarchar](1000) NULL,
	[Ngay_Diem_Danh] [date] NULL,
 CONSTRAINT [PK_Bang_Diem_Danh] PRIMARY KEY CLUSTERED 
(
	[Ma_BDD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Bao_Cao_Suc_Khoe]    Script Date: 02-Jul-16 4:56:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bao_Cao_Suc_Khoe](
	[Ma_BC] [nvarchar](10) NOT NULL,
	[Ma_Tre] [nvarchar](10) NOT NULL,
	[Ten_BC] [nvarchar](30) NULL,
	[Ngay] [date] NULL,
	[Tinh_Trang_Suc_Khoe] [nvarchar](100) NULL,
	[Ma_NV] [nvarchar](10) NULL,
	[Ngay_Tao] [date] NULL,
	[Ghi_Chu] [nvarchar](1000) NULL,
 CONSTRAINT [PK_Bao_Cao_Suc_Khoe] PRIMARY KEY CLUSTERED 
(
	[Ma_BC] ASC,
	[Ma_Tre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BaoCao_An_Ngu]    Script Date: 02-Jul-16 4:56:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BaoCao_An_Ngu](
	[Ma_BC] [nvarchar](10) NOT NULL,
	[Ma_Tre] [nvarchar](10) NOT NULL,
	[Ten_BC] [nvarchar](50) NULL,
	[Ngay] [date] NULL,
	[Tinh_Trang_An] [nvarchar](100) NULL,
	[Tinh_Trang_Ngu] [nvarchar](100) NULL,
	[Tinh_Trang_Vui_Choi] [nvarchar](100) NULL,
	[Ma_NV] [nvarchar](10) NULL,
	[Ngay_Tao] [date] NULL,
	[Ghi_Chu] [nvarchar](1000) NULL,
 CONSTRAINT [PK_BaoCao_An_Ngu] PRIMARY KEY CLUSTERED 
(
	[Ma_BC] ASC,
	[Ma_Tre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BaoCao_ChiPhi_ThucDon]    Script Date: 02-Jul-16 4:56:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BaoCao_ChiPhi_ThucDon](
	[Ma_BC] [nvarchar](10) NOT NULL,
	[Ten_Thuc_Don] [nvarchar](50) NULL,
	[So_Tien] [real] NULL,
	[Ma_NV] [nvarchar](10) NULL,
	[Ngay_Tao] [date] NULL,
	[Ma_Nguoi_Tao] [nvarchar](10) NULL,
 CONSTRAINT [PK_BaoCao_ChiPhi_ThucDon] PRIMARY KEY CLUSTERED 
(
	[Ma_BC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BaoCao_HocTap]    Script Date: 02-Jul-16 4:56:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BaoCao_HocTap](
	[Ma_BC] [nvarchar](10) NOT NULL,
	[Ma_Tre] [nvarchar](10) NOT NULL,
	[Ten_BC] [nvarchar](30) NULL,
	[Ngay] [date] NULL,
	[Ma_Lop] [nvarchar](10) NULL,
	[Nam_Hoc] [nvarchar](15) NULL,
	[DiemTrungBinh] [real] NULL,
	[Hoc_Luc] [nvarchar](10) NULL,
	[Hanh_Kiem] [nvarchar](10) NULL,
	[Ma_GV] [nvarchar](10) NULL,
	[Ngay_Tao] [date] NULL,
	[Ghi_Chu] [nvarchar](1000) NOT NULL,
 CONSTRAINT [PK_BaoCao_HocTap] PRIMARY KEY CLUSTERED 
(
	[Ma_BC] ASC,
	[Ma_Tre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BaoCao_ThucDon]    Script Date: 02-Jul-16 4:56:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BaoCao_ThucDon](
	[Ma_BC] [nvarchar](10) NOT NULL,
	[Ma_Tre] [nvarchar](10) NOT NULL,
	[Ten_BC] [nvarchar](30) NULL,
	[Ngay] [date] NULL,
	[ThucDon_An] [nvarchar](100) NULL,
	[ThucDon_Uong] [nchar](10) NULL,
	[ThucDon_Khac] [nchar](10) NULL,
	[Ma_NV] [nvarchar](10) NULL,
	[Ngay_Tao] [date] NULL,
	[Ghi_Chu] [nvarchar](1000) NULL,
 CONSTRAINT [PK_BaoCao_ThucDon] PRIMARY KEY CLUSTERED 
(
	[Ma_BC] ASC,
	[Ma_Tre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Giang_Day]    Script Date: 02-Jul-16 4:56:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Giang_Day](
	[Ma_GV] [nvarchar](10) NOT NULL,
	[Ma_Lop] [nvarchar](10) NOT NULL,
	[Nien_Khoa] [nvarchar](15) NULL,
 CONSTRAINT [PK_Giang_Day] PRIMARY KEY CLUSTERED 
(
	[Ma_GV] ASC,
	[Ma_Lop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Giao_Vien]    Script Date: 02-Jul-16 4:56:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Giao_Vien](
	[Ma_GV] [nvarchar](10) NOT NULL,
	[Ho_Ten] [nvarchar](30) NULL,
	[Gioi_Tinh] [nvarchar](5) NULL,
	[Ngay_Sinh] [date] NULL,
	[Vi_Tri] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_GiaoVien] PRIMARY KEY CLUSTERED 
(
	[Ma_GV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Hoa_Don]    Script Date: 02-Jul-16 4:56:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hoa_Don](
	[Ma_HD] [nvarchar](10) NOT NULL,
	[Ten_HD] [nvarchar](30) NULL,
	[So_Tien] [real] NULL,
	[Ma_NV] [nvarchar](10) NULL,
	[Ma_Tre] [nvarchar](10) NULL,
	[Ngay_Tao] [date] NULL,
 CONSTRAINT [PK_Hoa_Don] PRIMARY KEY CLUSTERED 
(
	[Ma_HD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Lop_Hoc]    Script Date: 02-Jul-16 4:56:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lop_Hoc](
	[Ma_Lop] [nvarchar](10) NOT NULL,
	[Ten_Lop] [nvarchar](10) NULL,
	[Si_So] [int] NULL,
	[Nien_Khoa] [nvarchar](15) NULL,
	[Ma_GVCN] [nvarchar](10) NULL,
 CONSTRAINT [PK_Lop_Hoc] PRIMARY KEY CLUSTERED 
(
	[Ma_Lop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Mon_Hoc]    Script Date: 02-Jul-16 4:56:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mon_Hoc](
	[Ma_MH] [nvarchar](10) NOT NULL,
	[Ten_MH] [nvarchar](15) NULL,
 CONSTRAINT [PK_Mon_Hoc] PRIMARY KEY CLUSTERED 
(
	[Ma_MH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MonHoc_Thuoc_TKB]    Script Date: 02-Jul-16 4:56:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonHoc_Thuoc_TKB](
	[Ma_TKB] [nvarchar](10) NOT NULL,
	[Ma_MH] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_MonHoc_Thuoc_TKB] PRIMARY KEY CLUSTERED 
(
	[Ma_TKB] ASC,
	[Ma_MH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Nhan_Vien]    Script Date: 02-Jul-16 4:56:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nhan_Vien](
	[Ma_NV] [nvarchar](10) NOT NULL,
	[Ho_Ten] [nvarchar](30) NULL,
	[Gioi_Tinh] [nvarchar](5) NULL,
	[Ngay_Sinh] [date] NULL,
	[Vi_Tri] [nvarchar](30) NULL,
	[Lương] [real] NOT NULL,
 CONSTRAINT [PK_Nhan_Vien] PRIMARY KEY CLUSTERED 
(
	[Ma_NV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Phu_Huynh]    Script Date: 02-Jul-16 4:56:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phu_Huynh](
	[Ma_PH] [nvarchar](10) NOT NULL,
	[Ho_Ten] [nvarchar](30) NULL,
	[SoDienThoai] [nvarchar](15) NULL,
	[Email] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Phu_Huynh] PRIMARY KEY CLUSTERED 
(
	[Ma_PH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Su_Kien]    Script Date: 02-Jul-16 4:56:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Su_Kien](
	[Ma_SK] [nvarchar](10) NOT NULL,
	[Ten_SK] [nvarchar](30) NULL,
	[ThoiGian_ToChuc] [date] NOT NULL,
	[DiaDiem_ToChuc] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Su_Kien] PRIMARY KEY CLUSTERED 
(
	[Ma_SK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ThamGia_SuKien]    Script Date: 02-Jul-16 4:56:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThamGia_SuKien](
	[Ma_Tre] [nvarchar](10) NOT NULL,
	[Ma_SK] [nvarchar](10) NOT NULL,
	[ThoiDiem_ThamGia] [date] NULL,
 CONSTRAINT [PK_ThamGia_SuKien] PRIMARY KEY CLUSTERED 
(
	[Ma_Tre] ASC,
	[Ma_SK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Thoi_Khoa_Bieu]    Script Date: 02-Jul-16 4:56:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Thoi_Khoa_Bieu](
	[Ma_TKB] [nvarchar](10) NOT NULL,
	[Ma_Lop] [nvarchar](10) NULL,
	[Ma_GV] [nvarchar](10) NULL,
 CONSTRAINT [PK_Thoi_Khoa_Bieu] PRIMARY KEY CLUSTERED 
(
	[Ma_TKB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ThongBao_SuKien]    Script Date: 02-Jul-16 4:56:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongBao_SuKien](
	[Ma_SuKien] [nvarchar](10) NOT NULL,
	[Ma_NV] [nvarchar](10) NOT NULL,
	[Ngay_Thong_Bao] [date] NULL,
 CONSTRAINT [PK_ThongBao_SuKien] PRIMARY KEY CLUSTERED 
(
	[Ma_SuKien] ASC,
	[Ma_NV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tre]    Script Date: 02-Jul-16 4:56:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tre](
	[Ma_Tre] [nvarchar](10) NOT NULL,
	[Ho_Ten] [nvarchar](30) NULL,
	[Nam_Sinh] [date] NULL,
	[Gioi_Tinh] [nvarchar](5) NULL,
	[Ma_Lop] [nvarchar](10) NOT NULL,
	[Ma_PH] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_Tre] PRIMARY KEY CLUSTERED 
(
	[Ma_Tre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Bang_Cham_Cong]  WITH CHECK ADD  CONSTRAINT [FK_Bang_Cham_Cong_Nhan_Vien1] FOREIGN KEY([Ma_Nguoi_Tao])
REFERENCES [dbo].[Nhan_Vien] ([Ma_NV])
GO
ALTER TABLE [dbo].[Bang_Cham_Cong] CHECK CONSTRAINT [FK_Bang_Cham_Cong_Nhan_Vien1]
GO
ALTER TABLE [dbo].[Bang_Diem_Danh]  WITH CHECK ADD  CONSTRAINT [FK_Bang_Diem_Danh_Giao_Vien] FOREIGN KEY([Ma_GV])
REFERENCES [dbo].[Giao_Vien] ([Ma_GV])
GO
ALTER TABLE [dbo].[Bang_Diem_Danh] CHECK CONSTRAINT [FK_Bang_Diem_Danh_Giao_Vien]
GO
ALTER TABLE [dbo].[Bang_Diem_Danh]  WITH CHECK ADD  CONSTRAINT [FK_Bang_Diem_Danh_Lop_Hoc] FOREIGN KEY([Ma_Lop])
REFERENCES [dbo].[Lop_Hoc] ([Ma_Lop])
GO
ALTER TABLE [dbo].[Bang_Diem_Danh] CHECK CONSTRAINT [FK_Bang_Diem_Danh_Lop_Hoc]
GO
ALTER TABLE [dbo].[Bang_Diem_Danh]  WITH CHECK ADD  CONSTRAINT [FK_Bang_Diem_Danh_Tre] FOREIGN KEY([Ma_Tre])
REFERENCES [dbo].[Tre] ([Ma_Tre])
GO
ALTER TABLE [dbo].[Bang_Diem_Danh] CHECK CONSTRAINT [FK_Bang_Diem_Danh_Tre]
GO
ALTER TABLE [dbo].[Bao_Cao_Suc_Khoe]  WITH CHECK ADD  CONSTRAINT [FK_Bao_Cao_Suc_Khoe_Nhan_Vien] FOREIGN KEY([Ma_NV])
REFERENCES [dbo].[Nhan_Vien] ([Ma_NV])
GO
ALTER TABLE [dbo].[Bao_Cao_Suc_Khoe] CHECK CONSTRAINT [FK_Bao_Cao_Suc_Khoe_Nhan_Vien]
GO
ALTER TABLE [dbo].[Bao_Cao_Suc_Khoe]  WITH CHECK ADD  CONSTRAINT [FK_Bao_Cao_Suc_Khoe_Tre] FOREIGN KEY([Ma_Tre])
REFERENCES [dbo].[Tre] ([Ma_Tre])
GO
ALTER TABLE [dbo].[Bao_Cao_Suc_Khoe] CHECK CONSTRAINT [FK_Bao_Cao_Suc_Khoe_Tre]
GO
ALTER TABLE [dbo].[BaoCao_An_Ngu]  WITH CHECK ADD  CONSTRAINT [FK_BaoCao_An_Ngu_Nhan_Vien] FOREIGN KEY([Ma_NV])
REFERENCES [dbo].[Nhan_Vien] ([Ma_NV])
GO
ALTER TABLE [dbo].[BaoCao_An_Ngu] CHECK CONSTRAINT [FK_BaoCao_An_Ngu_Nhan_Vien]
GO
ALTER TABLE [dbo].[BaoCao_An_Ngu]  WITH CHECK ADD  CONSTRAINT [FK_BaoCao_An_Ngu_Tre] FOREIGN KEY([Ma_Tre])
REFERENCES [dbo].[Tre] ([Ma_Tre])
GO
ALTER TABLE [dbo].[BaoCao_An_Ngu] CHECK CONSTRAINT [FK_BaoCao_An_Ngu_Tre]
GO
ALTER TABLE [dbo].[BaoCao_ChiPhi_ThucDon]  WITH CHECK ADD  CONSTRAINT [FK_BaoCao_ChiPhi_ThucDon_Nhan_Vien] FOREIGN KEY([Ma_NV])
REFERENCES [dbo].[Nhan_Vien] ([Ma_NV])
GO
ALTER TABLE [dbo].[BaoCao_ChiPhi_ThucDon] CHECK CONSTRAINT [FK_BaoCao_ChiPhi_ThucDon_Nhan_Vien]
GO
ALTER TABLE [dbo].[BaoCao_HocTap]  WITH CHECK ADD  CONSTRAINT [FK_BaoCao_HocTap_Giao_Vien] FOREIGN KEY([Ma_GV])
REFERENCES [dbo].[Giao_Vien] ([Ma_GV])
GO
ALTER TABLE [dbo].[BaoCao_HocTap] CHECK CONSTRAINT [FK_BaoCao_HocTap_Giao_Vien]
GO
ALTER TABLE [dbo].[BaoCao_HocTap]  WITH CHECK ADD  CONSTRAINT [FK_BaoCao_HocTap_Tre] FOREIGN KEY([Ma_Tre])
REFERENCES [dbo].[Tre] ([Ma_Tre])
GO
ALTER TABLE [dbo].[BaoCao_HocTap] CHECK CONSTRAINT [FK_BaoCao_HocTap_Tre]
GO
ALTER TABLE [dbo].[BaoCao_ThucDon]  WITH CHECK ADD  CONSTRAINT [FK_BaoCao_ThucDon_Nhan_Vien] FOREIGN KEY([Ma_NV])
REFERENCES [dbo].[Nhan_Vien] ([Ma_NV])
GO
ALTER TABLE [dbo].[BaoCao_ThucDon] CHECK CONSTRAINT [FK_BaoCao_ThucDon_Nhan_Vien]
GO
ALTER TABLE [dbo].[BaoCao_ThucDon]  WITH CHECK ADD  CONSTRAINT [FK_BaoCao_ThucDon_Tre] FOREIGN KEY([Ma_Tre])
REFERENCES [dbo].[Tre] ([Ma_Tre])
GO
ALTER TABLE [dbo].[BaoCao_ThucDon] CHECK CONSTRAINT [FK_BaoCao_ThucDon_Tre]
GO
ALTER TABLE [dbo].[Giang_Day]  WITH CHECK ADD  CONSTRAINT [FK_Giang_Day_Giao_Vien] FOREIGN KEY([Ma_GV])
REFERENCES [dbo].[Giao_Vien] ([Ma_GV])
GO
ALTER TABLE [dbo].[Giang_Day] CHECK CONSTRAINT [FK_Giang_Day_Giao_Vien]
GO
ALTER TABLE [dbo].[Giang_Day]  WITH CHECK ADD  CONSTRAINT [FK_Giang_Day_Lop_Hoc] FOREIGN KEY([Ma_Lop])
REFERENCES [dbo].[Lop_Hoc] ([Ma_Lop])
GO
ALTER TABLE [dbo].[Giang_Day] CHECK CONSTRAINT [FK_Giang_Day_Lop_Hoc]
GO
ALTER TABLE [dbo].[Hoa_Don]  WITH CHECK ADD  CONSTRAINT [FK_Hoa_Don_Nhan_Vien] FOREIGN KEY([Ma_NV])
REFERENCES [dbo].[Nhan_Vien] ([Ma_NV])
GO
ALTER TABLE [dbo].[Hoa_Don] CHECK CONSTRAINT [FK_Hoa_Don_Nhan_Vien]
GO
ALTER TABLE [dbo].[Hoa_Don]  WITH CHECK ADD  CONSTRAINT [FK_Hoa_Don_Tre] FOREIGN KEY([Ma_Tre])
REFERENCES [dbo].[Tre] ([Ma_Tre])
GO
ALTER TABLE [dbo].[Hoa_Don] CHECK CONSTRAINT [FK_Hoa_Don_Tre]
GO
ALTER TABLE [dbo].[Lop_Hoc]  WITH CHECK ADD  CONSTRAINT [FK_Lop_Hoc_Giao_Vien] FOREIGN KEY([Ma_GVCN])
REFERENCES [dbo].[Giao_Vien] ([Ma_GV])
GO
ALTER TABLE [dbo].[Lop_Hoc] CHECK CONSTRAINT [FK_Lop_Hoc_Giao_Vien]
GO
ALTER TABLE [dbo].[MonHoc_Thuoc_TKB]  WITH CHECK ADD  CONSTRAINT [FK_MonHoc_Thuoc_TKB_Mon_Hoc] FOREIGN KEY([Ma_MH])
REFERENCES [dbo].[Mon_Hoc] ([Ma_MH])
GO
ALTER TABLE [dbo].[MonHoc_Thuoc_TKB] CHECK CONSTRAINT [FK_MonHoc_Thuoc_TKB_Mon_Hoc]
GO
ALTER TABLE [dbo].[MonHoc_Thuoc_TKB]  WITH CHECK ADD  CONSTRAINT [FK_MonHoc_Thuoc_TKB_Thoi_Khoa_Bieu] FOREIGN KEY([Ma_TKB])
REFERENCES [dbo].[Thoi_Khoa_Bieu] ([Ma_TKB])
GO
ALTER TABLE [dbo].[MonHoc_Thuoc_TKB] CHECK CONSTRAINT [FK_MonHoc_Thuoc_TKB_Thoi_Khoa_Bieu]
GO
ALTER TABLE [dbo].[ThamGia_SuKien]  WITH CHECK ADD  CONSTRAINT [FK_ThamGia_SuKien_Su_Kien] FOREIGN KEY([Ma_SK])
REFERENCES [dbo].[Su_Kien] ([Ma_SK])
GO
ALTER TABLE [dbo].[ThamGia_SuKien] CHECK CONSTRAINT [FK_ThamGia_SuKien_Su_Kien]
GO
ALTER TABLE [dbo].[ThamGia_SuKien]  WITH CHECK ADD  CONSTRAINT [FK_ThamGia_SuKien_Tre] FOREIGN KEY([Ma_Tre])
REFERENCES [dbo].[Tre] ([Ma_Tre])
GO
ALTER TABLE [dbo].[ThamGia_SuKien] CHECK CONSTRAINT [FK_ThamGia_SuKien_Tre]
GO
ALTER TABLE [dbo].[Thoi_Khoa_Bieu]  WITH CHECK ADD  CONSTRAINT [FK_Thoi_Khoa_Bieu_Giao_Vien] FOREIGN KEY([Ma_GV])
REFERENCES [dbo].[Giao_Vien] ([Ma_GV])
GO
ALTER TABLE [dbo].[Thoi_Khoa_Bieu] CHECK CONSTRAINT [FK_Thoi_Khoa_Bieu_Giao_Vien]
GO
ALTER TABLE [dbo].[ThongBao_SuKien]  WITH CHECK ADD  CONSTRAINT [FK_ThongBao_SuKien_Nhan_Vien] FOREIGN KEY([Ma_NV])
REFERENCES [dbo].[Nhan_Vien] ([Ma_NV])
GO
ALTER TABLE [dbo].[ThongBao_SuKien] CHECK CONSTRAINT [FK_ThongBao_SuKien_Nhan_Vien]
GO
ALTER TABLE [dbo].[ThongBao_SuKien]  WITH CHECK ADD  CONSTRAINT [FK_ThongBao_SuKien_Su_Kien] FOREIGN KEY([Ma_SuKien])
REFERENCES [dbo].[Su_Kien] ([Ma_SK])
GO
ALTER TABLE [dbo].[ThongBao_SuKien] CHECK CONSTRAINT [FK_ThongBao_SuKien_Su_Kien]
GO
ALTER TABLE [dbo].[Tre]  WITH CHECK ADD  CONSTRAINT [FK_Tre_Phu_Huynh] FOREIGN KEY([Ma_PH])
REFERENCES [dbo].[Phu_Huynh] ([Ma_PH])
GO
ALTER TABLE [dbo].[Tre] CHECK CONSTRAINT [FK_Tre_Phu_Huynh]
GO
/****** Object:  StoredProcedure [dbo].[BaoCao_An_Ngu_Lst]    Script Date: 02-Jul-16 4:56:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[BaoCao_An_Ngu_Lst] 

AS
BEGIN
	SELECT A.Ma_BC AS 'Mã Báo Cáo', A.Ten_BC AS 'Tên Báo Cáo', A.Ma_Tre AS 'Mã Số Trẻ', B.Ho_Ten AS 'Họ Và Tên', A.Ngay AS 'Ngày',
			A.Tinh_Trang_An AS 'Tình Trạng Ăn', A.Tinh_Trang_Ngu AS 'Tình Trạng Ngủ', A.Tinh_Trang_Vui_Choi AS 'Tình Trạng Vui Chơi',
			A.Ma_NV AS 'Mã Nhân Viên', A.Ngay AS 'Ngày Tạo', A.Ghi_Chu AS 'Ghi Chú'
	FROM BaoCao_An_Ngu A
	LEFT JOIN Tre B ON A.Ma_Tre LIKE B.Ma_Tre
END

GO
/****** Object:  StoredProcedure [dbo].[BaoCao_An_Ngu_Search]    Script Date: 02-Jul-16 4:56:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[BaoCao_An_Ngu_Search]
(
	@p_MA_BC NVARCHAR(10) = NULL,
	@p_TEN_BC NVARCHAR(10) = NULL,
	@p_MA_TRE NVARCHAR(10) = NULL,
	@p_TEN_TRE NVARCHAR(30) = NULL,
	@p_NGAY NVARCHAR(30) = NULL,
	@p_TINHTRANG_AN NVARCHAR(100) = NULL,
	@p_TINHTRANG_NGU NVARCHAR(100) = NULL,
	@p_TINHTRANG_VUICHOI NVARCHAR(100) = NULL,
	@p_MA_NV NVARCHAR(10) = NULL,
	@p_NGAY_TAO NVARCHAR(30) = NULL
)
AS
BEGIN
	SELECT A.Ma_BC AS 'Mã Báo Cáo', A.Ten_BC AS 'Tên Báo Cáo', A.Ma_Tre AS 'Mã Số Trẻ', B.Ho_Ten AS 'Họ Và Tên', A.Ngay AS 'Ngày',
				A.Tinh_Trang_An AS 'Tình Trạng Ăn', A.Tinh_Trang_Ngu AS 'Tình Trạng Ngủ', A.Tinh_Trang_Vui_Choi AS 'Tình Trạng Vui Chơi',
				A.Ma_NV AS 'Mã Nhân Viên', A.Ngay AS 'Ngày Tạo', A.Ghi_Chu AS 'Ghi Chú'
		FROM BaoCao_An_Ngu A
		LEFT JOIN Tre B ON A.Ma_Tre LIKE B.Ma_Tre
		WHERE 1 = 1
		AND (A.Ma_BC LIKE '%' + @p_MA_BC + '%' OR  @p_MA_BC IS NULL OR @p_MA_BC = '')
		AND (A.Ten_BC LIKE '%' + @p_TEN_BC + '%' OR  @p_TEN_BC IS NULL OR @p_TEN_BC = '')
		AND (A.Ma_Tre LIKE '%' + @p_MA_TRE + '%' OR  @p_MA_TRE IS NULL OR @p_MA_TRE = '')
		AND (B.Ho_Ten LIKE '%' + @p_TEN_TRE + '%' OR  @p_TEN_TRE IS NULL OR @p_TEN_TRE = '')
		AND (CONVERT(NVARCHAR, A.Ngay , 110) LIKE '%' +  @p_NGAY + '%' OR  @p_NGAY IS NULL OR @p_NGAY = '')
		AND (A.Tinh_Trang_An LIKE '%' + @p_TINHTRANG_AN + '%' OR  @p_TINHTRANG_AN IS NULL OR @p_TINHTRANG_AN = '')
		AND (A.Tinh_Trang_Ngu LIKE '%' + @p_TINHTRANG_NGU + '%' OR  @p_TINHTRANG_NGU IS NULL OR @p_TINHTRANG_NGU = '')
		AND (A.Tinh_Trang_Vui_Choi LIKE '%' + @p_TINHTRANG_VUICHOI + '%' OR  @p_TINHTRANG_VUICHOI IS NULL OR @p_TINHTRANG_VUICHOI = '')
		AND (A.Ma_NV LIKE '%' + @p_MA_NV + '%' OR  @p_MA_NV IS NULL OR @p_MA_NV = '')
		AND (CONVERT(NVARCHAR, A.Ngay_Tao , 110) LIKE '%' +  @p_NGAY_TAO + '%' OR  @p_NGAY_TAO IS NULL OR @p_NGAY_TAO = '')
END

GO
/****** Object:  StoredProcedure [dbo].[BaoCao_An_Ngu_Sort_by_Date]    Script Date: 02-Jul-16 4:56:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[BaoCao_An_Ngu_Sort_by_Date]
(
	@p_MA_BC NVARCHAR(10) = NULL,
	@p_TEN_BC NVARCHAR(10) = NULL,
	@p_MA_TRE NVARCHAR(10) = NULL,
	@p_TEN_TRE NVARCHAR(30) = NULL,
	@p_NGAY NVARCHAR(30) = NULL,
	@p_TINHTRANG_AN NVARCHAR(100) = NULL,
	@p_TINHTRANG_NGU NVARCHAR(100) = NULL,
	@p_TINHTRANG_VUICHOI NVARCHAR(100) = NULL,
	@p_MA_NV NVARCHAR(10) = NULL,
	@p_NGAY_TAO NVARCHAR(30) = NULL,

	@p_SORT_BY INT = 0
)
AS
BEGIN
	IF(@p_SORT_BY = 0)
	SELECT A.Ma_BC AS 'Mã Báo Cáo', A.Ten_BC AS 'Tên Báo Cáo', A.Ma_Tre AS 'Mã Số Trẻ', B.Ho_Ten AS 'Họ Và Tên', A.Ngay AS 'Ngày',
				A.Tinh_Trang_An AS 'Tình Trạng Ăn', A.Tinh_Trang_Ngu AS 'Tình Trạng Ngủ', A.Tinh_Trang_Vui_Choi AS 'Tình Trạng Vui Chơi',
				A.Ma_NV AS 'Mã Nhân Viên', A.Ngay AS 'Ngày Tạo', A.Ghi_Chu AS 'Ghi Chú'
		FROM BaoCao_An_Ngu A
		LEFT JOIN Tre B ON A.Ma_Tre LIKE B.Ma_Tre
		WHERE 1 = 1
		AND (A.Ma_BC LIKE '%' + @p_MA_BC + '%' OR  @p_MA_BC IS NULL OR @p_MA_BC = '')
		AND (A.Ten_BC LIKE '%' + @p_TEN_BC + '%' OR  @p_TEN_BC IS NULL OR @p_TEN_BC = '')
		AND (A.Ma_Tre LIKE '%' + @p_MA_TRE + '%' OR  @p_MA_TRE IS NULL OR @p_MA_TRE = '')
		AND (B.Ho_Ten LIKE '%' + @p_TEN_TRE + '%' OR  @p_TEN_TRE IS NULL OR @p_TEN_TRE = '')
		AND (CONVERT(NVARCHAR, A.Ngay , 110) LIKE '%' +  @p_NGAY + '%' OR  @p_NGAY IS NULL OR @p_NGAY = '')
		AND (A.Tinh_Trang_An LIKE '%' + @p_TINHTRANG_AN + '%' OR  @p_TINHTRANG_AN IS NULL OR @p_TINHTRANG_AN = '')
		AND (A.Tinh_Trang_Ngu LIKE '%' + @p_TINHTRANG_NGU + '%' OR  @p_TINHTRANG_NGU IS NULL OR @p_TINHTRANG_NGU = '')
		AND (A.Tinh_Trang_Vui_Choi LIKE '%' + @p_TINHTRANG_VUICHOI + '%' OR  @p_TINHTRANG_VUICHOI IS NULL OR @p_TINHTRANG_VUICHOI = '')
		AND (A.Ma_NV LIKE '%' + @p_MA_NV + '%' OR  @p_MA_NV IS NULL OR @p_MA_NV = '')
		AND (CONVERT(NVARCHAR, A.Ngay_Tao , 110) LIKE '%' +  @p_NGAY_TAO + '%' OR  @p_NGAY_TAO IS NULL OR @p_NGAY_TAO = '')
		ORDER BY CONVERT(DATETIME, A.Ngay, 101) ASC
		---------------------------------------------------------------
		IF(@p_SORT_BY = 1)
		SELECT A.Ma_BC AS 'Mã Báo Cáo', A.Ten_BC AS 'Tên Báo Cáo', A.Ma_Tre AS 'Mã Số Trẻ', B.Ho_Ten AS 'Họ Và Tên', A.Ngay AS 'Ngày',
				A.Tinh_Trang_An AS 'Tình Trạng Ăn', A.Tinh_Trang_Ngu AS 'Tình Trạng Ngủ', A.Tinh_Trang_Vui_Choi AS 'Tình Trạng Vui Chơi',
				A.Ma_NV AS 'Mã Nhân Viên', A.Ngay AS 'Ngày Tạo', A.Ghi_Chu AS 'Ghi Chú'
		FROM BaoCao_An_Ngu A
		LEFT JOIN Tre B ON A.Ma_Tre LIKE B.Ma_Tre
		WHERE 1 = 1
		AND (A.Ma_BC LIKE '%' + @p_MA_BC + '%' OR  @p_MA_BC IS NULL OR @p_MA_BC = '')
		AND (A.Ten_BC LIKE '%' + @p_TEN_BC + '%' OR  @p_TEN_BC IS NULL OR @p_TEN_BC = '')
		AND (A.Ma_Tre LIKE '%' + @p_MA_TRE + '%' OR  @p_MA_TRE IS NULL OR @p_MA_TRE = '')
		AND (B.Ho_Ten LIKE '%' + @p_TEN_TRE + '%' OR  @p_TEN_TRE IS NULL OR @p_TEN_TRE = '')
		AND (CONVERT(NVARCHAR, A.Ngay , 110) LIKE '%' +  @p_NGAY + '%' OR  @p_NGAY IS NULL OR @p_NGAY = '')
		AND (A.Tinh_Trang_An LIKE '%' + @p_TINHTRANG_AN + '%' OR  @p_TINHTRANG_AN IS NULL OR @p_TINHTRANG_AN = '')
		AND (A.Tinh_Trang_Ngu LIKE '%' + @p_TINHTRANG_NGU + '%' OR  @p_TINHTRANG_NGU IS NULL OR @p_TINHTRANG_NGU = '')
		AND (A.Tinh_Trang_Vui_Choi LIKE '%' + @p_TINHTRANG_VUICHOI + '%' OR  @p_TINHTRANG_VUICHOI IS NULL OR @p_TINHTRANG_VUICHOI = '')
		AND (A.Ma_NV LIKE '%' + @p_MA_NV + '%' OR  @p_MA_NV IS NULL OR @p_MA_NV = '')
		AND (CONVERT(NVARCHAR, A.Ngay_Tao , 110) LIKE '%' +  @p_NGAY_TAO + '%' OR  @p_NGAY_TAO IS NULL OR @p_NGAY_TAO = '')
		ORDER BY CONVERT(DATETIME, A.Ngay, 101) DESC
END

GO
/****** Object:  StoredProcedure [dbo].[BaoCao_An_Ngu_Sort_by_Name]    Script Date: 02-Jul-16 4:56:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[BaoCao_An_Ngu_Sort_by_Name]
(
	@p_MA_BC NVARCHAR(10) = NULL,
	@p_TEN_BC NVARCHAR(10) = NULL,
	@p_MA_TRE NVARCHAR(10) = NULL,
	@p_TEN_TRE NVARCHAR(30) = NULL,
	@p_NGAY NVARCHAR(30) = NULL,
	@p_TINHTRANG_AN NVARCHAR(100) = NULL,
	@p_TINHTRANG_NGU NVARCHAR(100) = NULL,
	@p_TINHTRANG_VUICHOI NVARCHAR(100) = NULL,
	@p_MA_NV NVARCHAR(10) = NULL,
	@p_NGAY_TAO NVARCHAR(30) = NULL,

	@p_SORT_BY INT = 0
)
AS
BEGIN
	IF(@p_SORT_BY = 0)
	SELECT A.Ma_BC AS 'Mã Báo Cáo', A.Ten_BC AS 'Tên Báo Cáo', A.Ma_Tre AS 'Mã Số Trẻ', B.Ho_Ten AS 'Họ Và Tên', A.Ngay AS 'Ngày',
				A.Tinh_Trang_An AS 'Tình Trạng Ăn', A.Tinh_Trang_Ngu AS 'Tình Trạng Ngủ', A.Tinh_Trang_Vui_Choi AS 'Tình Trạng Vui Chơi',
				A.Ma_NV AS 'Mã Nhân Viên', A.Ngay AS 'Ngày Tạo', A.Ghi_Chu AS 'Ghi Chú'
		FROM BaoCao_An_Ngu A
		LEFT JOIN Tre B ON A.Ma_Tre LIKE B.Ma_Tre
		WHERE 1 = 1
		AND (A.Ma_BC LIKE '%' + @p_MA_BC + '%' OR  @p_MA_BC IS NULL OR @p_MA_BC = '')
		AND (A.Ten_BC LIKE '%' + @p_TEN_BC + '%' OR  @p_TEN_BC IS NULL OR @p_TEN_BC = '')
		AND (A.Ma_Tre LIKE '%' + @p_MA_TRE + '%' OR  @p_MA_TRE IS NULL OR @p_MA_TRE = '')
		AND (B.Ho_Ten LIKE '%' + @p_TEN_TRE + '%' OR  @p_TEN_TRE IS NULL OR @p_TEN_TRE = '')
		AND (CONVERT(NVARCHAR, A.Ngay , 110) LIKE '%' +  @p_NGAY + '%' OR  @p_NGAY IS NULL OR @p_NGAY = '')
		AND (A.Tinh_Trang_An LIKE '%' + @p_TINHTRANG_AN + '%' OR  @p_TINHTRANG_AN IS NULL OR @p_TINHTRANG_AN = '')
		AND (A.Tinh_Trang_Ngu LIKE '%' + @p_TINHTRANG_NGU + '%' OR  @p_TINHTRANG_NGU IS NULL OR @p_TINHTRANG_NGU = '')
		AND (A.Tinh_Trang_Vui_Choi LIKE '%' + @p_TINHTRANG_VUICHOI + '%' OR  @p_TINHTRANG_VUICHOI IS NULL OR @p_TINHTRANG_VUICHOI = '')
		AND (A.Ma_NV LIKE '%' + @p_MA_NV + '%' OR  @p_MA_NV IS NULL OR @p_MA_NV = '')
		AND (CONVERT(NVARCHAR, A.Ngay_Tao , 110) LIKE '%' +  @p_NGAY_TAO + '%' OR  @p_NGAY_TAO IS NULL OR @p_NGAY_TAO = '')
		ORDER BY B.Ho_Ten ASC
		---------------------------------------------------------------
		IF(@p_SORT_BY = 1)
		SELECT A.Ma_BC AS 'Mã Báo Cáo', A.Ten_BC AS 'Tên Báo Cáo', A.Ma_Tre AS 'Mã Số Trẻ', B.Ho_Ten AS 'Họ Và Tên', A.Ngay AS 'Ngày',
				A.Tinh_Trang_An AS 'Tình Trạng Ăn', A.Tinh_Trang_Ngu AS 'Tình Trạng Ngủ', A.Tinh_Trang_Vui_Choi AS 'Tình Trạng Vui Chơi',
				A.Ma_NV AS 'Mã Nhân Viên', A.Ngay AS 'Ngày Tạo', A.Ghi_Chu AS 'Ghi Chú'
		FROM BaoCao_An_Ngu A
		LEFT JOIN Tre B ON A.Ma_Tre LIKE B.Ma_Tre
		WHERE 1 = 1
		AND (A.Ma_BC LIKE '%' + @p_MA_BC + '%' OR  @p_MA_BC IS NULL OR @p_MA_BC = '')
		AND (A.Ten_BC LIKE '%' + @p_TEN_BC + '%' OR  @p_TEN_BC IS NULL OR @p_TEN_BC = '')
		AND (A.Ma_Tre LIKE '%' + @p_MA_TRE + '%' OR  @p_MA_TRE IS NULL OR @p_MA_TRE = '')
		AND (B.Ho_Ten LIKE '%' + @p_TEN_TRE + '%' OR  @p_TEN_TRE IS NULL OR @p_TEN_TRE = '')
		AND (CONVERT(NVARCHAR, A.Ngay , 110) LIKE '%' +  @p_NGAY + '%' OR  @p_NGAY IS NULL OR @p_NGAY = '')
		AND (A.Tinh_Trang_An LIKE '%' + @p_TINHTRANG_AN + '%' OR  @p_TINHTRANG_AN IS NULL OR @p_TINHTRANG_AN = '')
		AND (A.Tinh_Trang_Ngu LIKE '%' + @p_TINHTRANG_NGU + '%' OR  @p_TINHTRANG_NGU IS NULL OR @p_TINHTRANG_NGU = '')
		AND (A.Tinh_Trang_Vui_Choi LIKE '%' + @p_TINHTRANG_VUICHOI + '%' OR  @p_TINHTRANG_VUICHOI IS NULL OR @p_TINHTRANG_VUICHOI = '')
		AND (A.Ma_NV LIKE '%' + @p_MA_NV + '%' OR  @p_MA_NV IS NULL OR @p_MA_NV = '')
		AND (CONVERT(NVARCHAR, A.Ngay_Tao , 110) LIKE '%' +  @p_NGAY_TAO + '%' OR  @p_NGAY_TAO IS NULL OR @p_NGAY_TAO = '')
		ORDER BY B.Ho_Ten DESC
END

GO
USE [master]
GO
ALTER DATABASE [QLNT] SET  READ_WRITE 
GO
