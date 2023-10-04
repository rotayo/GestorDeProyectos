GO

/****** Object:  Database [BaseDeDatos_JFK]    Script Date: 17/8/2023 01:59:25 ******/
CREATE DATABASE [BaseDeDatos_JFK]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BaseDeDatos_JFK', FILENAME = N'D:\Programacion\PRACTICAS\sql scripts\BaseDeDatos_JFK.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BaseDeDatos_JFK_log', FILENAME = N'D:\Programacion\PRACTICAS\sql scripts\BaseDeDatos_JFK_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BaseDeDatos_JFK].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [BaseDeDatos_JFK] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [BaseDeDatos_JFK] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [BaseDeDatos_JFK] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [BaseDeDatos_JFK] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [BaseDeDatos_JFK] SET ARITHABORT OFF 
GO

ALTER DATABASE [BaseDeDatos_JFK] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [BaseDeDatos_JFK] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [BaseDeDatos_JFK] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [BaseDeDatos_JFK] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [BaseDeDatos_JFK] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [BaseDeDatos_JFK] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [BaseDeDatos_JFK] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [BaseDeDatos_JFK] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [BaseDeDatos_JFK] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [BaseDeDatos_JFK] SET  DISABLE_BROKER 
GO

ALTER DATABASE [BaseDeDatos_JFK] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [BaseDeDatos_JFK] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [BaseDeDatos_JFK] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [BaseDeDatos_JFK] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [BaseDeDatos_JFK] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [BaseDeDatos_JFK] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [BaseDeDatos_JFK] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [BaseDeDatos_JFK] SET RECOVERY FULL 
GO

ALTER DATABASE [BaseDeDatos_JFK] SET  MULTI_USER 
GO

ALTER DATABASE [BaseDeDatos_JFK] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [BaseDeDatos_JFK] SET DB_CHAINING OFF 
GO

ALTER DATABASE [BaseDeDatos_JFK] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [BaseDeDatos_JFK] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [BaseDeDatos_JFK] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [BaseDeDatos_JFK] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [BaseDeDatos_JFK] SET QUERY_STORE = ON
GO

ALTER DATABASE [BaseDeDatos_JFK] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO

ALTER DATABASE [BaseDeDatos_JFK] SET  READ_WRITE 
GO

USE [BaseDeDatos_JFK]
GO

/****** Object:  Table [dbo].[Clientes]    Script Date: 17/8/2023 02:00:01 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Clientes](
	[id] [int] NOT NULL,
	[nombre_completo] [nchar](50) NOT NULL,
	[correo_electrónico] [nchar](30) NOT NULL,
	[teléfono] [nchar](8) NOT NULL,
	[dirección] [nchar](100) NOT NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Facturación](
	[id] [int] NOT NULL,
	[id_cliente] [int] NOT NULL,
	[id_proyecto] [int] NOT NULL,
	[fecha_actual] [date] NOT NULL,
	[total] [int] NOT NULL,
 CONSTRAINT [PK_Facturación] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Facturación]  WITH CHECK ADD  CONSTRAINT [FK_Facturación_Clientes] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[Clientes] ([id])
GO

ALTER TABLE [dbo].[Facturación] CHECK CONSTRAINT [FK_Facturación_Clientes]
GO

ALTER TABLE [dbo].[Facturación]  WITH CHECK ADD  CONSTRAINT [FK_Facturación_Proyectos] FOREIGN KEY([id_proyecto])
REFERENCES [dbo].[Proyectos] ([id])
GO

ALTER TABLE [dbo].[Facturación] CHECK CONSTRAINT [FK_Facturación_Proyectos]
GO

CREATE TABLE [dbo].[Fechas](
	[id] [int] NOT NULL,
	[id_proyecto] [int] NOT NULL,
	[fecha_inicio] [date] NULL,
	[fecha_de_entrega] [date] NULL,
 CONSTRAINT [PK_Fechas] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Fechas]  WITH CHECK ADD  CONSTRAINT [FK_Fechas_Proyectos] FOREIGN KEY([id_proyecto])
REFERENCES [dbo].[Proyectos] ([id])
GO

ALTER TABLE [dbo].[Fechas] CHECK CONSTRAINT [FK_Fechas_Proyectos]
GO

CREATE TABLE [dbo].[Inventario](
	[id] [int] NOT NULL,
	[nombre_del_producto] [nchar](50) NOT NULL,
	[precio] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[detalle] [nchar](100) NOT NULL,
 CONSTRAINT [PK_Inventario] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[MaterialesProyectos](
	[id_proyecto] [int] NOT NULL,
	[id_producto] [int] NOT NULL,
	[nombre_producto] [nchar](30) NOT NULL,
	[cantidad] [int] NOT NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[MaterialesProyectos]  WITH CHECK ADD  CONSTRAINT [FK_MaterialesProyecto_Inventario] FOREIGN KEY([id_producto])
REFERENCES [dbo].[Inventario] ([id])
GO

ALTER TABLE [dbo].[MaterialesProyectos] CHECK CONSTRAINT [FK_MaterialesProyecto_Inventario]
GO

ALTER TABLE [dbo].[MaterialesProyectos]  WITH CHECK ADD  CONSTRAINT [FK_MaterialesProyectos_Proyectos] FOREIGN KEY([id_proyecto])
REFERENCES [dbo].[Proyectos] ([id])
GO

ALTER TABLE [dbo].[MaterialesProyectos] CHECK CONSTRAINT [FK_MaterialesProyectos_Proyectos]
GO

CREATE TABLE [dbo].[Proyectos](
	[id] [int] NOT NULL,
	[id_cliente] [int] NOT NULL,
	[costo_de_material] [int] NOT NULL,
	[mano_de_obra] [int] NOT NULL,
	[detalle] [nchar](100) NOT NULL,
	[encargado] [nchar](30) NOT NULL,
	[estado] [nchar](10) NULL,
 CONSTRAINT [PK_Proyectos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Proyectos]  WITH CHECK ADD  CONSTRAINT [FK_Proyectos_Clientes] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[Clientes] ([id])
GO

ALTER TABLE [dbo].[Proyectos] CHECK CONSTRAINT [FK_Proyectos_Clientes]
GO