USE [master]
GO
/****** Object:  Database [Literatura]    Script Date: 01/04/2016 11:56:47 p.m. ******/
CREATE DATABASE [Literatura]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Literatura', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Literatura.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Literatura_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Literatura_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Literatura] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Literatura].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Literatura] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Literatura] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Literatura] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Literatura] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Literatura] SET ARITHABORT OFF 
GO
ALTER DATABASE [Literatura] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Literatura] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Literatura] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Literatura] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Literatura] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Literatura] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Literatura] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Literatura] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Literatura] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Literatura] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Literatura] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Literatura] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Literatura] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Literatura] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Literatura] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Literatura] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Literatura] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Literatura] SET RECOVERY FULL 
GO
ALTER DATABASE [Literatura] SET  MULTI_USER 
GO
ALTER DATABASE [Literatura] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Literatura] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Literatura] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Literatura] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Literatura] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Literatura', N'ON'
GO
USE [Literatura]
GO
/****** Object:  Table [dbo].[Autores]    Script Date: 01/04/2016 11:56:47 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Autores](
	[idAutor] [int] IDENTITY(1,1) NOT NULL,
	[nombreApellido] [varchar](50) NULL,
 CONSTRAINT [PK_Autores] PRIMARY KEY CLUSTERED 
(
	[idAutor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Frases]    Script Date: 01/04/2016 11:56:47 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Frases](
	[idFrase] [int] IDENTITY(1,1) NOT NULL,
	[texto] [varchar](100) NULL,
	[idLibro] [int] NULL,
 CONSTRAINT [PK_Frases] PRIMARY KEY CLUSTERED 
(
	[idFrase] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Libros]    Script Date: 01/04/2016 11:56:47 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Libros](
	[idLibro] [int] IDENTITY(1,1) NOT NULL,
	[titulo] [varchar](100) NULL,
	[idAutor] [int] NULL,
 CONSTRAINT [PK_Libros] PRIMARY KEY CLUSTERED 
(
	[idLibro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Autores] ON 

INSERT [dbo].[Autores] ([idAutor], [nombreApellido]) VALUES (1, N'Facundo Alvarez')
INSERT [dbo].[Autores] ([idAutor], [nombreApellido]) VALUES (2, N'Florencia Alvarez')
INSERT [dbo].[Autores] ([idAutor], [nombreApellido]) VALUES (3, N'Raul Elfidio')
INSERT [dbo].[Autores] ([idAutor], [nombreApellido]) VALUES (4, N'Zulema Ricardi')
INSERT [dbo].[Autores] ([idAutor], [nombreApellido]) VALUES (5, N'Martin Guereta')
INSERT [dbo].[Autores] ([idAutor], [nombreApellido]) VALUES (1002, N'Nicolas Giordano')
INSERT [dbo].[Autores] ([idAutor], [nombreApellido]) VALUES (1003, N'Leonardo Peretti')
INSERT [dbo].[Autores] ([idAutor], [nombreApellido]) VALUES (1004, N'Tu vieja')
SET IDENTITY_INSERT [dbo].[Autores] OFF
SET IDENTITY_INSERT [dbo].[Frases] ON 

INSERT [dbo].[Frases] ([idFrase], [texto], [idLibro]) VALUES (3, N'Hola como va', 2)
INSERT [dbo].[Frases] ([idFrase], [texto], [idLibro]) VALUES (4, N'Hello its me', 3)
INSERT [dbo].[Frases] ([idFrase], [texto], [idLibro]) VALUES (5, N'Todo bien vos', 2)
INSERT [dbo].[Frases] ([idFrase], [texto], [idLibro]) VALUES (6, N'Todo tranqui', 5)
INSERT [dbo].[Frases] ([idFrase], [texto], [idLibro]) VALUES (7, N'Probando UPDATE', 5)
SET IDENTITY_INSERT [dbo].[Frases] OFF
SET IDENTITY_INSERT [dbo].[Libros] ON 

INSERT [dbo].[Libros] ([idLibro], [titulo], [idAutor]) VALUES (2, N'Prueba 1', 1)
INSERT [dbo].[Libros] ([idLibro], [titulo], [idAutor]) VALUES (3, N'Prueba2', 1)
INSERT [dbo].[Libros] ([idLibro], [titulo], [idAutor]) VALUES (4, N'Prueba3', 4)
INSERT [dbo].[Libros] ([idLibro], [titulo], [idAutor]) VALUES (5, N'Prueba4', 2)
INSERT [dbo].[Libros] ([idLibro], [titulo], [idAutor]) VALUES (7, N'Prueba5', 5)
SET IDENTITY_INSERT [dbo].[Libros] OFF
ALTER TABLE [dbo].[Frases]  WITH CHECK ADD  CONSTRAINT [FK_Frases_Libros] FOREIGN KEY([idLibro])
REFERENCES [dbo].[Libros] ([idLibro])
GO
ALTER TABLE [dbo].[Frases] CHECK CONSTRAINT [FK_Frases_Libros]
GO
ALTER TABLE [dbo].[Libros]  WITH CHECK ADD  CONSTRAINT [FK_Libros_Autores] FOREIGN KEY([idAutor])
REFERENCES [dbo].[Autores] ([idAutor])
GO
ALTER TABLE [dbo].[Libros] CHECK CONSTRAINT [FK_Libros_Autores]
GO
USE [master]
GO
ALTER DATABASE [Literatura] SET  READ_WRITE 
GO
