USE [master]
GO

/****** Object:  Database [ShowCase]    Script Date: 05/21/2010 13:20:17 ******/
CREATE DATABASE [ShowCase] ON  PRIMARY 
( NAME = N'ShowCase', FILENAME = N'C:\Programmer\Microsoft SQL Server\MSSQL10.MSSQLSERVER\MSSQL\DATA\ShowCase.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ShowCase_log', FILENAME = N'C:\Programmer\Microsoft SQL Server\MSSQL10.MSSQLSERVER\MSSQL\DATA\ShowCase_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [ShowCase] SET COMPATIBILITY_LEVEL = 100
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ShowCase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [ShowCase] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [ShowCase] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [ShowCase] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [ShowCase] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [ShowCase] SET ARITHABORT OFF 
GO

ALTER DATABASE [ShowCase] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [ShowCase] SET AUTO_CREATE_STATISTICS ON 
GO

ALTER DATABASE [ShowCase] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [ShowCase] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [ShowCase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [ShowCase] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [ShowCase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [ShowCase] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [ShowCase] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [ShowCase] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [ShowCase] SET  DISABLE_BROKER 
GO

ALTER DATABASE [ShowCase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [ShowCase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [ShowCase] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [ShowCase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [ShowCase] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [ShowCase] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [ShowCase] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [ShowCase] SET  READ_WRITE 
GO

ALTER DATABASE [ShowCase] SET RECOVERY FULL 
GO

ALTER DATABASE [ShowCase] SET  MULTI_USER 
GO

ALTER DATABASE [ShowCase] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [ShowCase] SET DB_CHAINING OFF 
GO

