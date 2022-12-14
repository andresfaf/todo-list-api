USE [master]
GO
/****** Object:  Database [LISTA_TAREAS]    Script Date: 7/08/2022 11:17:17 p. m. ******/
CREATE DATABASE [LISTA_TAREAS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TODO_LIST', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\TODO_LIST.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TODO_LIST_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\TODO_LIST_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [LISTA_TAREAS] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LISTA_TAREAS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LISTA_TAREAS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LISTA_TAREAS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LISTA_TAREAS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LISTA_TAREAS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LISTA_TAREAS] SET ARITHABORT OFF 
GO
ALTER DATABASE [LISTA_TAREAS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [LISTA_TAREAS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LISTA_TAREAS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LISTA_TAREAS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LISTA_TAREAS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LISTA_TAREAS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LISTA_TAREAS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LISTA_TAREAS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LISTA_TAREAS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LISTA_TAREAS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [LISTA_TAREAS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LISTA_TAREAS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LISTA_TAREAS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LISTA_TAREAS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LISTA_TAREAS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LISTA_TAREAS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LISTA_TAREAS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LISTA_TAREAS] SET RECOVERY FULL 
GO
ALTER DATABASE [LISTA_TAREAS] SET  MULTI_USER 
GO
ALTER DATABASE [LISTA_TAREAS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LISTA_TAREAS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LISTA_TAREAS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LISTA_TAREAS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [LISTA_TAREAS] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [LISTA_TAREAS] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'LISTA_TAREAS', N'ON'
GO
ALTER DATABASE [LISTA_TAREAS] SET QUERY_STORE = OFF
GO
USE [LISTA_TAREAS]
GO
/****** Object:  Table [dbo].[TAREA]    Script Date: 7/08/2022 11:17:17 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAREA](
	[ID_TAREA] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[DESCRIPCION] [nvarchar](150) NULL,
	[FECHA_CREACION] [datetime] NULL,
	[ESTADO] [bit] NULL,
 CONSTRAINT [PK_TAREA] PRIMARY KEY CLUSTERED 
(
	[ID_TAREA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [LISTA_TAREAS] SET  READ_WRITE 
GO
