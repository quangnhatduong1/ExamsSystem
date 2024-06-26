USE [master]
GO
/****** Object:  Database [exammanager]    Script Date: 5/8/2021 1:11:55 AM ******/
CREATE DATABASE [exammanager]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'exammanager', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\exammanager.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'exammanager_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\exammanager_log.ldf' , SIZE = 1600KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [exammanager] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [exammanager].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [exammanager] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [exammanager] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [exammanager] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [exammanager] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [exammanager] SET ARITHABORT OFF 
GO
ALTER DATABASE [exammanager] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [exammanager] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [exammanager] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [exammanager] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [exammanager] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [exammanager] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [exammanager] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [exammanager] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [exammanager] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [exammanager] SET  ENABLE_BROKER 
GO
ALTER DATABASE [exammanager] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [exammanager] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [exammanager] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [exammanager] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [exammanager] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [exammanager] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [exammanager] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [exammanager] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [exammanager] SET  MULTI_USER 
GO
ALTER DATABASE [exammanager] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [exammanager] SET DB_CHAINING OFF 
GO
ALTER DATABASE [exammanager] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [exammanager] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [exammanager] SET DELAYED_DURABILITY = DISABLED 
GO
USE [exammanager]
GO
/****** Object:  Table [dbo].[accounts]    Script Date: 5/8/2021 1:11:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[accounts](
	[username] [varchar](254) NOT NULL,
	[password] [varchar](254) NULL,
	[rolename] [varchar](254) NULL,
PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[exams]    Script Date: 5/8/2021 1:11:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[exams](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](254) NULL,
	[subjectid] [int] NULL,
	[checkout] [int] NULL DEFAULT ((0)),
	[dotime] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[exams_questions]    Script Date: 5/8/2021 1:11:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[exams_questions](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[questionid] [int] NOT NULL,
	[examid] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[questionid] ASC,
	[examid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[information]    Script Date: 5/8/2021 1:11:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[information](
	[username] [varchar](254) NOT NULL,
	[fullname] [varchar](254) NULL,
	[birthday] [varchar](254) NULL,
	[phonenumber] [varchar](254) NULL,
	[email] [varchar](254) NULL,
PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[present_exam_subject_report]    Script Date: 5/8/2021 1:11:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[present_exam_subject_report](
	[reportid] [int] IDENTITY(1,1) NOT NULL,
	[testdate] [varchar](254) NULL,
	[subjectid] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[reportid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[present_exam_test_report]    Script Date: 5/8/2021 1:11:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[present_exam_test_report](
	[reportid] [int] IDENTITY(1,1) NOT NULL,
	[testid] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[reportid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[questions]    Script Date: 5/8/2021 1:11:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[questions](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[title] [ntext] NULL,
	[answera] [ntext] NULL,
	[answerb] [ntext] NULL,
	[answerc] [ntext] NULL,
	[answerd] [ntext] NULL,
	[rightanswer] [varchar](254) NULL,
	[typequestion] [int] NULL,
	[subjectid] [int] NULL,
	[username] [varchar](254) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[reports]    Script Date: 5/8/2021 1:11:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[reports](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[typereport] [varchar](254) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[roles]    Script Date: 5/8/2021 1:11:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[roles](
	[rolename] [varchar](254) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[rolename] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[student_test_report]    Script Date: 5/8/2021 1:11:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[student_test_report](
	[reportid] [int] IDENTITY(1,1) NOT NULL,
	[testdate] [varchar](254) NULL,
	[subjectid] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[reportid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[students]    Script Date: 5/8/2021 1:11:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[students](
	[username] [varchar](254) NOT NULL,
	[classname] [varchar](254) NULL,
PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[students_tests]    Script Date: 5/8/2021 1:11:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[students_tests](
	[username] [varchar](254) NOT NULL,
	[testid] [int] NOT NULL,
	[startdotime] [datetime] NULL,
	[submittime] [datetime] NULL,
	[rightanswercount] [int] NULL DEFAULT ((0)),
	[score] [float] NULL DEFAULT ((0.0)),
PRIMARY KEY CLUSTERED 
(
	[username] ASC,
	[testid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[subjects]    Script Date: 5/8/2021 1:11:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[subjects](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](254) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[teachers]    Script Date: 5/8/2021 1:11:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[teachers](
	[username] [varchar](254) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[teaching]    Script Date: 5/8/2021 1:11:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[teaching](
	[username] [varchar](254) NOT NULL,
	[subjectid] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[username] ASC,
	[subjectid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tests]    Script Date: 5/8/2021 1:11:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tests](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[examid] [int] NULL,
	[datestart] [datetime] NULL,
	[openstate] [int] NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[accounts] ([username], [password], [rolename]) VALUES (N'admin', N'MoC8yU7TqCjbo9FxVlEYiQ==', N'AM')
INSERT [dbo].[accounts] ([username], [password], [rolename]) VALUES (N'giaovientest1', N'RXD/DagnExd7Uf3qyWoGV6lH2pXAPUo+xt3KYfIYZUk=', N'GV')
INSERT [dbo].[accounts] ([username], [password], [rolename]) VALUES (N'giaovientest2', N'RXD/DagnExd7Uf3qyWoGV6lH2pXAPUo+xt3KYfIYZUk=', N'GV')
INSERT [dbo].[accounts] ([username], [password], [rolename]) VALUES (N'hocsinh1', N'G/UeA7Lg1wXW6oWDGj82aFj4hYQNBM3OTuUkSaump1A=', N'HS')
INSERT [dbo].[accounts] ([username], [password], [rolename]) VALUES (N'hocsinh10', N'G/UeA7Lg1wXW6oWDGj82aFj4hYQNBM3OTuUkSaump1A=', N'HS')
INSERT [dbo].[accounts] ([username], [password], [rolename]) VALUES (N'hocsinh2', N'G/UeA7Lg1wXW6oWDGj82aFj4hYQNBM3OTuUkSaump1A=', N'HS')
INSERT [dbo].[accounts] ([username], [password], [rolename]) VALUES (N'hocsinh3', N'G/UeA7Lg1wXW6oWDGj82aFj4hYQNBM3OTuUkSaump1A=', N'HS')
INSERT [dbo].[accounts] ([username], [password], [rolename]) VALUES (N'hocsinh4', N'G/UeA7Lg1wXW6oWDGj82aFj4hYQNBM3OTuUkSaump1A=', N'HS')
INSERT [dbo].[accounts] ([username], [password], [rolename]) VALUES (N'hocsinh5', N'G/UeA7Lg1wXW6oWDGj82aFj4hYQNBM3OTuUkSaump1A=', N'HS')
INSERT [dbo].[accounts] ([username], [password], [rolename]) VALUES (N'hocsinh6', N'G/UeA7Lg1wXW6oWDGj82aFj4hYQNBM3OTuUkSaump1A=', N'HS')
INSERT [dbo].[accounts] ([username], [password], [rolename]) VALUES (N'hocsinh7', N'G/UeA7Lg1wXW6oWDGj82aFj4hYQNBM3OTuUkSaump1A=', N'HS')
INSERT [dbo].[accounts] ([username], [password], [rolename]) VALUES (N'hocsinh8', N'G/UeA7Lg1wXW6oWDGj82aFj4hYQNBM3OTuUkSaump1A=', N'HS')
INSERT [dbo].[accounts] ([username], [password], [rolename]) VALUES (N'hocsinh9', N'G/UeA7Lg1wXW6oWDGj82aFj4hYQNBM3OTuUkSaump1A=', N'HS')
INSERT [dbo].[accounts] ([username], [password], [rolename]) VALUES (N'hocvutest1', N'8OILUJoVGfG/emQC7ByROoMQ3ipe5hv3Otf2Q5/mkXQ=', N'HV')
SET IDENTITY_INSERT [dbo].[exams] ON 

INSERT [dbo].[exams] ([id], [username], [subjectid], [checkout], [dotime]) VALUES (1, N'giaovientest1', 2, 1, 45)
INSERT [dbo].[exams] ([id], [username], [subjectid], [checkout], [dotime]) VALUES (3, N'giaovientest2', 3, 1, 60)
INSERT [dbo].[exams] ([id], [username], [subjectid], [checkout], [dotime]) VALUES (4, N'giaovientest2', 3, 0, 45)
INSERT [dbo].[exams] ([id], [username], [subjectid], [checkout], [dotime]) VALUES (5, N'giaovientest2', 3, 0, 150)
INSERT [dbo].[exams] ([id], [username], [subjectid], [checkout], [dotime]) VALUES (6, N'giaovientest1', 2, 0, 60)
INSERT [dbo].[exams] ([id], [username], [subjectid], [checkout], [dotime]) VALUES (7, N'giaovientest1', 2, 0, 120)
SET IDENTITY_INSERT [dbo].[exams] OFF
SET IDENTITY_INSERT [dbo].[exams_questions] ON 

INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (1, 1, 1)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (141, 1, 6)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (181, 1, 7)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (2, 2, 1)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (142, 2, 6)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (182, 2, 7)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (3, 3, 1)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (143, 3, 6)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (183, 3, 7)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (4, 4, 1)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (144, 4, 6)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (184, 4, 7)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (5, 5, 1)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (145, 5, 6)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (185, 5, 7)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (6, 6, 1)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (146, 6, 6)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (186, 6, 7)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (7, 7, 1)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (147, 7, 6)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (187, 7, 7)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (8, 8, 1)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (148, 8, 6)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (188, 8, 7)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (9, 9, 1)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (149, 9, 6)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (189, 9, 7)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (10, 10, 1)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (150, 10, 6)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (190, 10, 7)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (11, 11, 1)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (151, 11, 6)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (191, 11, 7)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (12, 12, 1)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (152, 12, 6)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (192, 12, 7)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (13, 13, 1)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (153, 13, 6)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (193, 13, 7)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (14, 14, 1)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (154, 14, 6)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (194, 14, 7)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (15, 15, 1)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (155, 15, 6)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (195, 15, 7)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (16, 16, 1)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (156, 16, 6)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (196, 16, 7)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (17, 17, 1)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (157, 17, 6)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (197, 17, 7)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (18, 18, 1)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (158, 18, 6)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (198, 18, 7)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (19, 19, 1)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (159, 19, 6)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (199, 19, 7)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (20, 20, 1)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (160, 20, 6)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (200, 20, 7)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (21, 21, 1)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (161, 21, 6)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (201, 21, 7)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (22, 22, 1)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (162, 22, 6)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (202, 22, 7)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (23, 23, 1)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (163, 23, 6)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (203, 23, 7)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (24, 24, 1)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (164, 24, 6)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (204, 24, 7)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (25, 25, 1)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (165, 25, 6)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (205, 25, 7)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (26, 26, 1)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (166, 26, 6)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (206, 26, 7)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (27, 28, 1)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (167, 28, 6)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (207, 28, 7)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (28, 29, 1)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (168, 29, 6)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (208, 29, 7)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (29, 30, 1)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (169, 30, 6)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (209, 30, 7)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (30, 31, 1)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (170, 31, 6)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (210, 31, 7)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (31, 32, 1)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (171, 32, 6)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (211, 32, 7)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (32, 33, 1)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (172, 33, 6)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (212, 33, 7)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (33, 34, 1)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (173, 34, 6)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (213, 34, 7)
GO
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (34, 35, 1)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (174, 35, 6)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (214, 35, 7)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (35, 36, 1)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (175, 36, 6)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (215, 36, 7)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (36, 37, 1)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (176, 37, 6)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (216, 37, 7)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (37, 38, 1)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (177, 38, 6)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (217, 38, 7)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (38, 39, 1)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (178, 39, 6)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (218, 39, 7)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (39, 40, 1)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (179, 40, 6)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (219, 40, 7)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (40, 41, 1)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (180, 41, 6)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (220, 41, 7)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (81, 42, 3)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (101, 42, 4)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (121, 42, 5)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (82, 43, 3)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (102, 43, 4)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (122, 43, 5)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (83, 44, 3)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (103, 44, 4)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (123, 44, 5)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (84, 45, 3)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (104, 45, 4)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (124, 45, 5)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (85, 46, 3)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (105, 46, 4)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (125, 46, 5)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (86, 47, 3)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (106, 47, 4)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (126, 47, 5)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (87, 48, 3)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (107, 48, 4)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (127, 48, 5)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (88, 49, 3)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (108, 49, 4)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (128, 49, 5)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (89, 50, 3)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (109, 50, 4)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (129, 50, 5)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (90, 51, 3)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (110, 51, 4)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (130, 51, 5)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (91, 52, 3)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (111, 52, 4)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (131, 52, 5)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (92, 53, 3)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (112, 53, 4)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (132, 53, 5)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (93, 54, 3)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (113, 54, 4)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (133, 54, 5)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (94, 55, 3)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (114, 55, 4)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (134, 55, 5)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (95, 56, 3)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (115, 56, 4)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (135, 56, 5)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (96, 57, 3)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (116, 57, 4)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (136, 57, 5)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (97, 58, 3)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (117, 58, 4)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (137, 58, 5)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (98, 59, 3)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (118, 59, 4)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (138, 59, 5)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (99, 60, 3)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (119, 60, 4)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (139, 60, 5)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (100, 61, 3)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (120, 61, 4)
INSERT [dbo].[exams_questions] ([id], [questionid], [examid]) VALUES (140, 61, 5)
SET IDENTITY_INSERT [dbo].[exams_questions] OFF
INSERT [dbo].[information] ([username], [fullname], [birthday], [phonenumber], [email]) VALUES (N'admin', N'Tô Thanh Tín', N'18/05/2000', N'tothanhtin123@gmail.com', N'0358551006')
INSERT [dbo].[information] ([username], [fullname], [birthday], [phonenumber], [email]) VALUES (N'giaovientest1', N'Giáo Viên 1', N'01/01/2000', N'0358551002', N'giaovien1@gmail.com')
INSERT [dbo].[information] ([username], [fullname], [birthday], [phonenumber], [email]) VALUES (N'giaovientest2', N'Giáo Viên 2', N'01/01/2000', N'0358221005', N'giaovientest2@gmail.com')
INSERT [dbo].[information] ([username], [fullname], [birthday], [phonenumber], [email]) VALUES (N'hocsinh1', N'Nguy?n Văn A', N'01/01/2000', N'0358994447', N'hocsinh1@gmail.com')
INSERT [dbo].[information] ([username], [fullname], [birthday], [phonenumber], [email]) VALUES (N'hocsinh10', N'Nguy?n Văn Y', N'01/01/2000', N'0254778887', N'hocsinh10@gmail.com')
INSERT [dbo].[information] ([username], [fullname], [birthday], [phonenumber], [email]) VALUES (N'hocsinh2', N'Nguy?n Văn B', N'01/01/2000', N'03621147012', N'hocsinh2@gmail.com')
INSERT [dbo].[information] ([username], [fullname], [birthday], [phonenumber], [email]) VALUES (N'hocsinh3', N'Nguy?n Văn C', N'01/01/2000', N'0351448992', N'hocsinh3@gmail.com')
INSERT [dbo].[information] ([username], [fullname], [birthday], [phonenumber], [email]) VALUES (N'hocsinh4', N'Nguy?n Văn D', N'01/01/2000', N'0369887552', N'hocsinh4@gmail.com')
INSERT [dbo].[information] ([username], [fullname], [birthday], [phonenumber], [email]) VALUES (N'hocsinh5', N'Nguy?n Văn E', N'01/01/2000', N'0358441223', N'hocsinh5@gmail.com')
INSERT [dbo].[information] ([username], [fullname], [birthday], [phonenumber], [email]) VALUES (N'hocsinh6', N'Nguy?n Văn Q', N'01/01/2000', N'0356665551', N'hocsinh6@gmail.com')
INSERT [dbo].[information] ([username], [fullname], [birthday], [phonenumber], [email]) VALUES (N'hocsinh7', N'Nguy?n Thanh W', N'01/01/2000', N'0356998881', N'hocsinh7@gmail.com')
INSERT [dbo].[information] ([username], [fullname], [birthday], [phonenumber], [email]) VALUES (N'hocsinh8', N'Nguy?n Văn R', N'01/01/2000', N'0321114778', N'hocsinh8@gmail.com')
INSERT [dbo].[information] ([username], [fullname], [birthday], [phonenumber], [email]) VALUES (N'hocsinh9', N'Nguy?n Văn T', N'01/01/2000', N'0369996665', N'hocsinh9@gmail.com')
INSERT [dbo].[information] ([username], [fullname], [birthday], [phonenumber], [email]) VALUES (N'hocvutest1', N'Nguy?n H?c V?', N'01/01/2000', N'0369995558', N'hocvutest1@gmail.com')
SET IDENTITY_INSERT [dbo].[questions] ON 

INSERT [dbo].[questions] ([id], [title], [answera], [answerb], [answerc], [answerd], [rightanswer], [typequestion], [subjectid], [username]) VALUES (1, N'Mục tiêu đấu tranh chủ yếu của phong trào công nhân Việt Nam từ năm 1919 đến năm 1924 là gì?', N'Đòi quyền lợi về kinh tế.', N'Giành ruộng đất cho dân cày.', N'Đòi quyền lợi về chính trị. 
', N'Giành độc lập cho dân tộc.', N'A', 0, 2, N'giaovientest1')
INSERT [dbo].[questions] ([id], [title], [answera], [answerb], [answerc], [answerd], [rightanswer], [typequestion], [subjectid], [username]) VALUES (2, N'Việt Nam Quốc dân đảng (1927-1930) có hoạt động nào sau đây?', N'Phát động khởi nghĩa Yên Bái', N'Xuất bản tờ báo “Thanh niên”.', N'Tổ chức phong trào “vô sản hóa”. ', N'Phát động nhân dân tổng khởi nghĩa.', N'A', 0, 2, N'giaovientest1')
INSERT [dbo].[questions] ([id], [title], [answera], [answerb], [answerc], [answerd], [rightanswer], [typequestion], [subjectid], [username]) VALUES (3, N'Sự kiện lịch sử thế giới nào sau đây có ảnh hưởng đến cách mạng Việt Nam thời kì 1939-1945?', N'Chiến tranh lạnh chấm dứt. ', N'Trật tự hai cực Ianta sụp đổ.', N'Chiến tranh thế giới thứ hai bùng nổ. x', N'Liên minh châu Âu được thành lập.', N'C', 0, 2, N'giaovientest1')
INSERT [dbo].[questions] ([id], [title], [answera], [answerb], [answerc], [answerd], [rightanswer], [typequestion], [subjectid], [username]) VALUES (4, N'Bản Hiến pháp tháng 11-1993 đã chính thức xóa bỏ chế độ phân biệt chủng tộc (Apácthai) ở quốc gia nào sau đây?', N'Mianma.', N'Angiêri', N'Nam Phi.', N'Malaixia.', N'C', 0, 2, N'giaovientest1')
INSERT [dbo].[questions] ([id], [title], [answera], [answerb], [answerc], [answerd], [rightanswer], [typequestion], [subjectid], [username]) VALUES (5, N'Thắng lợi nào sau đây của nhân dân Việt Nam trong thế kỉ XX đã góp phần chiến thắng chủ nghĩa phát xít trên thế giới?', N'Cách mạng tháng Tám năm 1945.', N'Kháng chiến chống Pháp (1945-1954)', N'Chiến thắng Điện Biên Phủ năm 1954', N'Tổng tiến công và nổi dậy Xuân 1975', N'A', 0, 2, N'giaovientest1')
INSERT [dbo].[questions] ([id], [title], [answera], [answerb], [answerc], [answerd], [rightanswer], [typequestion], [subjectid], [username]) VALUES (6, N'Nhân tố khách quan nào sau đây đã giúp kinh tế các nước Tây Âu phục hồi sau Chiến tranh thế giới thứ hai?', N'Tác động của xu thế toàn cầu hóa. ', N'Sự giúp đỡ và viện trợ của Liên Xô.', N'Sự nỗ lực của toàn thể nhân dân trong nước.', N'Viện trợ của Mĩ theo kế hoạch Mácsan', N'C', 0, 2, N'giaovientest1')
INSERT [dbo].[questions] ([id], [title], [answera], [answerb], [answerc], [answerd], [rightanswer], [typequestion], [subjectid], [username]) VALUES (7, N'Nội dung nào sau đây phản ánh đúng ý nghĩa Cuộc Tổng tiến công và nổi dậy Xuân Mậu Thân năm 1968 của quân dân Việt Nam?', N'Buộc Mĩ phải tuyên bố “phi Mĩ hóa” chiến tranh xâm lược', N'Buộc Mĩ phải tuyên bố “Mĩ hóa” trở lại chiến tranh xâm lược', N'Mĩ phải công nhận các quyền dân tộc cơ bản của nhân dân ta', N'Đánh bại hoàn toàn ý chí xâm lược của đế quốc Mĩ', N'A', 0, 2, N'giaovientest1')
INSERT [dbo].[questions] ([id], [title], [answera], [answerb], [answerc], [answerd], [rightanswer], [typequestion], [subjectid], [username]) VALUES (8, N'Nội dung nào sau đây là âm mưu cơ bản của Mĩ khi tiến hành chiến lược Chiến tranh đặc biệt (1961-1965) ở miền Nam Việt Nam?', N'Biến miền Nam thành căn cứ quân sự duy nhất.', N'Biến miền Nam thành thị trường xuất khẩu duy nhất.', N'Biến miền Nam thành thuộc địa kiểu mới', N'Biến miền Nam thành đồng minh duy nhất.', N'C', 0, 2, N'giaovientest1')
INSERT [dbo].[questions] ([id], [title], [answera], [answerb], [answerc], [answerd], [rightanswer], [typequestion], [subjectid], [username]) VALUES (9, N'Đại hội Đại biểu lần thứ II của Đảng Cộng sản Đông Dương (2-1951) quyết định xuất bản tờ báo nào sau đây?', N'Búa liềm', N'Nhân dân', N'Người cùng khổ', N'Thanh niên', N'B', 0, 2, N'giaovientest1')
INSERT [dbo].[questions] ([id], [title], [answera], [answerb], [answerc], [answerd], [rightanswer], [typequestion], [subjectid], [username]) VALUES (10, N'Hội nghị Ban Chấp hành Trung ương Đảng Cộng sản Đông Dương (5-1941) đã xác định nhiệm vụ chủ yếu trước mắt của cách mạng Đông Dương là gì?', N'Đòi tự do, dân sinh, dân chủ.', N'Cách mạng ruộng đất.', N'Giải phóng dân tộc', N'Chống đế quốc và phong kiến.', N'C', 0, 2, N'giaovientest1')
INSERT [dbo].[questions] ([id], [title], [answera], [answerb], [answerc], [answerd], [rightanswer], [typequestion], [subjectid], [username]) VALUES (11, N'Ngay sau khi Chiến tranh thế giới thứ hai kết thúc, Liên Xô thực hiện nhiệm vụ nào sau đây?', N'Tiến hành công cuộc đổi mới đất nước.', N'Viện trợ cho các nước tư bản chủ nghĩa.', N'Khôi phục kinh tế', N'Phát triển kinh tế thị trường.', N'AC', 1, 2, N'giaovientest1')
INSERT [dbo].[questions] ([id], [title], [answera], [answerb], [answerc], [answerd], [rightanswer], [typequestion], [subjectid], [username]) VALUES (12, N'Sau Hiệp định Giơnevơ năm 1954 về Đông Dương, cách mạng miền Nam Việt Nam thực hiện nhiệm vụ nào sau đây?', N'Tiếp tục cuộc cách mạng dân tộc dân chủ nhân dân', N'Kháng chiến chống thực dân Pháp xâm lược', N'Đấu tranh chống quân Trung Hoa Dân quốc', N'Xây dựng chủ nghĩa xã hội', N'A', 0, 2, N'giaovientest1')
INSERT [dbo].[questions] ([id], [title], [answera], [answerb], [answerc], [answerd], [rightanswer], [typequestion], [subjectid], [username]) VALUES (13, N'Chiến lược kinh tế hướng ngoại của nhóm năm nước sáng lập tổ chức ASEAN trong những năm 60-70 của thế kỉ XX không có nội dung nào sau đây?', N'Tập trung sản xuất hàng hoá để xuất khẩu.', N'Thu hút vốn đầu tư và kĩ thuật nước ngoài.', N'Lấy thị trường trong nước làm chỗ dựa để phát triển sản xuất', N'Tiến hành mở cửa nền kinh tế, phát triển ngoại thương.', N'C', 0, 2, N'giaovientest1')
INSERT [dbo].[questions] ([id], [title], [answera], [answerb], [answerc], [answerd], [rightanswer], [typequestion], [subjectid], [username]) VALUES (14, N'Tổ chức nào sau đây là tổ chức liên kết chính trị - kinh tế lớn nhất thế giới hiện nay?', N'Hiệp hội các nước Đông Nam Á (ASEAN). ', N'Hội đồng tương trợ kinh tế (SEV).', N'Quỹ tiền tệ quốc tế (IMF).', N'Liên minh châu Âu (EU).', N'D', 0, 2, N'giaovientest1')
INSERT [dbo].[questions] ([id], [title], [answera], [answerb], [answerc], [answerd], [rightanswer], [typequestion], [subjectid], [username]) VALUES (15, N'Từ năm 1969 đến năm 1973, ở miền Nam Việt Nam, đế quốc Mĩ đã thực hiện chiến lược chiến tranh nào sau đây?', N'Chiến tranh cục bộ.', N'Chiến tranh đặc biệt.', N'Chiến tranh đơn phương. ', N'Việt Nam hoá chiến tranh.', N'D', 0, 2, N'giaovientest1')
INSERT [dbo].[questions] ([id], [title], [answera], [answerb], [answerc], [answerd], [rightanswer], [typequestion], [subjectid], [username]) VALUES (16, N'Với Hiệp định Sơ bộ (6-3-1946), Chính phủ Việt Nam Dân chủ Cộng hòa thực hiện chủ trương “hoà để tiến” với thế lực ngoại xâm nào?', N'Anh.', N'Mĩ', N'Nhật', N'Pháp', N'D', 0, 2, N'giaovientest1')
INSERT [dbo].[questions] ([id], [title], [answera], [answerb], [answerc], [answerd], [rightanswer], [typequestion], [subjectid], [username]) VALUES (17, N'Theo quyết định của Hội nghị Ianta (2-1945), vùng Đông Âu thuộc phạm vi ảnh hưởng của nước nào sau đây?', N'Nhật', N'Liên Xô', N'Cuba', N'Đức', N'B', 0, 2, N'giaovientest1')
INSERT [dbo].[questions] ([id], [title], [answera], [answerb], [answerc], [answerd], [rightanswer], [typequestion], [subjectid], [username]) VALUES (18, N'Sự kiện nào sau đây đánh dấu lần đầu tiên trong lịch sử dân tộc, nhân dân ta được thực hiện quyền công dân?', N'Tổng tuyển cử bầu Quốc hội khóa I', N'Tổng tuyển cử bầu Quốc hội khóa VI', N'Chủ tịch Hồ Chí Minh đọc “Tuyên ngôn độc lập”.', N'Nước Việt Nam Dân chủ Cộng hòa ra đời.', N'A', 0, 2, N'giaovientest1')
INSERT [dbo].[questions] ([id], [title], [answera], [answerb], [answerc], [answerd], [rightanswer], [typequestion], [subjectid], [username]) VALUES (19, N'Trong những năm 1919-1925, Nguyễn Ái Quốc có hoạt động nào sau đây?', N'Thành lập Hội Việt Nam Cách mạng Thanh niên.', N'Triệu tập Hội nghị hợp nhất các tổ chức cộng sản.', N'Tham gia sáng lập Đảng Cộng sản Pháp', N'Dự Đại hội lần thứ V Quốc tế Cộng sản', N'ACD', 1, 2, N'giaovientest1')
INSERT [dbo].[questions] ([id], [title], [answera], [answerb], [answerc], [answerd], [rightanswer], [typequestion], [subjectid], [username]) VALUES (20, N'Chiến thắng Biên giới thu - đông năm 1950 của quân dân Việt Nam đã thực hiện được mục tiêu nào sau đây?', N'Làm thất bại chiến tranh cục bộ. ', N'Tiêu diệt một bộ phận sinh lực địch.', N'Buộc Pháp kết thúc chiến tranh xâm lược.', N'Làm thất bại chiến tranh đặc biệt.', N'B', 0, 2, N'giaovientest1')
INSERT [dbo].[questions] ([id], [title], [answera], [answerb], [answerc], [answerd], [rightanswer], [typequestion], [subjectid], [username]) VALUES (21, N'Hình thức đấu tranh nào sau đây được sử dụng trong phong trào dân chủ 1936-1939 ở Việt Nam?', N'Đấu tranh nghị trường', N'Đấu tranh vũ trang', N'Mít tinh, biểu tình', N'Đấu tranh trên lĩnh vực báo chí', N'ACD', 1, 2, N'giaovientest1')
INSERT [dbo].[questions] ([id], [title], [answera], [answerb], [answerc], [answerd], [rightanswer], [typequestion], [subjectid], [username]) VALUES (22, N'Trong khoảng nửa sau những năm 40 của thế kỉ XX, nền kinh tế của quốc gia nào sau đây chiếm gần 40% tổng sản phẩm kinh tế thế giới?', N'Bồ Đào Nha', N'Mĩ', N'Tây Ban Nha', N'Phần Lan', N'B', 0, 2, N'giaovientest1')
INSERT [dbo].[questions] ([id], [title], [answera], [answerb], [answerc], [answerd], [rightanswer], [typequestion], [subjectid], [username]) VALUES (23, N'Sau Chiến tranh thế giới thứ hai, trật tự thế giới nào sau đây được thiết lập?', N'Trật tự Vécxai - Oasinhtơn.', N'Trật tự hai cực Ianta', N'Trật tự đơn cực', N'Trật tự đa cực', N'B', 0, 2, N'giaovientest1')
INSERT [dbo].[questions] ([id], [title], [answera], [answerb], [answerc], [answerd], [rightanswer], [typequestion], [subjectid], [username]) VALUES (24, N'Trong những năm 1885-1896, ở Việt Nam diễn ra phong trào đấu tranh nào sau đây?', N'Khởi nghĩa Thái Nguyên', N'Khởi nghĩa Yên Bái', N'Phong trào nông dân Yên Thế', N'Phong trào Cần vương', N'D', 0, 2, N'giaovientest1')
INSERT [dbo].[questions] ([id], [title], [answera], [answerb], [answerc], [answerd], [rightanswer], [typequestion], [subjectid], [username]) VALUES (25, N'Chiến thắng quân sự nào sau đây của quân dân miền Nam Việt Nam đã góp phần làm phá sản cơ bản chiến lược Chiến tranh đặc biệt (1961-1965) của Mĩ?', N'Vạn Tường (Quảng Ngãi).', N'Ấp Bắc (Mĩ Tho).', N'Bình Giã (Vũng Tàu).', N'An Lão (Bình Định).', N'C', 0, 2, N'giaovientest1')
INSERT [dbo].[questions] ([id], [title], [answera], [answerb], [answerc], [answerd], [rightanswer], [typequestion], [subjectid], [username]) VALUES (26, N'Lực lượng nào sau đây giữ vai trò chủ yếu trong chiến lược Chiến tranh cục bộ (1965-1968) của Mĩ ở miền Nam Việt Nam?', N'Quân đồng minh của Mĩ.', N'Cố vấn Mĩ.', N'Quân viễn chinh Mĩ.', N'Quân đội Sài Gòn.', N'C', 0, 2, N'giaovientest1')
INSERT [dbo].[questions] ([id], [title], [answera], [answerb], [answerc], [answerd], [rightanswer], [typequestion], [subjectid], [username]) VALUES (27, N'Thực dân Pháp kí với Chính phủ Trung Hoa Dân quốc Hiệp ước Hoa - Pháp (2-1946) nhưng không thực hiện âm mưu nào sau đây ?', N'Đưa quân ra miền Bắc để hoàn thành việc xâm lược Việt Nam', N'Ra miền Bắc Việt Nam chia sẻ quyền lợi với Trung Hoa Dân quốc.', N'Phối hợp với quân Trung Hoa Dân quốc xâm lược Việt Nam lần thứ hai.', N'Phối hợp với quân Trung Hoa Dân quốc làm nhiệm vụ giải giáp quân Nhật.', N'D', 0, 2, N'giaovientest1')
INSERT [dbo].[questions] ([id], [title], [answera], [answerb], [answerc], [answerd], [rightanswer], [typequestion], [subjectid], [username]) VALUES (28, N'Thực dân Pháp kí với Chính phủ Trung Hoa Dân quốc Hiệp ước Hoa - Pháp (2-1946) nhưng không thực hiện âm mưu nào sau đây ?', N'Đưa quân ra miền Bắc để hoàn thành việc xâm lược Việt Nam', N'Ra miền Bắc Việt Nam chia sẻ quyền lợi với Trung Hoa Dân quốc.', N'Phối hợp với quân Trung Hoa Dân quốc xâm lược Việt Nam lần thứ hai.', N'Phối hợp với quân Trung Hoa Dân quốc làm nhiệm vụ giải giáp quân Nhật.', N'BCD', 1, 2, N'giaovientest1')
INSERT [dbo].[questions] ([id], [title], [answera], [answerb], [answerc], [answerd], [rightanswer], [typequestion], [subjectid], [username]) VALUES (29, N'Sau Chiến tranh thế giới thứ hai, phong trào giải phóng dân tộc ở châu Phi được mệnh danh là: “Lục địa trỗi dậy” vì lí do nào sau đây?', N'Phong trào giải phóng dân tộc phát triển mạnh mẽ.', N'Làm sụp đổ hệ thống thuộc địa của chủ nghĩa thực dân mới.', N'Sử dụng chủ yếu hình thức đấu tranh vũ trang.', N'Các nước đều đi lên xây dựng chủ nghĩa xã hội.', N'A', 0, 2, N'giaovientest1')
INSERT [dbo].[questions] ([id], [title], [answera], [answerb], [answerc], [answerd], [rightanswer], [typequestion], [subjectid], [username]) VALUES (30, N'Trong quá trình thực hiện chiến lược toàn cầu từ sau Chiến tranh thế giới thứ hai đến năm 1991, Mĩ chưa đạt được kết quả nào sau đây?', N'Xây dựng được căn cứ quân sự ở tất cả các nước.', N'Duy trì vị trí cường quốc số một trên tất cả các lĩnh vực.', N'Thiết lập và duy trì được trật tự thế giới “đơn cực”.', N'Mở rộng phạm vi ảnh hưởng ở nhiều nơi trên thế giới.', N'ABC', 1, 2, N'giaovientest1')
INSERT [dbo].[questions] ([id], [title], [answera], [answerb], [answerc], [answerd], [rightanswer], [typequestion], [subjectid], [username]) VALUES (31, N'Nội dung nào sau đây là điểm chung về mục đích của thực dân Pháp khi đề ra kế hoạch Rơve, kế hoạch Đờ Lát đơ Tátxinhi và kế hoạch Nava trong cuộc chiến tranh xâm lược Việt Nam (1945-1954)?', N'Nhanh chóng kết thúc chiến tranh', N'Tấn công lên căn cứ địa Việt Bắc.', N'Giành quyền chủ động chiến lược. ', N'Khóa chặt biên giới Việt - Trung.', N'A', 0, 2, N'giaovientest1')
INSERT [dbo].[questions] ([id], [title], [answera], [answerb], [answerc], [answerd], [rightanswer], [typequestion], [subjectid], [username]) VALUES (32, N'Hiệp định hạn chế vũ khí tiến công chiến lược được kí kết giữa Liên Xô và Mĩ (1972) có ý nghĩa như thế nào?', N'Hai tổ chức quân sự đối đầu ở châu Âu tan rã.', N'Giảm bớt cuộc chạy đua vũ trang giữa hai nước.', N'Xuất hiện xu thế toàn cầu hóa trên thế giới.', N'Chấm dứt hoàn toàn tình trạng đối đầu Đông - Tây.', N'B', 0, 2, N'giaovientest1')
INSERT [dbo].[questions] ([id], [title], [answera], [answerb], [answerc], [answerd], [rightanswer], [typequestion], [subjectid], [username]) VALUES (33, N'Nội dung nào sau đây là điểm mới của cuộc khai thác thuộc địa lần thứ hai (1919-1929) so với cuộc khai thác thuộc địa lần thứ nhất (1897-1914) của thực dân Pháp ở Đông Dương?', N'Khai thác mỏ được đầu tư nhiều nhất.', N'Đầu tư vốn với quy mô lớn, tốc độ nhanh.', N'Hạn chế sự phát triển của công nghiệp nặng.', N'Đầu tư nhiều nhất vào lĩnh vực công nghiệp.', N'AB', 1, 2, N'giaovientest1')
INSERT [dbo].[questions] ([id], [title], [answera], [answerb], [answerc], [answerd], [rightanswer], [typequestion], [subjectid], [username]) VALUES (34, N'Nhận xét nào sau đây là đúng về thắng lợi của phong trào giải phóng dân tộc ở khu vực Mĩ Latinh sau Chiến tranh thế giới thứ hai?', N'Làm cho xu thế toàn cầu hóa xuất hiện và phát triển.', N'Làm cho chiến lược toàn cầu của Mĩ bị phá sản hoàn toàn.', N'Đánh dấu chủ nghĩa xã hội trở thành hệ thống thế giới.', N'Góp phần làm cho quan hệ quốc tế được mở rộng và đa dạng', N'D', 0, 2, N'giaovientest1')
INSERT [dbo].[questions] ([id], [title], [answera], [answerb], [answerc], [answerd], [rightanswer], [typequestion], [subjectid], [username]) VALUES (35, N'Nhận xét nào sau đây phản ánh đúng tính chất của Cách mạng tháng Tám năm 1945 ở Việt Nam?', N'Có tính dân chủ điển hình.', N'Không mang tính bạo lực.', N'Không mang tính cải lương.', N'Chỉ mang tính chất dân tộc.', N'C', 0, 2, N'giaovientest1')
INSERT [dbo].[questions] ([id], [title], [answera], [answerb], [answerc], [answerd], [rightanswer], [typequestion], [subjectid], [username]) VALUES (36, N'Nội dung nào sau đây là biện pháp cơ bản được Mĩ thực hiện xuyên suốt trong các chiến lược chiến tranh ở miền Nam Việt Nam (1961-1973)?', N'Tiến hành chiến tranh tổng lực.', N'Sử dụng quân đội Mĩ làm nòng cốt.', N'Ra sức chiếm đất, giành dân.', N'Sử dụng quân đội đồng minh.', N'C', 0, 2, N'giaovientest1')
INSERT [dbo].[questions] ([id], [title], [answera], [answerb], [answerc], [answerd], [rightanswer], [typequestion], [subjectid], [username]) VALUES (37, N'Thực tiễn các phong trào yêu nước Việt Nam từ đầu thế kỉ XX đến năm 1918 đã để lại bài học kinh nghiệm nào sau đây?', N'Sự giúp đỡ từ bên ngoài là điều kiện tiên quyết để đấu tranh giành độc lập.', N'Sử dụng sức mạnh của cả dân tộc để giải quyết vấn đề dân tộc giải phóng', N'Tiến hành đồng thời cách mạng giải phóng dân tộc và cách mạng ruộng đất.', N'Chỉ khi lực lượng vũ trang lớn mạnh mới phát động quần chúng đấu tranh.', N'B', 0, 2, N'giaovientest1')
INSERT [dbo].[questions] ([id], [title], [answera], [answerb], [answerc], [answerd], [rightanswer], [typequestion], [subjectid], [username]) VALUES (38, N'Ở Việt Nam, phong trào dân chủ 1936-1939 có điểm khác biệt nào sau đây về bối cảnh lịch sử so với phong trào cách mạng 1930-1931?', N'Đời sống nhân dân lao động khó khăn, cực khổ.', N'Phong trào cách mạng thế giới đang phát triển.', N'Có sự lãnh đạo kịp thời của Đảng Cộng sản', N'Chính quyền thuộc địa nới lỏng chính sách cai trị.', N'BC', 1, 2, N'giaovientest1')
INSERT [dbo].[questions] ([id], [title], [answera], [answerb], [answerc], [answerd], [rightanswer], [typequestion], [subjectid], [username]) VALUES (39, N'Trong cuộc kháng chiến chống thực dân Pháp (1945-1954), những thắng lợi quân sự của quân dân Việt Nam đều có điểm chung nào sau đây?', N'Nhận viện trợ từ các nước xã hội chủ nghĩa.', N'Lực lượng chính trị giữ vai trò quyết định thắng lợi.', N'Phá sản bước đầu các kế hoạch quân sự của Pháp.', N'Sử dụng bạo lực cách mạng của quần chúng.', N'D', 0, 2, N'giaovientest1')
INSERT [dbo].[questions] ([id], [title], [answera], [answerb], [answerc], [answerd], [rightanswer], [typequestion], [subjectid], [username]) VALUES (40, N'Nội dung nào sau đây của Hội nghị Ban Chấp hành Trung ương Đảng Cộng sản Đông Dương (7- 1936) đã khắc phục một trong những hạn chế của Luận cương chính trị (10-1930)?', N'Đặt vấn đề giải phóng dân tộc lên hàng đầu.', N'Giải quyết vấn đề dân tộc trong từng nước Đông Dương.', N'Xác định phương pháp đấu tranh công khai và hợp pháp.', N'Thành lập được một mặt trận dân tộc thống nhất.', N'D', 0, 2, N'giaovientest1')
INSERT [dbo].[questions] ([id], [title], [answera], [answerb], [answerc], [answerd], [rightanswer], [typequestion], [subjectid], [username]) VALUES (41, N'Hiệp hội các quốc gia Đông Nam Á (ASEAN) được thành lập trong bối cảnh nào sau đây?', N'Xu thế liên kết khu vực diễn ra mạnh mẽ.', N'Xô - Mĩ tuyên bố chấm dứt Chiến tranh lạnh.', N'Việt Nam đã kết thúc cuộc kháng chiến chống Mĩ.', N'Xu thế hòa hoãn Đông - Tây đã xuất hiện.', N'A', 0, 2, N'giaovientest1')
INSERT [dbo].[questions] ([id], [title], [answera], [answerb], [answerc], [answerd], [rightanswer], [typequestion], [subjectid], [username]) VALUES (42, N'Quá trình đô thị hóa ở nước ta hiện nay có', N'mạng lưới cơ sở hạ tầng kỹ thuật rất hiện đại.', N'tốc độ đô thị hóa chậm, trình độ đô thị hóa thấp.', N'thị trường tiêu thụ rộng lớn, phân bố đồng đều', N'mạng lưới đô thị phân bố đều giữa các vùng.', N'B', 0, 3, N'giaovientest2')
INSERT [dbo].[questions] ([id], [title], [answera], [answerb], [answerc], [answerd], [rightanswer], [typequestion], [subjectid], [username]) VALUES (43, N'Căn cứ vào Atlat Địa lí Việt Nam trang 17, cho biết vùng kinh tế nào sau đây có nhiều tỉnh/thành phố nhất? ', N'Duyên hải Nam Trung Bộ.', N'Đồng bằng sông Cửu Long', N'Đông Nam Bộ.', N'Đồng bằng sông Hồng.', N'B', 0, 3, N'giaovientest2')
INSERT [dbo].[questions] ([id], [title], [answera], [answerb], [answerc], [answerd], [rightanswer], [typequestion], [subjectid], [username]) VALUES (44, N'Căn cứ vào Atlat Địa lí Việt Nam trang 22, các mỏ khí đốt đang được khai thác ở nước ta (năm 2007) là', N'Lan Tây', N'Lan Đỏ', N'Hồng Ngọc', N'Tiền Hải', N'ABD', 1, 3, N'giaovientest2')
INSERT [dbo].[questions] ([id], [title], [answera], [answerb], [answerc], [answerd], [rightanswer], [typequestion], [subjectid], [username]) VALUES (45, N'Nguyên nhân về mặt tự nhiên làm suy giảm tính đa dạng sinh vật của nước ta là', N'biến đổi khí hậu', N'ô nhiễm môi trường.', N'chiến tranh tàn phá các khu rừng.', N'săn bắn động vật hoang dã.', N'A', 0, 3, N'giaovientest2')
INSERT [dbo].[questions] ([id], [title], [answera], [answerb], [answerc], [answerd], [rightanswer], [typequestion], [subjectid], [username]) VALUES (46, N'Ngành trồng trọt nước ta hiện nay', N'cây lương thực, cây công nghiệp, ăn quả tăng nhanh tỉ trọng.', N'cây công nghiệp, rau đậu, cây ăn quả chiếm tỉ trọng chủ yếu.', N'cơ cấu giá trị sản xuất ngành trồng trọt tương đối ổn định.', N'chiếm tỉ trọng cao trong cơ cấu giá trị sản xuất nông nghiệp.', N'D', 0, 3, N'giaovientest2')
INSERT [dbo].[questions] ([id], [title], [answera], [answerb], [answerc], [answerd], [rightanswer], [typequestion], [subjectid], [username]) VALUES (47, N'Căn cứ vào Atlat Địa lí Việt Nam trang 8, hãy cho biết các mỏ đá vôi xi măng lớn nhất phía nam phân bố ở tỉnh', N'An Giang.', N'Đồng Nai.', N'Tiền Giang.', N'Kiên Giang.', N'D', 0, 3, N'giaovientest2')
INSERT [dbo].[questions] ([id], [title], [answera], [answerb], [answerc], [answerd], [rightanswer], [typequestion], [subjectid], [username]) VALUES (48, N'Nước ta nằm trong khu vực gió mùa Châu Á nên', N'khí hậu có hai mùa rõ rệt.', N'lượng mưa lớn, độ ẩm cao.', N'năng nhiều, tổng bức xạ lớn.', N'nhiệt độ trung bình năm cao.', N'A', 0, 3, N'giaovientest2')
INSERT [dbo].[questions] ([id], [title], [answera], [answerb], [answerc], [answerd], [rightanswer], [typequestion], [subjectid], [username]) VALUES (49, N': Căn cứ vào Atlat Địa lí Việt Nam trang 15, hãy cho biết các đô thị Tân An, Hưng Yên, Lạng Sơn, Đồng Hới thuộc loại nào sau đây ?', N'Loại 1.', N'Loại 2.', N'. Loại 3', N'. Loại 4. ', N'C', 0, 3, N'giaovientest2')
INSERT [dbo].[questions] ([id], [title], [answera], [answerb], [answerc], [answerd], [rightanswer], [typequestion], [subjectid], [username]) VALUES (50, N'Căn cứ vào Atlat Địa lí Việt Nam trang 23, các cảng biển ở vùng Bắc Trung Bộ là', N'Cửa Lò', N'Nhật Lệ', N'Vũng Áng', N'Chân Mây', N'ABCD', 1, 3, N'giaovientest2')
INSERT [dbo].[questions] ([id], [title], [answera], [answerb], [answerc], [answerd], [rightanswer], [typequestion], [subjectid], [username]) VALUES (51, N'Căn cứ vào Atlat Địa lí Việt Nam trang 4- 5, hãy cho biết nước nào sau đây có đường biên giới chung với nước ta dài nhất', N'Trung Quốc.', N'Thái Lan.', N'Lào', N'Campuchia.', N'D', 0, 3, N'giaovientest2')
INSERT [dbo].[questions] ([id], [title], [answera], [answerb], [answerc], [answerd], [rightanswer], [typequestion], [subjectid], [username]) VALUES (52, N'Căn cứ vào Atlat Địa lí Việt Nam trang 21, hãy cho biết các trung tâm công nghiệp nào sau đây có quy mô từ 9 đến 40 nghìn tỉ đồng?', N'Hạ Long', N'Đà Nẵng', N'Nha Trang', N'Đồng Nai', N'ABC', 1, 3, N'giaovientest2')
INSERT [dbo].[questions] ([id], [title], [answera], [answerb], [answerc], [answerd], [rightanswer], [typequestion], [subjectid], [username]) VALUES (53, N'Ngoại thương nước ta hiện nay ', N'thị trường thu hẹp', N'phân bố đồng đều.', N'thị trường mở rộng', N'cán cân luôn dương', N'C', 0, 3, N'giaovientest2')
INSERT [dbo].[questions] ([id], [title], [answera], [answerb], [answerc], [answerd], [rightanswer], [typequestion], [subjectid], [username]) VALUES (54, N'Căn cứ vào Atlat Địa lí Việt Nam trang 24, hãy cho biết các tỉnh, thành phố nào sau đây có giá trị nhập siêu năm 2007?', N'Lạng Sơn, Bình Dương, Hà Nội, Hải Phòng', N'Lào Cai, Hà Nội, Bình Định, Đà Nẵng.', N'Vĩnh Phúc, Hà Nội, Hưng Yên, Khánh Hòa.', N'Đồng Nai, Đà Nẵng, Hải Phòng, Hà Nội.', N'D', 0, 3, N'giaovientest2')
INSERT [dbo].[questions] ([id], [title], [answera], [answerb], [answerc], [answerd], [rightanswer], [typequestion], [subjectid], [username]) VALUES (55, N'Ngành thủy sản nước ta hiện nay chú trọng vào những yếu tố nào ?', N'chỉ chú trọng hoạt động khai thác.', N'sản lượng nuôi trồng tăng nhanh', N'hoàn toàn là thủy sản nước mặn.', N'tỉ trọng đánh bắt ngày càng tăng. ', N'BD', 1, 3, N'giaovientest2')
INSERT [dbo].[questions] ([id], [title], [answera], [answerb], [answerc], [answerd], [rightanswer], [typequestion], [subjectid], [username]) VALUES (56, N'Căn cứ vào Atlat Địa lí Việt Nam trang 19, tỉnh có số lượng trâu lớn nhất ở vùng Trung du và miền núi Bắc Bộ (năm 2007) là', N'Hà Giang.', N'Tuyên Quang', N'Sơn La', N'Lạng Sơn', N'B', 0, 3, N'giaovientest2')
INSERT [dbo].[questions] ([id], [title], [answera], [answerb], [answerc], [answerd], [rightanswer], [typequestion], [subjectid], [username]) VALUES (57, N'Căn cứ vào Atlat Địa lí Việt Nam trang 9, hãy cho biết khu vực chịu tác động của gió Đông Nam thịnh hành vào mùa hạ ở nước ta là', N'Bắc Trung Bộ.', N'Đồng bằng sông Hồng. ', N'Tây Nguyên', N'Tây Bắc', N'B', 0, 3, N'giaovientest2')
INSERT [dbo].[questions] ([id], [title], [answera], [answerb], [answerc], [answerd], [rightanswer], [typequestion], [subjectid], [username]) VALUES (58, N'Căn cứ vào Atlat Địa lí Việt Nam trang 29, khu kinh tế cửa khẩu Hoa Lư thuộc tỉnh nào của vùng Đông Nam Bộ?', N'Đồng Nai.', N'Tây Ninh', N'Bình Dương.', N'Bình Phước.', N'D', 0, 3, N'giaovientest2')
INSERT [dbo].[questions] ([id], [title], [answera], [answerb], [answerc], [answerd], [rightanswer], [typequestion], [subjectid], [username]) VALUES (59, N'Cơ cấu lao động theo thành phần kinh tế nước ta hiện nay', N'tăng rất nhanh lao động công nghiệp - xây dựng.', N'giảm tỉ trọng lao động nông thôn, tăng thành thị. ', N'phân bố tập trung ở thành thị, giảm ở nông thôn.', N'tập trung chủ yếu ở khu vực kinh tế ngoài nhà nước', N'D', 0, 3, N'giaovientest2')
INSERT [dbo].[questions] ([id], [title], [answera], [answerb], [answerc], [answerd], [rightanswer], [typequestion], [subjectid], [username]) VALUES (60, N'Tài nguyên rừng nước ta bị suy thoái chủ yếu do ', N'nạn du canh du cư.', N'biến đổi khí hậu.', N'khai thác quá mức.', N'chuyển đổi sử dụng.', N'C', 0, 3, N'giaovientest2')
INSERT [dbo].[questions] ([id], [title], [answera], [answerb], [answerc], [answerd], [rightanswer], [typequestion], [subjectid], [username]) VALUES (61, N'Tiềm năng dầu khí nước ta tập trung chủ yếu ở', N'vùng trung du.', N'vùng đồng bằng.', N'thềm lục địa.', N'vùng ven biển.', N'C', 0, 3, N'giaovientest2')
SET IDENTITY_INSERT [dbo].[questions] OFF
INSERT [dbo].[roles] ([rolename]) VALUES (N'AM')
INSERT [dbo].[roles] ([rolename]) VALUES (N'GV')
INSERT [dbo].[roles] ([rolename]) VALUES (N'HS')
INSERT [dbo].[roles] ([rolename]) VALUES (N'HV')
INSERT [dbo].[students] ([username], [classname]) VALUES (N'admin', N'LT-1')
INSERT [dbo].[students] ([username], [classname]) VALUES (N'hocsinh1', N'LT-1')
INSERT [dbo].[students] ([username], [classname]) VALUES (N'hocsinh10', N'LT-2')
INSERT [dbo].[students] ([username], [classname]) VALUES (N'hocsinh2', N'LT-2')
INSERT [dbo].[students] ([username], [classname]) VALUES (N'hocsinh3', N'LT-1')
INSERT [dbo].[students] ([username], [classname]) VALUES (N'hocsinh4', N'LT-1')
INSERT [dbo].[students] ([username], [classname]) VALUES (N'hocsinh5', N'LT-1')
INSERT [dbo].[students] ([username], [classname]) VALUES (N'hocsinh6', N'LT-1')
INSERT [dbo].[students] ([username], [classname]) VALUES (N'hocsinh7', N'LT-2')
INSERT [dbo].[students] ([username], [classname]) VALUES (N'hocsinh8', N'LT-2')
INSERT [dbo].[students] ([username], [classname]) VALUES (N'hocsinh9', N'LT-2')
INSERT [dbo].[students_tests] ([username], [testid], [startdotime], [submittime], [rightanswercount], [score]) VALUES (N'hocsinh1', 1, CAST(N'2021-05-08 01:01:25.000' AS DateTime), CAST(N'2021-05-08 01:02:31.000' AS DateTime), 6, 1.5)
INSERT [dbo].[students_tests] ([username], [testid], [startdotime], [submittime], [rightanswercount], [score]) VALUES (N'hocsinh2', 1, CAST(N'2021-05-08 01:03:08.000' AS DateTime), CAST(N'2021-05-08 01:05:31.000' AS DateTime), 38, 9.5)
INSERT [dbo].[students_tests] ([username], [testid], [startdotime], [submittime], [rightanswercount], [score]) VALUES (N'hocsinh3', 1, CAST(N'2021-05-08 01:06:01.000' AS DateTime), CAST(N'2021-05-08 01:06:03.000' AS DateTime), 0, 0)
INSERT [dbo].[students_tests] ([username], [testid], [startdotime], [submittime], [rightanswercount], [score]) VALUES (N'hocsinh4', 1, CAST(N'2021-05-08 01:06:30.000' AS DateTime), CAST(N'2021-05-08 01:07:52.000' AS DateTime), 22, 5.5)
INSERT [dbo].[students_tests] ([username], [testid], [startdotime], [submittime], [rightanswercount], [score]) VALUES (N'hocsinh5', 1, CAST(N'2021-05-08 01:08:16.000' AS DateTime), CAST(N'2021-05-08 01:08:45.000' AS DateTime), 10, 2.5)
SET IDENTITY_INSERT [dbo].[subjects] ON 

INSERT [dbo].[subjects] ([id], [name]) VALUES (3, N'Địa lý')
INSERT [dbo].[subjects] ([id], [name]) VALUES (1, N'Giáo dục công dân')
INSERT [dbo].[subjects] ([id], [name]) VALUES (2, N'Lịch sử')
SET IDENTITY_INSERT [dbo].[subjects] OFF
INSERT [dbo].[teachers] ([username]) VALUES (N'admin')
INSERT [dbo].[teachers] ([username]) VALUES (N'giaovientest1')
INSERT [dbo].[teachers] ([username]) VALUES (N'giaovientest2')
INSERT [dbo].[teaching] ([username], [subjectid]) VALUES (N'admin', 1)
INSERT [dbo].[teaching] ([username], [subjectid]) VALUES (N'admin', 2)
INSERT [dbo].[teaching] ([username], [subjectid]) VALUES (N'admin', 3)
INSERT [dbo].[teaching] ([username], [subjectid]) VALUES (N'giaovientest1', 2)
INSERT [dbo].[teaching] ([username], [subjectid]) VALUES (N'giaovientest2', 3)
SET IDENTITY_INSERT [dbo].[tests] ON 

INSERT [dbo].[tests] ([id], [examid], [datestart], [openstate]) VALUES (1, 1, CAST(N'2021-05-08 00:55:33.000' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[tests] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__subjects__72E12F1B06FB5718]    Script Date: 5/8/2021 1:11:55 AM ******/
ALTER TABLE [dbo].[subjects] ADD UNIQUE NONCLUSTERED 
(
	[name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[accounts]  WITH CHECK ADD  CONSTRAINT [FK_accounts_rolename_roles] FOREIGN KEY([rolename])
REFERENCES [dbo].[roles] ([rolename])
GO
ALTER TABLE [dbo].[accounts] CHECK CONSTRAINT [FK_accounts_rolename_roles]
GO
ALTER TABLE [dbo].[exams]  WITH CHECK ADD  CONSTRAINT [FK_exams_teacherid_subjectid_teaching] FOREIGN KEY([username], [subjectid])
REFERENCES [dbo].[teaching] ([username], [subjectid])
GO
ALTER TABLE [dbo].[exams] CHECK CONSTRAINT [FK_exams_teacherid_subjectid_teaching]
GO
ALTER TABLE [dbo].[exams_questions]  WITH CHECK ADD  CONSTRAINT [FK_questions_examid_exams] FOREIGN KEY([examid])
REFERENCES [dbo].[exams] ([id])
GO
ALTER TABLE [dbo].[exams_questions] CHECK CONSTRAINT [FK_questions_examid_exams]
GO
ALTER TABLE [dbo].[exams_questions]  WITH CHECK ADD  CONSTRAINT [FK_questions_examid_question] FOREIGN KEY([questionid])
REFERENCES [dbo].[questions] ([id])
GO
ALTER TABLE [dbo].[exams_questions] CHECK CONSTRAINT [FK_questions_examid_question]
GO
ALTER TABLE [dbo].[information]  WITH CHECK ADD  CONSTRAINT [FK_information_username_accounts] FOREIGN KEY([username])
REFERENCES [dbo].[accounts] ([username])
GO
ALTER TABLE [dbo].[information] CHECK CONSTRAINT [FK_information_username_accounts]
GO
ALTER TABLE [dbo].[present_exam_subject_report]  WITH CHECK ADD  CONSTRAINT [present_exam_subject_report_reportid_reports] FOREIGN KEY([reportid])
REFERENCES [dbo].[reports] ([id])
GO
ALTER TABLE [dbo].[present_exam_subject_report] CHECK CONSTRAINT [present_exam_subject_report_reportid_reports]
GO
ALTER TABLE [dbo].[present_exam_subject_report]  WITH CHECK ADD  CONSTRAINT [present_exam_subject_report_subjectid_subjects] FOREIGN KEY([subjectid])
REFERENCES [dbo].[subjects] ([id])
GO
ALTER TABLE [dbo].[present_exam_subject_report] CHECK CONSTRAINT [present_exam_subject_report_subjectid_subjects]
GO
ALTER TABLE [dbo].[present_exam_test_report]  WITH CHECK ADD  CONSTRAINT [present_exam_test_report_reportid_reports] FOREIGN KEY([reportid])
REFERENCES [dbo].[reports] ([id])
GO
ALTER TABLE [dbo].[present_exam_test_report] CHECK CONSTRAINT [present_exam_test_report_reportid_reports]
GO
ALTER TABLE [dbo].[present_exam_test_report]  WITH CHECK ADD  CONSTRAINT [present_exam_test_report_testid_test] FOREIGN KEY([testid])
REFERENCES [dbo].[tests] ([id])
GO
ALTER TABLE [dbo].[present_exam_test_report] CHECK CONSTRAINT [present_exam_test_report_testid_test]
GO
ALTER TABLE [dbo].[questions]  WITH CHECK ADD  CONSTRAINT [FK_questions_subjectid_subjects] FOREIGN KEY([username], [subjectid])
REFERENCES [dbo].[teaching] ([username], [subjectid])
GO
ALTER TABLE [dbo].[questions] CHECK CONSTRAINT [FK_questions_subjectid_subjects]
GO
ALTER TABLE [dbo].[student_test_report]  WITH CHECK ADD  CONSTRAINT [student_test_report_reportid_reports] FOREIGN KEY([reportid])
REFERENCES [dbo].[reports] ([id])
GO
ALTER TABLE [dbo].[student_test_report] CHECK CONSTRAINT [student_test_report_reportid_reports]
GO
ALTER TABLE [dbo].[student_test_report]  WITH CHECK ADD  CONSTRAINT [student_test_report_subjectid_subjects] FOREIGN KEY([subjectid])
REFERENCES [dbo].[subjects] ([id])
GO
ALTER TABLE [dbo].[student_test_report] CHECK CONSTRAINT [student_test_report_subjectid_subjects]
GO
ALTER TABLE [dbo].[students]  WITH CHECK ADD  CONSTRAINT [FK_students_username_accounts] FOREIGN KEY([username])
REFERENCES [dbo].[accounts] ([username])
GO
ALTER TABLE [dbo].[students] CHECK CONSTRAINT [FK_students_username_accounts]
GO
ALTER TABLE [dbo].[students_tests]  WITH CHECK ADD  CONSTRAINT [FK_students_tests_studentid_students] FOREIGN KEY([username])
REFERENCES [dbo].[students] ([username])
GO
ALTER TABLE [dbo].[students_tests] CHECK CONSTRAINT [FK_students_tests_studentid_students]
GO
ALTER TABLE [dbo].[students_tests]  WITH CHECK ADD  CONSTRAINT [FK_students_tests_testid_tests] FOREIGN KEY([testid])
REFERENCES [dbo].[tests] ([id])
GO
ALTER TABLE [dbo].[students_tests] CHECK CONSTRAINT [FK_students_tests_testid_tests]
GO
ALTER TABLE [dbo].[teachers]  WITH CHECK ADD  CONSTRAINT [FK_teachers_username_accounts] FOREIGN KEY([username])
REFERENCES [dbo].[accounts] ([username])
GO
ALTER TABLE [dbo].[teachers] CHECK CONSTRAINT [FK_teachers_username_accounts]
GO
ALTER TABLE [dbo].[teaching]  WITH CHECK ADD  CONSTRAINT [FK_teaching_subjectid_subjects] FOREIGN KEY([subjectid])
REFERENCES [dbo].[subjects] ([id])
GO
ALTER TABLE [dbo].[teaching] CHECK CONSTRAINT [FK_teaching_subjectid_subjects]
GO
ALTER TABLE [dbo].[teaching]  WITH CHECK ADD  CONSTRAINT [FK_teaching_teacherid_teachers] FOREIGN KEY([username])
REFERENCES [dbo].[teachers] ([username])
GO
ALTER TABLE [dbo].[teaching] CHECK CONSTRAINT [FK_teaching_teacherid_teachers]
GO
ALTER TABLE [dbo].[tests]  WITH CHECK ADD  CONSTRAINT [FK_tests_examid_exams] FOREIGN KEY([examid])
REFERENCES [dbo].[exams] ([id])
GO
ALTER TABLE [dbo].[tests] CHECK CONSTRAINT [FK_tests_examid_exams]
GO
USE [master]
GO
ALTER DATABASE [exammanager] SET  READ_WRITE 
GO
