USE [master]
GO
/****** Object:  Database [shopmanagerDB]    Script Date: 24-Sep-20 3:42:12 AM ******/
CREATE DATABASE [shopmanagerDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'shopmanagerDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\shopmanagerDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'shopmanagerDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\shopmanagerDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [shopmanagerDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [shopmanagerDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [shopmanagerDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [shopmanagerDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [shopmanagerDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [shopmanagerDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [shopmanagerDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [shopmanagerDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [shopmanagerDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [shopmanagerDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [shopmanagerDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [shopmanagerDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [shopmanagerDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [shopmanagerDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [shopmanagerDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [shopmanagerDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [shopmanagerDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [shopmanagerDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [shopmanagerDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [shopmanagerDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [shopmanagerDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [shopmanagerDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [shopmanagerDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [shopmanagerDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [shopmanagerDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [shopmanagerDB] SET  MULTI_USER 
GO
ALTER DATABASE [shopmanagerDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [shopmanagerDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [shopmanagerDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [shopmanagerDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [shopmanagerDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [shopmanagerDB] SET QUERY_STORE = OFF
GO
USE [shopmanagerDB]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 24-Sep-20 3:42:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [varchar](200) NOT NULL,
	[CurrentStock] [int] NOT NULL,
	[Description] [varchar](max) NULL,
	[BuyingCost] [float] NOT NULL,
	[Price] [float] NOT NULL,
	[RestockDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sales]    Script Date: 24-Sep-20 3:42:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sales](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NOT NULL,
	[SalesmanId] [varchar](50) NULL,
	[SalesPrice] [float] NOT NULL,
	[Profit] [float] NOT NULL,
	[Date] [date] NOT NULL,
	[Quantity] [float] NOT NULL,
 CONSTRAINT [PK_Sells] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 24-Sep-20 3:42:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserName] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Role] [varchar](20) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_Products_CurrentStock]  DEFAULT ((0)) FOR [CurrentStock]
GO
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_Products_BuyingCost]  DEFAULT ((0.00)) FOR [BuyingCost]
GO
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_Products_Price]  DEFAULT ((0.00)) FOR [Price]
GO
ALTER TABLE [dbo].[Sales] ADD  CONSTRAINT [DF_Sells_SalesPrice]  DEFAULT ((0.00)) FOR [SalesPrice]
GO
ALTER TABLE [dbo].[Sales] ADD  CONSTRAINT [DF_Sells_Profit]  DEFAULT ((0.00)) FOR [Profit]
GO
ALTER TABLE [dbo].[Sales] ADD  CONSTRAINT [DF_Sells_Quantity]  DEFAULT ((0.00)) FOR [Quantity]
GO
USE [master]
GO
ALTER DATABASE [shopmanagerDB] SET  READ_WRITE 
GO
