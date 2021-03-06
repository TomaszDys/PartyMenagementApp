USE [master]
GO
/****** Object:  Database [WorkHelper]    Script Date: 2018-04-24 11:41:28 ******/
CREATE DATABASE [WorkHelper]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'WorkHelper', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.LOL\MSSQL\DATA\WorkHelper.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'WorkHelper_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.LOL\MSSQL\DATA\WorkHelper_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [WorkHelper] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [WorkHelper].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [WorkHelper] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [WorkHelper] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [WorkHelper] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [WorkHelper] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [WorkHelper] SET ARITHABORT OFF 
GO
ALTER DATABASE [WorkHelper] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [WorkHelper] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [WorkHelper] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [WorkHelper] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [WorkHelper] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [WorkHelper] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [WorkHelper] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [WorkHelper] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [WorkHelper] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [WorkHelper] SET  DISABLE_BROKER 
GO
ALTER DATABASE [WorkHelper] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [WorkHelper] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [WorkHelper] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [WorkHelper] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [WorkHelper] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [WorkHelper] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [WorkHelper] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [WorkHelper] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [WorkHelper] SET  MULTI_USER 
GO
ALTER DATABASE [WorkHelper] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [WorkHelper] SET DB_CHAINING OFF 
GO
ALTER DATABASE [WorkHelper] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [WorkHelper] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [WorkHelper] SET DELAYED_DURABILITY = DISABLED 
GO
USE [WorkHelper]
GO
/****** Object:  Table [dbo].[Bills]    Script Date: 2018-04-24 11:41:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bills](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[BillNumber] [int] NOT NULL,
 CONSTRAINT [PK_Bills] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CloakGuest]    Script Date: 2018-04-24 11:41:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CloakGuest](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CloakId] [int] NOT NULL,
	[GuestId] [int] NOT NULL,
 CONSTRAINT [PK_CloakGuest] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Cloaks]    Script Date: 2018-04-24 11:41:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cloaks](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Number] [int] NOT NULL,
 CONSTRAINT [PK_Cloakroom] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Guests]    Script Date: 2018-04-24 11:41:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Guests](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](31) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Guests] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GuestTable]    Script Date: 2018-04-24 11:41:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GuestTable](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[GuestId] [int] NOT NULL,
	[TableId] [int] NOT NULL,
 CONSTRAINT [PK_GuestTable] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Menu]    Script Date: 2018-04-24 11:41:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Menu](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](31) NOT NULL,
	[Prize] [smallmoney] NOT NULL,
	[Image] [image] NULL,
	[Amount] [text] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Music]    Script Date: 2018-04-24 11:41:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Music](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](31) NOT NULL,
	[LinkURL] [text] NULL,
 CONSTRAINT [PK_Music] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Orders]    Script Date: 2018-04-24 11:41:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[BillId] [int] NOT NULL,
	[MenuItemId] [int] NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tabels]    Script Date: 2018-04-24 11:41:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tabels](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NumberOfPlaces] [int] NOT NULL,
	[SittingPlaces] [bit] NOT NULL,
 CONSTRAINT [PK_Tabels] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[GuestsWithCloaksNumbers]    Script Date: 2018-04-24 11:41:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[GuestsWithCloaksNumbers] AS
SELECT Cloaks.Id AS CloakId, Guests.Id AS GuestID, CloakGuest.Id AS ConnectionID, Cloaks.Number AS Numerek,Guests.Name AS Imię,Guests.Surname AS Nazwisko FROM CloakGuest
JOIN Cloaks ON Cloaks.Id = CloakGuest.CloakId 
RIGHT JOIN Guests ON Guests.Id = CloakGuest.GuestId 
GO
/****** Object:  View [dbo].[GuestsWithTables]    Script Date: 2018-04-24 11:41:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[GuestsWithTables] AS
SELECT Guests.Id AS GuestId, GuestTable.Id AS ConnectionID, Tabels.Id AS NumerStolika,Guests.Name AS Imię,Guests.Surname AS Nazwisko FROM GuestTable
JOIN Tabels ON Tabels.Id = GuestTable.TableId 
RIGHT JOIN Guests ON Guests.Id = GuestTable.GuestId
GO
/****** Object:  View [dbo].[OrdersWithProducts]    Script Date: 2018-04-24 11:41:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[OrdersWithProducts] AS
SELECT Menu.Id AS MenuId, Bills.Id AS BillId, Orders.Id AS ConnectionID, Bills.BillNumber AS NumerRachunku, Menu.Name AS NazwaProduktu FROM Orders
JOIN Bills ON Bills.Id = Orders.BillId 
JOIN Menu ON Menu.Id = Orders.MenuItemId 
GO
SET IDENTITY_INSERT [dbo].[Bills] ON 

INSERT [dbo].[Bills] ([Id], [BillNumber]) VALUES (1, 2232)
INSERT [dbo].[Bills] ([Id], [BillNumber]) VALUES (2, 2233)
INSERT [dbo].[Bills] ([Id], [BillNumber]) VALUES (3, 2234)
INSERT [dbo].[Bills] ([Id], [BillNumber]) VALUES (5, 2251)
SET IDENTITY_INSERT [dbo].[Bills] OFF
SET IDENTITY_INSERT [dbo].[CloakGuest] ON 

INSERT [dbo].[CloakGuest] ([Id], [CloakId], [GuestId]) VALUES (14, 10, 1)
INSERT [dbo].[CloakGuest] ([Id], [CloakId], [GuestId]) VALUES (15, 10, 1)
INSERT [dbo].[CloakGuest] ([Id], [CloakId], [GuestId]) VALUES (16, 10, 2)
INSERT [dbo].[CloakGuest] ([Id], [CloakId], [GuestId]) VALUES (17, 10, 3)
INSERT [dbo].[CloakGuest] ([Id], [CloakId], [GuestId]) VALUES (20, 3, 2)
INSERT [dbo].[CloakGuest] ([Id], [CloakId], [GuestId]) VALUES (26, 1, 3)
INSERT [dbo].[CloakGuest] ([Id], [CloakId], [GuestId]) VALUES (27, 3, 1)
SET IDENTITY_INSERT [dbo].[CloakGuest] OFF
SET IDENTITY_INSERT [dbo].[Cloaks] ON 

INSERT [dbo].[Cloaks] ([Id], [Number]) VALUES (1, 1)
INSERT [dbo].[Cloaks] ([Id], [Number]) VALUES (2, 2)
INSERT [dbo].[Cloaks] ([Id], [Number]) VALUES (3, 3)
INSERT [dbo].[Cloaks] ([Id], [Number]) VALUES (4, 4)
INSERT [dbo].[Cloaks] ([Id], [Number]) VALUES (5, 5)
INSERT [dbo].[Cloaks] ([Id], [Number]) VALUES (6, 6)
INSERT [dbo].[Cloaks] ([Id], [Number]) VALUES (7, 10)
SET IDENTITY_INSERT [dbo].[Cloaks] OFF
SET IDENTITY_INSERT [dbo].[Guests] ON 

INSERT [dbo].[Guests] ([Id], [Name], [Surname]) VALUES (1, N'Adam', N'Adamowicz')
INSERT [dbo].[Guests] ([Id], [Name], [Surname]) VALUES (2, N'Jan', N'Jurkowski')
INSERT [dbo].[Guests] ([Id], [Name], [Surname]) VALUES (3, N'Wojciech', N'Wojciechowski')
INSERT [dbo].[Guests] ([Id], [Name], [Surname]) VALUES (4, N'Tomasz', N'Tomaszowski')
SET IDENTITY_INSERT [dbo].[Guests] OFF
SET IDENTITY_INSERT [dbo].[GuestTable] ON 

INSERT [dbo].[GuestTable] ([Id], [GuestId], [TableId]) VALUES (6, 4, 1)
INSERT [dbo].[GuestTable] ([Id], [GuestId], [TableId]) VALUES (7, 4, 1)
INSERT [dbo].[GuestTable] ([Id], [GuestId], [TableId]) VALUES (8, 1, 5)
INSERT [dbo].[GuestTable] ([Id], [GuestId], [TableId]) VALUES (9, 1, 1)
INSERT [dbo].[GuestTable] ([Id], [GuestId], [TableId]) VALUES (13, 3, 3)
INSERT [dbo].[GuestTable] ([Id], [GuestId], [TableId]) VALUES (19, 2, 2)
INSERT [dbo].[GuestTable] ([Id], [GuestId], [TableId]) VALUES (26, 4, 3)
INSERT [dbo].[GuestTable] ([Id], [GuestId], [TableId]) VALUES (28, 1, 2)
SET IDENTITY_INSERT [dbo].[GuestTable] OFF
SET IDENTITY_INSERT [dbo].[Menu] ON 

INSERT [dbo].[Menu] ([Id], [Name], [Prize], [Image], [Amount]) VALUES (1, N'Coca-Cola', 5.9900, NULL, N'500ml')
INSERT [dbo].[Menu] ([Id], [Name], [Prize], [Image], [Amount]) VALUES (5, N'Przeźroczysty napój', 100.0000, NULL, N'700ml')
INSERT [dbo].[Menu] ([Id], [Name], [Prize], [Image], [Amount]) VALUES (7, N'Złotawy napój z Colą', 15.0000, NULL, N'100ml')
INSERT [dbo].[Menu] ([Id], [Name], [Prize], [Image], [Amount]) VALUES (8, N'Złotawy napój 2', 8.0000, NULL, N'500ml')
INSERT [dbo].[Menu] ([Id], [Name], [Prize], [Image], [Amount]) VALUES (9, N'Chipsy', 5.0000, NULL, N'100g')
INSERT [dbo].[Menu] ([Id], [Name], [Prize], [Image], [Amount]) VALUES (10, N'Sprite', 10.0000, NULL, N'1litr')
SET IDENTITY_INSERT [dbo].[Menu] OFF
SET IDENTITY_INSERT [dbo].[Music] ON 

INSERT [dbo].[Music] ([Id], [Name], [LinkURL]) VALUES (1, N'Mayores', N'https://www.youtube.com/watch?v=GMFewiplIbw')
INSERT [dbo].[Music] ([Id], [Name], [LinkURL]) VALUES (2, N'Miłość w Zakopanem', N'https://www.youtube.com/watch?v=n2hJA78YuWw')
INSERT [dbo].[Music] ([Id], [Name], [LinkURL]) VALUES (5, N'Despacito', N'https://www.youtube.com/watch?v=kJQP7kiw5Fk')
INSERT [dbo].[Music] ([Id], [Name], [LinkURL]) VALUES (6, N'Why Can''t We be Friends', N'https://www.youtube.com/watch?v=5DmYLrxR0Y8&list=RD5DmYLrxR0Y8')
INSERT [dbo].[Music] ([Id], [Name], [LinkURL]) VALUES (9, N'Jammin', N'https://www.youtube.com/watch?v=7Jz6d04Hc60')
SET IDENTITY_INSERT [dbo].[Music] OFF
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([Id], [BillId], [MenuItemId]) VALUES (1, 1, 1)
INSERT [dbo].[Orders] ([Id], [BillId], [MenuItemId]) VALUES (4, 2, 7)
INSERT [dbo].[Orders] ([Id], [BillId], [MenuItemId]) VALUES (7, 3, 9)
INSERT [dbo].[Orders] ([Id], [BillId], [MenuItemId]) VALUES (8, 1, 1)
SET IDENTITY_INSERT [dbo].[Orders] OFF
SET IDENTITY_INSERT [dbo].[Tabels] ON 

INSERT [dbo].[Tabels] ([Id], [NumberOfPlaces], [SittingPlaces]) VALUES (2, 6, 1)
INSERT [dbo].[Tabels] ([Id], [NumberOfPlaces], [SittingPlaces]) VALUES (3, 10, 0)
INSERT [dbo].[Tabels] ([Id], [NumberOfPlaces], [SittingPlaces]) VALUES (4, 5, 1)
SET IDENTITY_INSERT [dbo].[Tabels] OFF
USE [master]
GO
ALTER DATABASE [WorkHelper] SET  READ_WRITE 
GO
