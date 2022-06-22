USE [master]
GO
/****** Object:  Database [HuellasDB]    Script Date: 15/6/2022 19:26:40 ******/
CREATE DATABASE [HuellasDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HuellaDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\HuellaDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HuellaDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\HuellaDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [HuellasDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HuellasDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HuellasDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HuellasDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HuellasDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HuellasDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HuellasDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [HuellasDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HuellasDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HuellasDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HuellasDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HuellasDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HuellasDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HuellasDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HuellasDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HuellasDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HuellasDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HuellasDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HuellasDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HuellasDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HuellasDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HuellasDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HuellasDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HuellasDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HuellasDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [HuellasDB] SET  MULTI_USER 
GO
ALTER DATABASE [HuellasDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HuellasDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HuellasDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HuellasDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HuellasDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [HuellasDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [HuellasDB] SET QUERY_STORE = OFF
GO
USE [HuellasDB]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 15/6/2022 19:26:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Adopters]    Script Date: 15/6/2022 19:26:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Adopters](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NombreCompleto] [nvarchar](max) NULL,
	[Telefono] [int] NOT NULL,
	[Email] [nvarchar](max) NULL,
	[MascotaDeInteres] [nvarchar](max) NULL,
 CONSTRAINT [PK_Adopters] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pets]    Script Date: 15/6/2022 19:26:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pets](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](max) NULL,
	[Edad] [int] NOT NULL,
	[Tipo] [int] NOT NULL,
	[Tamanio] [int] NOT NULL,
	[Genero] [int] NOT NULL,
	[Vacunado] [bit] NOT NULL,
	[Castrado] [bit] NOT NULL,
	[Descripcion] [nvarchar](max) NULL,
 CONSTRAINT [PK_Pets] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220609020807_HUELLAS_PNT1.Context.HuellasDatabaseContext', N'3.1.3')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220609034416_HUELLAS_PNT1.Context.HuellasDatabaseContext', N'3.1.25')
GO
SET IDENTITY_INSERT [dbo].[Pets] ON 

INSERT [dbo].[Pets] ([Id], [Nombre], [Edad], [Tipo], [Tamanio], [Genero], [Vacunado], [Castrado], [Descripcion]) VALUES (1, N'Don Satur', 5, 1, 1, 1, 1, 1, N'Soy Don Satur')
SET IDENTITY_INSERT [dbo].[Pets] OFF
GO
USE [master]
GO
ALTER DATABASE [HuellasDB] SET  READ_WRITE 
GO
