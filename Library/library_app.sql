ALTER DATABASE [library_app] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [library_app].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [library_app] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [library_app] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [library_app] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [library_app] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [library_app] SET ARITHABORT OFF 
GO
ALTER DATABASE [library_app] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [library_app] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [library_app] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [library_app] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [library_app] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [library_app] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [library_app] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [library_app] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [library_app] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [library_app] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [library_app] SET  DISABLE_BROKER 
GO
ALTER DATABASE [library_app] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [library_app] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [library_app] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [library_app] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [library_app] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [library_app] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [library_app] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [library_app] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [library_app] SET  MULTI_USER 
GO
ALTER DATABASE [library_app] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [library_app] SET DB_CHAINING OFF 
GO
ALTER DATABASE [library_app] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [library_app] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [library_app]
GO
/****** Object:  Table [dbo].[tblArticle]    Script Date: 11/30/2014 10:46:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblArticle](
	[ArticleID] [bigint] IDENTITY(1,1) NOT NULL,
	[TypeArticleID] [int] NULL,
	[Article] [varchar](250) NOT NULL,
 CONSTRAINT [PK_tblArticle] PRIMARY KEY CLUSTERED 
(
	[ArticleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblClients]    Script Date: 11/30/2014 10:46:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblClients](
	[ClientID] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Address] [varchar](100) NULL,
	[PostalCode] [varchar](10) NULL,
	[City] [varchar](50) NULL,
	[DateOfBirth] [date] NULL,
 CONSTRAINT [PK_tblClients] PRIMARY KEY CLUSTERED 
(
	[ClientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblLoans]    Script Date: 11/30/2014 10:46:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLoans](
	[LoanID] [bigint] IDENTITY(1,1) NOT NULL,
	[ArticleID] [bigint] NOT NULL,
	[ClientID] [bigint] NOT NULL,
	[DateLoan] [date] NOT NULL,
	[DateReturn] [date] NOT NULL,
	[Amount] [float] NOT NULL,
	[Returned] [bit] NOT NULL,
 CONSTRAINT [PK_tblLoans] PRIMARY KEY CLUSTERED 
(
	[LoanID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblTypeArticle]    Script Date: 11/30/2014 10:46:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblTypeArticle](
	[TypeArticleID] [int] IDENTITY(1,1) NOT NULL,
	[TypeArticle] [varchar](50) NULL,
 CONSTRAINT [PK_tblTypeArticle] PRIMARY KEY CLUSTERED 
(
	[TypeArticleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[tblArticle]  WITH CHECK ADD  CONSTRAINT [FK_tblArticle_tblTypeArticle] FOREIGN KEY([TypeArticleID])
REFERENCES [dbo].[tblTypeArticle] ([TypeArticleID])
GO
ALTER TABLE [dbo].[tblArticle] CHECK CONSTRAINT [FK_tblArticle_tblTypeArticle]
GO
ALTER TABLE [dbo].[tblLoans]  WITH CHECK ADD  CONSTRAINT [FK_tblLoans_tblArticle] FOREIGN KEY([ArticleID])
REFERENCES [dbo].[tblArticle] ([ArticleID])
GO
ALTER TABLE [dbo].[tblLoans] CHECK CONSTRAINT [FK_tblLoans_tblArticle]
GO
ALTER TABLE [dbo].[tblLoans]  WITH CHECK ADD  CONSTRAINT [FK_tblLoans_tblClients] FOREIGN KEY([ClientID])
REFERENCES [dbo].[tblClients] ([ClientID])
GO
ALTER TABLE [dbo].[tblLoans] CHECK CONSTRAINT [FK_tblLoans_tblClients]
GO
USE [master]
GO
ALTER DATABASE [library_app] SET  READ_WRITE 
GO
