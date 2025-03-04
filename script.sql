USE [master]
GO
/****** Object:  Database [ResturentSystem]    Script Date: 6/21/2023 4:28:36 PM ******/
CREATE DATABASE [ResturentSystem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ResturentSystem', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\ResturentSystem.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ResturentSystem_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\ResturentSystem_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [ResturentSystem] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ResturentSystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ResturentSystem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ResturentSystem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ResturentSystem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ResturentSystem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ResturentSystem] SET ARITHABORT OFF 
GO
ALTER DATABASE [ResturentSystem] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ResturentSystem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ResturentSystem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ResturentSystem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ResturentSystem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ResturentSystem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ResturentSystem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ResturentSystem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ResturentSystem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ResturentSystem] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ResturentSystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ResturentSystem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ResturentSystem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ResturentSystem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ResturentSystem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ResturentSystem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ResturentSystem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ResturentSystem] SET RECOVERY FULL 
GO
ALTER DATABASE [ResturentSystem] SET  MULTI_USER 
GO
ALTER DATABASE [ResturentSystem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ResturentSystem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ResturentSystem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ResturentSystem] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ResturentSystem] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'ResturentSystem', N'ON'
GO
ALTER DATABASE [ResturentSystem] SET QUERY_STORE = OFF
GO
USE [ResturentSystem]
GO
/****** Object:  Table [dbo].[AssignedTask]    Script Date: 6/21/2023 4:28:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AssignedTask](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[table_id] [int] NULL,
	[staff_id] [int] NOT NULL,
	[delivery_id] [int] NULL,
 CONSTRAINT [PK_AssignedTask] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 6/21/2023 4:28:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[order_id] [int] NOT NULL,
	[billing_time] [datetime] NOT NULL,
	[amount_paid] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_Bill] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 6/21/2023 4:28:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[id] [int] NOT NULL,
	[phone] [varchar](6) NOT NULL,
	[address] [nvarchar](max) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DeliveryDetails]    Script Date: 6/21/2023 4:28:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DeliveryDetails](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[delivery_address] [varchar](max) NOT NULL,
	[postal_code] [varchar](10) NOT NULL,
	[city] [varchar](50) NOT NULL,
	[customer_id] [int] NULL,
 CONSTRAINT [PK_DeliveryDetails] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lookup]    Script Date: 6/21/2023 4:28:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lookup](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Value] [varchar](100) NOT NULL,
	[Category] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Lookup] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Menu]    Script Date: 6/21/2023 4:28:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Menu](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[category_id] [int] NOT NULL,
	[name] [varchar](50) NOT NULL,
	[description] [varchar](max) NULL,
	[price] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_Menu] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Menu_Category]    Script Date: 6/21/2023 4:28:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Menu_Category](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[cname] [varchar](50) NOT NULL,
	[description] [nvarchar](max) NULL,
 CONSTRAINT [PK_Menu_Category] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 6/21/2023 4:28:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[customer_id] [int] NULL,
	[table_id] [int] NULL,
	[staff_id] [int] NULL,
	[comments] [varchar](max) NULL,
	[delivery_id] [int] NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order_Items]    Script Date: 6/21/2023 4:28:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order_Items](
	[order_item_id] [int] IDENTITY(1,1) NOT NULL,
	[order_id] [int] NOT NULL,
	[menu_id] [int] NOT NULL,
	[price] [int] NOT NULL,
	[quantity] [int] NOT NULL,
 CONSTRAINT [PK_Order_Items] PRIMARY KEY CLUSTERED 
(
	[order_item_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reservation_Table]    Script Date: 6/21/2023 4:28:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reservation_Table](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[table_id] [int] NOT NULL,
	[customer_id] [int] NOT NULL,
	[reservation_date] [datetime] NULL,
	[status] [int] NOT NULL,
 CONSTRAINT [PK_Reservation_Table] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Seating_Table]    Script Date: 6/21/2023 4:28:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Seating_Table](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[table_no] [int] NOT NULL,
	[floor] [int] NOT NULL,
 CONSTRAINT [PK_Seating_Table] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staff]    Script Date: 6/21/2023 4:28:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff](
	[id] [int] NOT NULL,
	[phone] [varchar](6) NOT NULL,
	[address] [nvarchar](max) NULL,
	[hiredate] [datetime] NULL,
	[salary] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Staff] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 6/21/2023 4:28:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[usertype] [int] NULL,
	[first_name] [nvarchar](50) NOT NULL,
	[last_name] [nvarchar](50) NULL,
	[email] [nvarchar](50) NOT NULL,
	[gender] [int] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[AssignedTask] ON 

INSERT [dbo].[AssignedTask] ([id], [table_id], [staff_id], [delivery_id]) VALUES (11, 4, 10, NULL)
INSERT [dbo].[AssignedTask] ([id], [table_id], [staff_id], [delivery_id]) VALUES (12, 7, 10, NULL)
INSERT [dbo].[AssignedTask] ([id], [table_id], [staff_id], [delivery_id]) VALUES (13, 5, 10, NULL)
INSERT [dbo].[AssignedTask] ([id], [table_id], [staff_id], [delivery_id]) VALUES (14, NULL, 9, 1)
SET IDENTITY_INSERT [dbo].[AssignedTask] OFF
INSERT [dbo].[Customer] ([id], [phone], [address]) VALUES (6, N'0320', N'uet lahore')
SET IDENTITY_INSERT [dbo].[DeliveryDetails] ON 

INSERT [dbo].[DeliveryDetails] ([id], [delivery_address], [postal_code], [city], [customer_id]) VALUES (1, N'uet lahore zohra hall', N'113', N'lahore', 6)
SET IDENTITY_INSERT [dbo].[DeliveryDetails] OFF
SET IDENTITY_INSERT [dbo].[Lookup] ON 

INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (1, N'customer', N'usertype')
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (2, N'waiter', N'usertype')
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (3, N'deliveryman', N'usertype')
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (4, N'manager', N'usertype')
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (5, N'male', N'gender')
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (6, N'female', N'gender')
SET IDENTITY_INSERT [dbo].[Lookup] OFF
SET IDENTITY_INSERT [dbo].[Menu] ON 

INSERT [dbo].[Menu] ([id], [category_id], [name], [description], [price]) VALUES (1003, 2, N'tikka pizza', N'cheese,tomato,chicken cubes,almonds', CAST(2000 AS Decimal(18, 0)))
INSERT [dbo].[Menu] ([id], [category_id], [name], [description], [price]) VALUES (1004, 2, N'fagita pizza', N'cheese,tomato,chicken cubes,almond,corn', CAST(1700 AS Decimal(18, 0)))
INSERT [dbo].[Menu] ([id], [category_id], [name], [description], [price]) VALUES (1005, 2, N'supreme pizza', N'cheese,tomato,chicken cubes,mayo,almond,corn', CAST(1600 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[Menu] OFF
SET IDENTITY_INSERT [dbo].[Menu_Category] ON 

INSERT [dbo].[Menu_Category] ([id], [cname], [description]) VALUES (2, N'Italian Food', N'')
SET IDENTITY_INSERT [dbo].[Menu_Category] OFF
SET IDENTITY_INSERT [dbo].[Order] ON 

INSERT [dbo].[Order] ([id], [customer_id], [table_id], [staff_id], [comments], [delivery_id]) VALUES (1015, 6, NULL, NULL, NULL, 1)
INSERT [dbo].[Order] ([id], [customer_id], [table_id], [staff_id], [comments], [delivery_id]) VALUES (1016, NULL, 2, 10, NULL, NULL)
INSERT [dbo].[Order] ([id], [customer_id], [table_id], [staff_id], [comments], [delivery_id]) VALUES (1017, NULL, 2, 10, NULL, NULL)
INSERT [dbo].[Order] ([id], [customer_id], [table_id], [staff_id], [comments], [delivery_id]) VALUES (1018, 6, NULL, NULL, NULL, 1)
INSERT [dbo].[Order] ([id], [customer_id], [table_id], [staff_id], [comments], [delivery_id]) VALUES (1019, 6, NULL, NULL, NULL, 1)
INSERT [dbo].[Order] ([id], [customer_id], [table_id], [staff_id], [comments], [delivery_id]) VALUES (1020, 6, NULL, NULL, NULL, 1)
INSERT [dbo].[Order] ([id], [customer_id], [table_id], [staff_id], [comments], [delivery_id]) VALUES (1021, 6, NULL, NULL, NULL, 1)
INSERT [dbo].[Order] ([id], [customer_id], [table_id], [staff_id], [comments], [delivery_id]) VALUES (1022, 6, NULL, NULL, NULL, 1)
INSERT [dbo].[Order] ([id], [customer_id], [table_id], [staff_id], [comments], [delivery_id]) VALUES (1023, 6, NULL, NULL, NULL, 1)
INSERT [dbo].[Order] ([id], [customer_id], [table_id], [staff_id], [comments], [delivery_id]) VALUES (1024, 6, NULL, NULL, NULL, 1)
INSERT [dbo].[Order] ([id], [customer_id], [table_id], [staff_id], [comments], [delivery_id]) VALUES (1025, 6, NULL, NULL, NULL, 1)
INSERT [dbo].[Order] ([id], [customer_id], [table_id], [staff_id], [comments], [delivery_id]) VALUES (1026, 6, NULL, NULL, NULL, 1)
INSERT [dbo].[Order] ([id], [customer_id], [table_id], [staff_id], [comments], [delivery_id]) VALUES (1027, 6, NULL, NULL, NULL, 1)
INSERT [dbo].[Order] ([id], [customer_id], [table_id], [staff_id], [comments], [delivery_id]) VALUES (1028, 6, NULL, NULL, NULL, 1)
INSERT [dbo].[Order] ([id], [customer_id], [table_id], [staff_id], [comments], [delivery_id]) VALUES (1029, 6, NULL, NULL, NULL, 1)
SET IDENTITY_INSERT [dbo].[Order] OFF
SET IDENTITY_INSERT [dbo].[Order_Items] ON 

INSERT [dbo].[Order_Items] ([order_item_id], [order_id], [menu_id], [price], [quantity]) VALUES (1007, 1015, 2, 700, 1)
INSERT [dbo].[Order_Items] ([order_item_id], [order_id], [menu_id], [price], [quantity]) VALUES (1008, 1016, 2, 700, 2)
INSERT [dbo].[Order_Items] ([order_item_id], [order_id], [menu_id], [price], [quantity]) VALUES (1009, 1017, 1003, 2000, 2)
INSERT [dbo].[Order_Items] ([order_item_id], [order_id], [menu_id], [price], [quantity]) VALUES (1010, 1017, 1004, 1700, 3)
INSERT [dbo].[Order_Items] ([order_item_id], [order_id], [menu_id], [price], [quantity]) VALUES (1011, 1018, 1003, 2000, 4)
INSERT [dbo].[Order_Items] ([order_item_id], [order_id], [menu_id], [price], [quantity]) VALUES (1012, 1018, 1004, 1700, 1)
INSERT [dbo].[Order_Items] ([order_item_id], [order_id], [menu_id], [price], [quantity]) VALUES (1013, 1019, 1003, 2000, 4)
INSERT [dbo].[Order_Items] ([order_item_id], [order_id], [menu_id], [price], [quantity]) VALUES (1014, 1019, 1004, 1700, 1)
INSERT [dbo].[Order_Items] ([order_item_id], [order_id], [menu_id], [price], [quantity]) VALUES (1015, 1019, 1005, 1600, 3)
INSERT [dbo].[Order_Items] ([order_item_id], [order_id], [menu_id], [price], [quantity]) VALUES (1016, 1020, 1003, 2000, 6)
INSERT [dbo].[Order_Items] ([order_item_id], [order_id], [menu_id], [price], [quantity]) VALUES (1017, 1021, 1003, 2000, 6)
INSERT [dbo].[Order_Items] ([order_item_id], [order_id], [menu_id], [price], [quantity]) VALUES (1018, 1021, 1005, 1600, 1)
INSERT [dbo].[Order_Items] ([order_item_id], [order_id], [menu_id], [price], [quantity]) VALUES (1019, 1022, 1004, 1700, 2)
INSERT [dbo].[Order_Items] ([order_item_id], [order_id], [menu_id], [price], [quantity]) VALUES (1020, 1023, 1004, 1700, 2)
INSERT [dbo].[Order_Items] ([order_item_id], [order_id], [menu_id], [price], [quantity]) VALUES (1021, 1023, 1005, 1600, 1)
INSERT [dbo].[Order_Items] ([order_item_id], [order_id], [menu_id], [price], [quantity]) VALUES (1022, 1024, 1005, 1600, 1)
INSERT [dbo].[Order_Items] ([order_item_id], [order_id], [menu_id], [price], [quantity]) VALUES (1023, 1025, 1004, 1700, 2)
INSERT [dbo].[Order_Items] ([order_item_id], [order_id], [menu_id], [price], [quantity]) VALUES (1024, 1026, 1004, 1700, 2)
INSERT [dbo].[Order_Items] ([order_item_id], [order_id], [menu_id], [price], [quantity]) VALUES (1025, 1026, 1005, 1600, 2)
INSERT [dbo].[Order_Items] ([order_item_id], [order_id], [menu_id], [price], [quantity]) VALUES (1026, 1026, 1004, 1700, 2)
INSERT [dbo].[Order_Items] ([order_item_id], [order_id], [menu_id], [price], [quantity]) VALUES (1027, 1026, 1003, 2000, 3)
INSERT [dbo].[Order_Items] ([order_item_id], [order_id], [menu_id], [price], [quantity]) VALUES (1028, 1027, 1003, 2000, 1)
INSERT [dbo].[Order_Items] ([order_item_id], [order_id], [menu_id], [price], [quantity]) VALUES (1029, 1028, 1004, 1700, 1)
INSERT [dbo].[Order_Items] ([order_item_id], [order_id], [menu_id], [price], [quantity]) VALUES (1030, 1029, 1004, 1700, 1)
INSERT [dbo].[Order_Items] ([order_item_id], [order_id], [menu_id], [price], [quantity]) VALUES (1031, 1029, 1005, 1600, 5)
SET IDENTITY_INSERT [dbo].[Order_Items] OFF
SET IDENTITY_INSERT [dbo].[Reservation_Table] ON 

INSERT [dbo].[Reservation_Table] ([id], [table_id], [customer_id], [reservation_date], [status]) VALUES (1, 2, 6, CAST(N'2023-04-27T21:08:17.887' AS DateTime), 1)
INSERT [dbo].[Reservation_Table] ([id], [table_id], [customer_id], [reservation_date], [status]) VALUES (2, 3, 6, CAST(N'2023-05-03T12:22:31.963' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[Reservation_Table] OFF
SET IDENTITY_INSERT [dbo].[Seating_Table] ON 

INSERT [dbo].[Seating_Table] ([id], [table_no], [floor]) VALUES (2, 2, 1)
INSERT [dbo].[Seating_Table] ([id], [table_no], [floor]) VALUES (3, 1, 2)
INSERT [dbo].[Seating_Table] ([id], [table_no], [floor]) VALUES (4, 2, 2)
INSERT [dbo].[Seating_Table] ([id], [table_no], [floor]) VALUES (5, 3, 2)
INSERT [dbo].[Seating_Table] ([id], [table_no], [floor]) VALUES (7, 3, 1)
INSERT [dbo].[Seating_Table] ([id], [table_no], [floor]) VALUES (8, 1, 3)
SET IDENTITY_INSERT [dbo].[Seating_Table] OFF
INSERT [dbo].[Staff] ([id], [phone], [address], [hiredate], [salary]) VALUES (7, N'0321', N'uet lahore', CAST(N'2023-04-19T00:00:00.000' AS DateTime), CAST(100000 AS Decimal(18, 0)))
INSERT [dbo].[Staff] ([id], [phone], [address], [hiredate], [salary]) VALUES (9, N'0321', N'Alipur road lahore', CAST(N'2023-04-24T19:02:42.310' AS DateTime), CAST(20000 AS Decimal(18, 0)))
INSERT [dbo].[Staff] ([id], [phone], [address], [hiredate], [salary]) VALUES (10, N'0333', N'shalamar uet', CAST(N'2023-04-21T15:50:21.000' AS DateTime), CAST(40000 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [password], [usertype], [first_name], [last_name], [email], [gender]) VALUES (6, N'123', 1, N'iqra', N'rafiq', N'iqra@gmail.com', 6)
INSERT [dbo].[Users] ([Id], [password], [usertype], [first_name], [last_name], [email], [gender]) VALUES (7, N'456', 4, N'iqra', N'rafiq', N'iqrarafiq@gmail.com', 6)
INSERT [dbo].[Users] ([Id], [password], [usertype], [first_name], [last_name], [email], [gender]) VALUES (9, N'123', 3, N'eman', N'zubair', N'eman@gmail.com', 6)
INSERT [dbo].[Users] ([Id], [password], [usertype], [first_name], [last_name], [email], [gender]) VALUES (10, N'123', 2, N'samia', N'ali', N'samia@gmail.com', 6)
SET IDENTITY_INSERT [dbo].[Users] OFF
ALTER TABLE [dbo].[AssignedTask]  WITH CHECK ADD FOREIGN KEY([delivery_id])
REFERENCES [dbo].[DeliveryDetails] ([id])
GO
ALTER TABLE [dbo].[AssignedTask]  WITH CHECK ADD FOREIGN KEY([staff_id])
REFERENCES [dbo].[Staff] ([id])
GO
ALTER TABLE [dbo].[AssignedTask]  WITH CHECK ADD FOREIGN KEY([table_id])
REFERENCES [dbo].[Seating_Table] ([id])
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD FOREIGN KEY([order_id])
REFERENCES [dbo].[Order] ([id])
GO
ALTER TABLE [dbo].[Customer]  WITH CHECK ADD FOREIGN KEY([id])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[DeliveryDetails]  WITH CHECK ADD FOREIGN KEY([customer_id])
REFERENCES [dbo].[Customer] ([id])
GO
ALTER TABLE [dbo].[Menu]  WITH CHECK ADD FOREIGN KEY([category_id])
REFERENCES [dbo].[Menu_Category] ([id])
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD FOREIGN KEY([delivery_id])
REFERENCES [dbo].[DeliveryDetails] ([id])
GO
ALTER TABLE [dbo].[Order_Items]  WITH CHECK ADD FOREIGN KEY([order_id])
REFERENCES [dbo].[Order] ([id])
GO
ALTER TABLE [dbo].[Reservation_Table]  WITH CHECK ADD FOREIGN KEY([customer_id])
REFERENCES [dbo].[Customer] ([id])
GO
ALTER TABLE [dbo].[Reservation_Table]  WITH CHECK ADD FOREIGN KEY([status])
REFERENCES [dbo].[Lookup] ([Id])
GO
ALTER TABLE [dbo].[Reservation_Table]  WITH CHECK ADD FOREIGN KEY([table_id])
REFERENCES [dbo].[Seating_Table] ([id])
GO
ALTER TABLE [dbo].[Staff]  WITH CHECK ADD FOREIGN KEY([id])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD FOREIGN KEY([gender])
REFERENCES [dbo].[Lookup] ([Id])
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD FOREIGN KEY([usertype])
REFERENCES [dbo].[Lookup] ([Id])
GO
USE [master]
GO
ALTER DATABASE [ResturentSystem] SET  READ_WRITE 
GO
