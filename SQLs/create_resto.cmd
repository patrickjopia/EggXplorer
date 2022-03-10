USE [master]
GO

/****** Object:  Database [eggX_resto]    Script Date: 3/4/2022 5:24:30 AM ******/
CREATE DATABASE [eggX_resto]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'eggX_resto', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\eggX_resto.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'eggX_resto_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\eggX_resto_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [eggX_resto].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [eggX_resto] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [eggX_resto] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [eggX_resto] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [eggX_resto] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [eggX_resto] SET ARITHABORT OFF 
GO

ALTER DATABASE [eggX_resto] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [eggX_resto] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [eggX_resto] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [eggX_resto] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [eggX_resto] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [eggX_resto] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [eggX_resto] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [eggX_resto] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [eggX_resto] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [eggX_resto] SET  DISABLE_BROKER 
GO

ALTER DATABASE [eggX_resto] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [eggX_resto] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [eggX_resto] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [eggX_resto] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [eggX_resto] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [eggX_resto] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [eggX_resto] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [eggX_resto] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [eggX_resto] SET  MULTI_USER 
GO

ALTER DATABASE [eggX_resto] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [eggX_resto] SET DB_CHAINING OFF 
GO

ALTER DATABASE [eggX_resto] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [eggX_resto] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [eggX_resto] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [eggX_resto] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [eggX_resto] SET QUERY_STORE = OFF
GO

ALTER DATABASE [eggX_resto] SET  READ_WRITE 
GO


