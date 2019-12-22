USE [master]
GO
/****** Object:  Database [QSLV_LHP]    Script Date: 22/12/2019 10:52:51 PM ******/
CREATE DATABASE [QSLV_LHP]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QSLV_LHP', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QSLV_LHP.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QSLV_LHP_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QSLV_LHP_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QSLV_LHP] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QSLV_LHP].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QSLV_LHP] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QSLV_LHP] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QSLV_LHP] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QSLV_LHP] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QSLV_LHP] SET ARITHABORT OFF 
GO
ALTER DATABASE [QSLV_LHP] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QSLV_LHP] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QSLV_LHP] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QSLV_LHP] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QSLV_LHP] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QSLV_LHP] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QSLV_LHP] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QSLV_LHP] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QSLV_LHP] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QSLV_LHP] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QSLV_LHP] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QSLV_LHP] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QSLV_LHP] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QSLV_LHP] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QSLV_LHP] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QSLV_LHP] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QSLV_LHP] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QSLV_LHP] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QSLV_LHP] SET  MULTI_USER 
GO
ALTER DATABASE [QSLV_LHP] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QSLV_LHP] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QSLV_LHP] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QSLV_LHP] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QSLV_LHP] SET DELAYED_DURABILITY = DISABLED 
GO
USE [QSLV_LHP]
GO
/****** Object:  Table [dbo].[DanhSachMonHoc]    Script Date: 22/12/2019 10:52:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhSachMonHoc](
	[TenMonHoc] [nvarchar](50) NULL,
	[MaMonHoc] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_DanhSachMonHoc] PRIMARY KEY CLUSTERED 
(
	[MaMonHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LopHocPhan]    Script Date: 22/12/2019 10:52:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LopHocPhan](
	[TenLopHocPhan] [nvarchar](50) NULL,
	[MaLopHocPhan] [nvarchar](50) NOT NULL,
	[GiaoVienPhuTrach] [nvarchar](50) NULL,
	[SoLuongSinhVienDangKy] [int] NULL,
	[DinhMucSinhVien] [int] NULL,
 CONSTRAINT [PK_LopHocPhan] PRIMARY KEY CLUSTERED 
(
	[MaLopHocPhan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 22/12/2019 10:52:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[MaSinhVien] [nvarchar](50) NOT NULL,
	[HoDem] [nvarchar](50) NULL,
	[Ten] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[QueQuan] [nvarchar](50) NULL,
	[MaLopHocPhan] [nvarchar](50) NULL,
 CONSTRAINT [PK_SinhVien] PRIMARY KEY CLUSTERED 
(
	[MaSinhVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[DanhSachMonHoc] ([TenMonHoc], [MaMonHoc]) VALUES (N'Hoc', N'hoa1')
INSERT [dbo].[DanhSachMonHoc] ([TenMonHoc], [MaMonHoc]) VALUES (N'Toan', N'toan1')
INSERT [dbo].[DanhSachMonHoc] ([TenMonHoc], [MaMonHoc]) VALUES (N'Van', N'van1')
INSERT [dbo].[LopHocPhan] ([TenLopHocPhan], [MaLopHocPhan], [GiaoVienPhuTrach], [SoLuongSinhVienDangKy], [DinhMucSinhVien]) VALUES (N'CNTT', N'001', N'Phutran', 22, 22)
INSERT [dbo].[LopHocPhan] ([TenLopHocPhan], [MaLopHocPhan], [GiaoVienPhuTrach], [SoLuongSinhVienDangKy], [DinhMucSinhVien]) VALUES (N'Hoa', N'002', N'Lien', 222, 222)
INSERT [dbo].[LopHocPhan] ([TenLopHocPhan], [MaLopHocPhan], [GiaoVienPhuTrach], [SoLuongSinhVienDangKy], [DinhMucSinhVien]) VALUES (N'wwwwwwwww', N'tin002', N'phu2', 2, 333)
INSERT [dbo].[SinhVien] ([MaSinhVien], [HoDem], [Ten], [NgaySinh], [QueQuan], [MaLopHocPhan]) VALUES (N'16T1021127', N'ooooo', N'ssss', CAST(N'1998-09-09' AS Date), N'Huewwwwwww', N'')
USE [master]
GO
ALTER DATABASE [QSLV_LHP] SET  READ_WRITE 
GO
