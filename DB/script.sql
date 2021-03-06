USE [master]
GO
/****** Object:  Database [posDB]    Script Date: 2021/5/16 週日 下午 09:37:19 ******/
CREATE DATABASE [posDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'posDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\posDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'posDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\posDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [posDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [posDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [posDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [posDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [posDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [posDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [posDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [posDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [posDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [posDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [posDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [posDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [posDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [posDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [posDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [posDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [posDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [posDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [posDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [posDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [posDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [posDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [posDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [posDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [posDB] SET RECOVERY FULL 
GO
ALTER DATABASE [posDB] SET  MULTI_USER 
GO
ALTER DATABASE [posDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [posDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [posDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [posDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [posDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [posDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'posDB', N'ON'
GO
ALTER DATABASE [posDB] SET QUERY_STORE = OFF
GO
USE [posDB]
GO
/****** Object:  Table [dbo].[Customize]    Script Date: 2021/5/16 週日 下午 09:37:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customize](
	[cus_id] [int] NOT NULL,
	[cus_name] [nvarchar](30) NOT NULL,
	[cus_price] [int] NOT NULL,
	[type_id] [int] NOT NULL,
 CONSTRAINT [PK_Customize] PRIMARY KEY CLUSTERED 
(
	[cus_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[food]    Script Date: 2021/5/16 週日 下午 09:37:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[food](
	[food_id] [int] NOT NULL,
	[food_name] [nvarchar](20) NULL,
	[food_price] [int] NULL,
	[food_onSelf] [bit] NULL,
	[type_id] [int] NULL,
 CONSTRAINT [PK_food] PRIMARY KEY CLUSTERED 
(
	[food_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[orderItemList]    Script Date: 2021/5/16 週日 下午 09:37:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orderItemList](
	[orders_id] [int] NOT NULL,
	[item_id] [int] NOT NULL,
	[food_id] [int] NULL,
	[cus_id] [int] NULL,
	[cus_id2] [int] NULL,
	[item_subTotal] [int] NULL,
	[item_isFinish] [bit] NULL,
 CONSTRAINT [PK_orderItemList] PRIMARY KEY CLUSTERED 
(
	[item_id] ASC,
	[orders_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[orders]    Script Date: 2021/5/16 週日 下午 09:37:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orders](
	[orders_id] [int] NOT NULL,
	[orders_orderTime] [datetime] NULL,
	[orders_customerName] [nvarchar](30) NULL,
	[orders_isComplete] [bit] NULL,
	[orders_Total] [int] NULL,
 CONSTRAINT [PK_orders] PRIMARY KEY CLUSTERED 
(
	[orders_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Type]    Script Date: 2021/5/16 週日 下午 09:37:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Type](
	[type_id] [int] NOT NULL,
	[type_name] [nvarchar](15) NOT NULL,
	[type_isDrink] [bit] NOT NULL,
	[type_onSelf] [bit] NULL,
 CONSTRAINT [PK_Type] PRIMARY KEY CLUSTERED 
(
	[type_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 2021/5/16 週日 下午 09:37:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[users_account] [nvarchar](50) NOT NULL,
	[users_password] [nvarchar](50) NOT NULL,
	[uses_permissions] [int] NULL,
	[users_name] [nvarchar](50) NULL,
 CONSTRAINT [PK_passWord] PRIMARY KEY CLUSTERED 
(
	[users_account] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Customize] ([cus_id], [cus_name], [cus_price], [type_id]) VALUES (0, N'加起司', 5, 0)
INSERT [dbo].[Customize] ([cus_id], [cus_name], [cus_price], [type_id]) VALUES (1, N'加　蛋', 10, 0)
INSERT [dbo].[Customize] ([cus_id], [cus_name], [cus_price], [type_id]) VALUES (2, N'加起司', 5, 1)
INSERT [dbo].[Customize] ([cus_id], [cus_name], [cus_price], [type_id]) VALUES (3, N'加　蛋', 10, 1)
INSERT [dbo].[Customize] ([cus_id], [cus_name], [cus_price], [type_id]) VALUES (4, N'加起司', 5, 2)
INSERT [dbo].[Customize] ([cus_id], [cus_name], [cus_price], [type_id]) VALUES (5, N'加　蛋', 10, 2)
INSERT [dbo].[Customize] ([cus_id], [cus_name], [cus_price], [type_id]) VALUES (6, N'正常甜', 0, 3)
INSERT [dbo].[Customize] ([cus_id], [cus_name], [cus_price], [type_id]) VALUES (7, N'少　糖', 0, 3)
INSERT [dbo].[Customize] ([cus_id], [cus_name], [cus_price], [type_id]) VALUES (8, N'微　糖', 0, 3)
INSERT [dbo].[Customize] ([cus_id], [cus_name], [cus_price], [type_id]) VALUES (9, N'無　糖', 0, 3)
INSERT [dbo].[Customize] ([cus_id], [cus_name], [cus_price], [type_id]) VALUES (10, N'正常冰', 0, 3)
INSERT [dbo].[Customize] ([cus_id], [cus_name], [cus_price], [type_id]) VALUES (11, N'少　冰', 0, 3)
INSERT [dbo].[Customize] ([cus_id], [cus_name], [cus_price], [type_id]) VALUES (12, N'微　冰', 0, 3)
INSERT [dbo].[Customize] ([cus_id], [cus_name], [cus_price], [type_id]) VALUES (13, N'去　冰', 0, 3)
INSERT [dbo].[Customize] ([cus_id], [cus_name], [cus_price], [type_id]) VALUES (14, N'正常甜', 0, 4)
INSERT [dbo].[Customize] ([cus_id], [cus_name], [cus_price], [type_id]) VALUES (141, N'少　糖', 0, 4)
INSERT [dbo].[Customize] ([cus_id], [cus_name], [cus_price], [type_id]) VALUES (1411, N'微　糖', 0, 4)
INSERT [dbo].[Customize] ([cus_id], [cus_name], [cus_price], [type_id]) VALUES (14111, N'無　糖', 0, 4)
INSERT [dbo].[Customize] ([cus_id], [cus_name], [cus_price], [type_id]) VALUES (141111, N'正常冰', 0, 4)
INSERT [dbo].[Customize] ([cus_id], [cus_name], [cus_price], [type_id]) VALUES (1411111, N'少　冰', 0, 4)
INSERT [dbo].[Customize] ([cus_id], [cus_name], [cus_price], [type_id]) VALUES (14111111, N'微　冰', 0, 4)
INSERT [dbo].[Customize] ([cus_id], [cus_name], [cus_price], [type_id]) VALUES (141111111, N'去　冰', 0, 4)
INSERT [dbo].[Customize] ([cus_id], [cus_name], [cus_price], [type_id]) VALUES (141111112, N'加起司', 5, 5)
INSERT [dbo].[Customize] ([cus_id], [cus_name], [cus_price], [type_id]) VALUES (1411111121, N'加　蛋', 10, 5)
GO
INSERT [dbo].[food] ([food_id], [food_name], [food_price], [food_onSelf], [type_id]) VALUES (0, N'火腿吐司', 35, 1, 0)
INSERT [dbo].[food] ([food_id], [food_name], [food_price], [food_onSelf], [type_id]) VALUES (1, N'培根吐司', 35, 1, 0)
INSERT [dbo].[food] ([food_id], [food_name], [food_price], [food_onSelf], [type_id]) VALUES (2, N'薯餅吐司', 40, 1, 0)
INSERT [dbo].[food] ([food_id], [food_name], [food_price], [food_onSelf], [type_id]) VALUES (3, N'燒肉吐司', 45, 1, 0)
INSERT [dbo].[food] ([food_id], [food_name], [food_price], [food_onSelf], [type_id]) VALUES (4, N'牛肉吐司', 50, 1, 0)
INSERT [dbo].[food] ([food_id], [food_name], [food_price], [food_onSelf], [type_id]) VALUES (5, N'火腿漢堡', 35, 1, 1)
INSERT [dbo].[food] ([food_id], [food_name], [food_price], [food_onSelf], [type_id]) VALUES (6, N'培根漢堡', 35, 1, 1)
INSERT [dbo].[food] ([food_id], [food_name], [food_price], [food_onSelf], [type_id]) VALUES (7, N'薯餅漢堡', 40, 1, 1)
INSERT [dbo].[food] ([food_id], [food_name], [food_price], [food_onSelf], [type_id]) VALUES (8, N'燒肉漢堡', 45, 1, 1)
INSERT [dbo].[food] ([food_id], [food_name], [food_price], [food_onSelf], [type_id]) VALUES (9, N'牛肉漢堡', 50, 1, 1)
INSERT [dbo].[food] ([food_id], [food_name], [food_price], [food_onSelf], [type_id]) VALUES (10, N'火腿總匯', 35, 1, 2)
INSERT [dbo].[food] ([food_id], [food_name], [food_price], [food_onSelf], [type_id]) VALUES (11, N'培根總匯', 35, 1, 2)
INSERT [dbo].[food] ([food_id], [food_name], [food_price], [food_onSelf], [type_id]) VALUES (12, N'薯餅總匯', 40, 1, 2)
INSERT [dbo].[food] ([food_id], [food_name], [food_price], [food_onSelf], [type_id]) VALUES (13, N'燒肉總匯', 45, 1, 2)
INSERT [dbo].[food] ([food_id], [food_name], [food_price], [food_onSelf], [type_id]) VALUES (14, N'牛肉總匯', 50, 1, 2)
INSERT [dbo].[food] ([food_id], [food_name], [food_price], [food_onSelf], [type_id]) VALUES (15, N'紅茶', 30, 1, 3)
INSERT [dbo].[food] ([food_id], [food_name], [food_price], [food_onSelf], [type_id]) VALUES (16, N'綠茶', 30, 1, 3)
INSERT [dbo].[food] ([food_id], [food_name], [food_price], [food_onSelf], [type_id]) VALUES (17, N'奶茶', 40, 1, 3)
INSERT [dbo].[food] ([food_id], [food_name], [food_price], [food_onSelf], [type_id]) VALUES (18, N'豆漿', 40, 1, 3)
INSERT [dbo].[food] ([food_id], [food_name], [food_price], [food_onSelf], [type_id]) VALUES (19, N'咖啡', 45, 1, 3)
INSERT [dbo].[food] ([food_id], [food_name], [food_price], [food_onSelf], [type_id]) VALUES (20, N'td', 100, 0, 4)
INSERT [dbo].[food] ([food_id], [food_name], [food_price], [food_onSelf], [type_id]) VALUES (21, N't', 35, 0, 5)
GO
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (0, 1, 6, -1, 1, 45, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (0, 2, 6, -1, -1, 35, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (0, 3, 6, -1, -1, 35, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (0, 4, 6, -1, -1, 35, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (0, 5, 9, -1, -1, 50, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (0, 6, 8, -1, -1, 45, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (0, 7, 7, -1, -1, 40, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (0, 8, 6, -1, -1, 35, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (0, 9, 7, -1, -1, 40, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (0, 10, 8, -1, -1, 45, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (1, 11, 6, -1, 1, 45, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (2, 12, 9, -1, -1, 50, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (2, 13, 7, 0, 1, 55, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (3, 15, 6, -1, 1, 45, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (3, 16, 10, 0, -1, 40, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (3, 17, 16, 6, 10, 30, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (4, 18, 7, -1, 1, 50, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (4, 19, 6, -1, 1, 35, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (4, 20, 11, -1, 1, 45, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (5, 21, 6, -1, 1, 45, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (6, 22, 0, 0, -1, 40, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (7, 23, 6, -1, 1, 45, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (8, 24, 5, 0, -1, 40, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (9, 25, 12, -1, 1, 50, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (10, 26, 6, -1, 1, 45, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (10, 27, 7, 0, 1, 55, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (11, 28, 6, -1, 1, 45, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (12, 29, 12, -1, 1, 50, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (13, 30, 16, 6, 10, 30, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (13, 31, 16, 6, 10, 30, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (13, 32, 16, 6, 10, 30, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (13, 33, 16, 6, 10, 30, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (13, 34, 16, 6, 10, 30, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (13, 35, 16, 6, 10, 30, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (13, 36, 16, 6, 10, 30, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (13, 37, 16, 6, 10, 30, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (13, 38, 16, 6, 10, 30, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (14, 39, 17, 6, 10, 40, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (14, 40, 17, 6, 10, 40, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (14, 41, 17, 6, 10, 40, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (14, 42, 17, 6, 10, 40, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (14, 43, 17, 6, 10, 40, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (14, 44, 17, 6, 10, 40, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (14, 45, 17, 6, 10, 40, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (14, 46, 17, 6, 10, 40, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (14, 47, 17, 6, 10, 40, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (14, 48, 17, 6, 10, 40, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (14, 49, 17, 6, 10, 40, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (14, 50, 17, 6, 10, 40, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (14, 51, 17, 6, 10, 40, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (14, 52, 17, 6, 10, 40, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (14, 53, 17, 6, 10, 40, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (14, 54, 17, 6, 10, 40, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (14, 55, 17, 6, 10, 40, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (14, 56, 17, 6, 10, 40, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (14, 57, 17, 6, 10, 40, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (14, 58, 17, 6, 10, 40, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (15, 59, 16, 7, 10, 30, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (15, 60, 17, 6, 10, 40, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (15, 61, 17, 6, 10, 40, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (15, 62, 16, 6, 10, 30, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (15, 63, 16, 6, 10, 30, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (15, 64, 16, 6, 10, 30, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (15, 65, 16, 6, 10, 30, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (15, 66, 16, 6, 10, 30, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (15, 67, 16, 6, 10, 30, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (15, 68, 16, 6, 10, 30, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (15, 69, 16, 6, 10, 30, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (15, 70, 16, 6, 10, 30, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (15, 71, 16, 6, 10, 30, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (15, 72, 16, 6, 10, 30, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (15, 73, 16, 6, 10, 30, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (15, 74, 16, 6, 10, 30, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (15, 75, 16, 6, 10, 30, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (15, 76, 16, 6, 10, 30, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (15, 77, 16, 6, 10, 30, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (15, 78, 16, 6, 10, 30, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (15, 79, 16, 6, 10, 30, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (15, 80, 16, 6, 10, 30, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (15, 81, 16, 6, 10, 30, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (15, 82, 17, 6, 10, 40, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (15, 83, 18, 6, 10, 40, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (15, 84, 19, 6, 10, 45, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (15, 85, 17, 6, 10, 40, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (15, 86, 19, 6, 12, 45, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (16, 90, 17, 6, 10, 40, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (16, 92, 17, 8, 10, 40, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (17, 93, 1, -1, 1, 45, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (17, 94, 19, -1, -1, 45, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (17, 95, 0, -1, 1, 45, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (18, 133, 7, -1, -1, 40, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (19, 137, 5, 0, 1, 50, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (20, 141, 12, -1, -1, 40, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (20, 142, 13, -1, 1, 55, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (22, 147, 17, 8, 10, 40, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (23, 152, 15, 6, 10, 30, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (24, 157, 17, 6, 10, 40, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (25, 162, 0, 0, -1, 40, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (26, 167, 0, 0, -1, 40, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (37, 176, 17, 6, 10, 40, 0)
GO
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (38, 177, 17, 8, 10, 40, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (39, 178, 6, -1, 1, 45, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (39, 179, 8, -1, 1, 55, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (40, 180, 6, -1, 1, 45, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (41, 181, 12, -1, -1, 40, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (42, 182, 12, -1, -1, 40, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (43, 183, 12, -1, -1, 40, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (44, 185, 7, -1, 1, 50, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (44, 187, 17, 8, 10, 40, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (45, 188, 10, 0, 1, 50, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (45, 190, 17, 7, 10, 40, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (45, 191, 12, -1, 1, 50, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (45, 192, 12, -1, 1, 50, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (45, 193, 12, -1, -1, 40, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (46, 194, 6, 0, 1, 50, 1)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (46, 195, 8, 0, 1, 60, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (47, 196, 6, -1, 1, 45, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (47, 197, 17, 8, 10, 40, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (47, 198, 6, -1, 1, 45, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (47, 199, 6, -1, 1, 45, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (47, 200, 6, -1, 1, 45, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (47, 201, 14, -1, 1, 60, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (47, 202, 11, -1, 1, 45, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (47, 203, 6, -1, 1, 45, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (47, 204, 6, -1, 1, 45, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (47, 205, 6, -1, 1, 45, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (48, 206, 1, 0, -1, 40, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (49, 207, 6, -1, 1, 45, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (49, 209, 0, -1, 1, 45, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (49, 211, 0, 0, -1, 40, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (50, 212, 21, 0, 1, 50, 0)
INSERT [dbo].[orderItemList] ([orders_id], [item_id], [food_id], [cus_id], [cus_id2], [item_subTotal], [item_isFinish]) VALUES (50, 213, 21, -1, 1, 45, 0)
GO
INSERT [dbo].[orders] ([orders_id], [orders_orderTime], [orders_customerName], [orders_isComplete], [orders_Total]) VALUES (0, CAST(N'2021-04-26T21:25:26.000' AS DateTime), N'1', 1, 405)
INSERT [dbo].[orders] ([orders_id], [orders_orderTime], [orders_customerName], [orders_isComplete], [orders_Total]) VALUES (1, CAST(N'2021-04-26T21:29:23.000' AS DateTime), N'2', 1, 45)
INSERT [dbo].[orders] ([orders_id], [orders_orderTime], [orders_customerName], [orders_isComplete], [orders_Total]) VALUES (2, CAST(N'2021-04-26T21:29:35.000' AS DateTime), N'3', 1, 105)
INSERT [dbo].[orders] ([orders_id], [orders_orderTime], [orders_customerName], [orders_isComplete], [orders_Total]) VALUES (3, CAST(N'2021-04-26T21:31:09.000' AS DateTime), N'1', 1, 115)
INSERT [dbo].[orders] ([orders_id], [orders_orderTime], [orders_customerName], [orders_isComplete], [orders_Total]) VALUES (4, CAST(N'2021-04-26T21:36:27.000' AS DateTime), N'1', 1, 130)
INSERT [dbo].[orders] ([orders_id], [orders_orderTime], [orders_customerName], [orders_isComplete], [orders_Total]) VALUES (5, CAST(N'2021-04-26T21:36:44.000' AS DateTime), N'f', 1, 45)
INSERT [dbo].[orders] ([orders_id], [orders_orderTime], [orders_customerName], [orders_isComplete], [orders_Total]) VALUES (6, CAST(N'2021-04-26T21:36:50.000' AS DateTime), N'e', 1, 40)
INSERT [dbo].[orders] ([orders_id], [orders_orderTime], [orders_customerName], [orders_isComplete], [orders_Total]) VALUES (7, CAST(N'2021-04-26T23:36:57.000' AS DateTime), N'j', 1, 45)
INSERT [dbo].[orders] ([orders_id], [orders_orderTime], [orders_customerName], [orders_isComplete], [orders_Total]) VALUES (8, CAST(N'2021-04-26T23:37:04.000' AS DateTime), N'y', 1, 40)
INSERT [dbo].[orders] ([orders_id], [orders_orderTime], [orders_customerName], [orders_isComplete], [orders_Total]) VALUES (9, CAST(N'2021-04-26T23:37:13.000' AS DateTime), N't', 1, 50)
INSERT [dbo].[orders] ([orders_id], [orders_orderTime], [orders_customerName], [orders_isComplete], [orders_Total]) VALUES (10, CAST(N'2021-04-26T23:39:00.000' AS DateTime), N';', 1, 100)
INSERT [dbo].[orders] ([orders_id], [orders_orderTime], [orders_customerName], [orders_isComplete], [orders_Total]) VALUES (11, CAST(N'2021-04-26T23:47:45.000' AS DateTime), N'5', 1, 45)
INSERT [dbo].[orders] ([orders_id], [orders_orderTime], [orders_customerName], [orders_isComplete], [orders_Total]) VALUES (12, CAST(N'2021-04-26T23:48:09.000' AS DateTime), N'FG', 1, 50)
INSERT [dbo].[orders] ([orders_id], [orders_orderTime], [orders_customerName], [orders_isComplete], [orders_Total]) VALUES (13, CAST(N'2021-04-26T23:52:36.000' AS DateTime), N'f', 1, 270)
INSERT [dbo].[orders] ([orders_id], [orders_orderTime], [orders_customerName], [orders_isComplete], [orders_Total]) VALUES (14, CAST(N'2021-04-26T23:53:05.000' AS DateTime), N'h', 1, 800)
INSERT [dbo].[orders] ([orders_id], [orders_orderTime], [orders_customerName], [orders_isComplete], [orders_Total]) VALUES (15, CAST(N'2021-04-26T23:54:11.000' AS DateTime), N'j', 1, 920)
INSERT [dbo].[orders] ([orders_id], [orders_orderTime], [orders_customerName], [orders_isComplete], [orders_Total]) VALUES (16, CAST(N'2021-04-27T11:54:40.000' AS DateTime), N'SS', 1, 80)
INSERT [dbo].[orders] ([orders_id], [orders_orderTime], [orders_customerName], [orders_isComplete], [orders_Total]) VALUES (17, CAST(N'2021-04-29T00:38:18.000' AS DateTime), N'NNN', 1, 135)
INSERT [dbo].[orders] ([orders_id], [orders_orderTime], [orders_customerName], [orders_isComplete], [orders_Total]) VALUES (18, CAST(N'2021-04-29T10:33:28.000' AS DateTime), N'123', 1, 40)
INSERT [dbo].[orders] ([orders_id], [orders_orderTime], [orders_customerName], [orders_isComplete], [orders_Total]) VALUES (19, CAST(N'2021-04-29T10:34:02.000' AS DateTime), N'555', 1, 50)
INSERT [dbo].[orders] ([orders_id], [orders_orderTime], [orders_customerName], [orders_isComplete], [orders_Total]) VALUES (20, CAST(N'2021-04-29T10:34:40.000' AS DateTime), N'test', 1, 95)
INSERT [dbo].[orders] ([orders_id], [orders_orderTime], [orders_customerName], [orders_isComplete], [orders_Total]) VALUES (21, CAST(N'2021-04-29T10:35:31.000' AS DateTime), N'1', 1, 0)
INSERT [dbo].[orders] ([orders_id], [orders_orderTime], [orders_customerName], [orders_isComplete], [orders_Total]) VALUES (22, CAST(N'2021-04-29T10:36:07.000' AS DateTime), N'5', 1, 40)
INSERT [dbo].[orders] ([orders_id], [orders_orderTime], [orders_customerName], [orders_isComplete], [orders_Total]) VALUES (23, CAST(N'2021-04-29T10:37:55.000' AS DateTime), N'PAN', 1, 30)
INSERT [dbo].[orders] ([orders_id], [orders_orderTime], [orders_customerName], [orders_isComplete], [orders_Total]) VALUES (24, CAST(N'2021-04-29T10:38:33.000' AS DateTime), N'oo', 1, 40)
INSERT [dbo].[orders] ([orders_id], [orders_orderTime], [orders_customerName], [orders_isComplete], [orders_Total]) VALUES (25, CAST(N'2021-04-29T10:39:10.000' AS DateTime), N'DD', 1, 40)
INSERT [dbo].[orders] ([orders_id], [orders_orderTime], [orders_customerName], [orders_isComplete], [orders_Total]) VALUES (26, CAST(N'2021-04-29T10:39:43.000' AS DateTime), N'123', 1, 40)
INSERT [dbo].[orders] ([orders_id], [orders_orderTime], [orders_customerName], [orders_isComplete], [orders_Total]) VALUES (27, CAST(N'2021-04-29T10:40:43.000' AS DateTime), N'L', 1, 0)
INSERT [dbo].[orders] ([orders_id], [orders_orderTime], [orders_customerName], [orders_isComplete], [orders_Total]) VALUES (28, CAST(N'2021-04-29T10:42:14.000' AS DateTime), N'p', 1, 0)
INSERT [dbo].[orders] ([orders_id], [orders_orderTime], [orders_customerName], [orders_isComplete], [orders_Total]) VALUES (29, CAST(N'2021-04-29T10:48:37.000' AS DateTime), N'fghj', 1, 0)
INSERT [dbo].[orders] ([orders_id], [orders_orderTime], [orders_customerName], [orders_isComplete], [orders_Total]) VALUES (30, CAST(N'2021-04-29T10:48:58.000' AS DateTime), N'sad', 1, 0)
INSERT [dbo].[orders] ([orders_id], [orders_orderTime], [orders_customerName], [orders_isComplete], [orders_Total]) VALUES (31, CAST(N'2021-04-29T10:50:47.000' AS DateTime), N'fdg', 1, 0)
INSERT [dbo].[orders] ([orders_id], [orders_orderTime], [orders_customerName], [orders_isComplete], [orders_Total]) VALUES (32, CAST(N'2021-04-29T10:51:05.000' AS DateTime), N'f', 1, 0)
INSERT [dbo].[orders] ([orders_id], [orders_orderTime], [orders_customerName], [orders_isComplete], [orders_Total]) VALUES (33, CAST(N'2021-04-29T10:52:41.000' AS DateTime), N'123', 1, 0)
INSERT [dbo].[orders] ([orders_id], [orders_orderTime], [orders_customerName], [orders_isComplete], [orders_Total]) VALUES (34, CAST(N'2021-04-29T10:56:28.000' AS DateTime), N'55', 1, 0)
INSERT [dbo].[orders] ([orders_id], [orders_orderTime], [orders_customerName], [orders_isComplete], [orders_Total]) VALUES (35, CAST(N'2021-04-29T11:03:06.000' AS DateTime), N'd', 1, 0)
INSERT [dbo].[orders] ([orders_id], [orders_orderTime], [orders_customerName], [orders_isComplete], [orders_Total]) VALUES (36, CAST(N'2021-04-29T13:19:31.000' AS DateTime), N'sd', 1, 0)
INSERT [dbo].[orders] ([orders_id], [orders_orderTime], [orders_customerName], [orders_isComplete], [orders_Total]) VALUES (37, CAST(N'2021-04-29T13:50:33.000' AS DateTime), N'55', 1, 40)
INSERT [dbo].[orders] ([orders_id], [orders_orderTime], [orders_customerName], [orders_isComplete], [orders_Total]) VALUES (38, CAST(N'2021-04-29T13:50:57.000' AS DateTime), N'55', 1, 40)
INSERT [dbo].[orders] ([orders_id], [orders_orderTime], [orders_customerName], [orders_isComplete], [orders_Total]) VALUES (39, CAST(N'2021-04-29T14:02:35.000' AS DateTime), N'l', 1, 100)
INSERT [dbo].[orders] ([orders_id], [orders_orderTime], [orders_customerName], [orders_isComplete], [orders_Total]) VALUES (40, CAST(N'2021-04-29T14:40:07.000' AS DateTime), N'1234567894', 1, 45)
INSERT [dbo].[orders] ([orders_id], [orders_orderTime], [orders_customerName], [orders_isComplete], [orders_Total]) VALUES (41, CAST(N'2021-04-29T14:41:01.000' AS DateTime), N'123456', 1, 40)
INSERT [dbo].[orders] ([orders_id], [orders_orderTime], [orders_customerName], [orders_isComplete], [orders_Total]) VALUES (42, CAST(N'2021-04-29T14:41:59.000' AS DateTime), N'jack', 1, 40)
INSERT [dbo].[orders] ([orders_id], [orders_orderTime], [orders_customerName], [orders_isComplete], [orders_Total]) VALUES (43, CAST(N'2021-04-29T14:43:00.000' AS DateTime), N'Jen', 1, 40)
INSERT [dbo].[orders] ([orders_id], [orders_orderTime], [orders_customerName], [orders_isComplete], [orders_Total]) VALUES (44, CAST(N'2021-04-29T14:44:10.000' AS DateTime), N'Rick', 1, 90)
INSERT [dbo].[orders] ([orders_id], [orders_orderTime], [orders_customerName], [orders_isComplete], [orders_Total]) VALUES (45, CAST(N'2021-04-29T14:54:34.000' AS DateTime), N'Jack', 1, 230)
INSERT [dbo].[orders] ([orders_id], [orders_orderTime], [orders_customerName], [orders_isComplete], [orders_Total]) VALUES (46, CAST(N'2021-05-03T13:14:56.000' AS DateTime), N'456', 0, 110)
INSERT [dbo].[orders] ([orders_id], [orders_orderTime], [orders_customerName], [orders_isComplete], [orders_Total]) VALUES (47, CAST(N'2021-05-05T15:09:13.000' AS DateTime), N'456', 0, 460)
INSERT [dbo].[orders] ([orders_id], [orders_orderTime], [orders_customerName], [orders_isComplete], [orders_Total]) VALUES (48, CAST(N'2021-05-09T21:49:49.000' AS DateTime), N'sd', 0, 40)
INSERT [dbo].[orders] ([orders_id], [orders_orderTime], [orders_customerName], [orders_isComplete], [orders_Total]) VALUES (49, CAST(N'2021-05-09T21:50:54.000' AS DateTime), N'56', 0, 130)
INSERT [dbo].[orders] ([orders_id], [orders_orderTime], [orders_customerName], [orders_isComplete], [orders_Total]) VALUES (50, CAST(N'2021-05-16T21:34:54.000' AS DateTime), N'123', 0, 95)
GO
INSERT [dbo].[Type] ([type_id], [type_name], [type_isDrink], [type_onSelf]) VALUES (0, N'吐　司', 0, 1)
INSERT [dbo].[Type] ([type_id], [type_name], [type_isDrink], [type_onSelf]) VALUES (1, N'漢　堡', 0, 1)
INSERT [dbo].[Type] ([type_id], [type_name], [type_isDrink], [type_onSelf]) VALUES (2, N'總　匯', 0, 1)
INSERT [dbo].[Type] ([type_id], [type_name], [type_isDrink], [type_onSelf]) VALUES (3, N'飲　料', 1, 1)
INSERT [dbo].[Type] ([type_id], [type_name], [type_isDrink], [type_onSelf]) VALUES (4, N'testDrink', 1, 0)
INSERT [dbo].[Type] ([type_id], [type_name], [type_isDrink], [type_onSelf]) VALUES (5, N'test', 0, 0)
GO
INSERT [dbo].[users] ([users_account], [users_password], [uses_permissions], [users_name]) VALUES (N'employee1', N'password', 0, N'員工1')
INSERT [dbo].[users] ([users_account], [users_password], [uses_permissions], [users_name]) VALUES (N'hera', N'password', 0, N'希拉')
INSERT [dbo].[users] ([users_account], [users_password], [uses_permissions], [users_name]) VALUES (N'manager1', N'password', 1, N'管理1')
INSERT [dbo].[users] ([users_account], [users_password], [uses_permissions], [users_name]) VALUES (N'ricky', N'password', 0, N'奇奇')
INSERT [dbo].[users] ([users_account], [users_password], [uses_permissions], [users_name]) VALUES (N'root', N'password', 2, N'老闆')
GO
ALTER TABLE [dbo].[food] ADD  CONSTRAINT [DF_food_food_onSelf]  DEFAULT ((1)) FOR [food_onSelf]
GO
ALTER TABLE [dbo].[orderItemList] ADD  CONSTRAINT [DF_orderItemList_orderItemList_isFinish]  DEFAULT ((0)) FOR [item_isFinish]
GO
ALTER TABLE [dbo].[Customize]  WITH CHECK ADD  CONSTRAINT [FK_Customize_Type] FOREIGN KEY([type_id])
REFERENCES [dbo].[Type] ([type_id])
GO
ALTER TABLE [dbo].[Customize] CHECK CONSTRAINT [FK_Customize_Type]
GO
ALTER TABLE [dbo].[food]  WITH CHECK ADD  CONSTRAINT [FK_food_Type] FOREIGN KEY([type_id])
REFERENCES [dbo].[Type] ([type_id])
GO
ALTER TABLE [dbo].[food] CHECK CONSTRAINT [FK_food_Type]
GO
ALTER TABLE [dbo].[orderItemList]  WITH CHECK ADD  CONSTRAINT [FK_orderItemList_food] FOREIGN KEY([food_id])
REFERENCES [dbo].[food] ([food_id])
GO
ALTER TABLE [dbo].[orderItemList] CHECK CONSTRAINT [FK_orderItemList_food]
GO
USE [master]
GO
ALTER DATABASE [posDB] SET  READ_WRITE 
GO
