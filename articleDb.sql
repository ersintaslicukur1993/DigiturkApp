USE [ArticleDb]
GO
/****** Object:  Table [dbo].[Article]    Script Date: 19.01.2020 11:51:26 ******/
DROP TABLE [dbo].[Article]
GO
/****** Object:  Table [dbo].[Article]    Script Date: 19.01.2020 11:51:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Article](
	[ArticleID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](255) NULL,
	[Description] [nvarchar](max) NULL,
	[ImageUrl] [nvarchar](255) NULL,
	[CreateDate] [datetime] NULL,
	[UpdateDate] [datetime] NULL,
	[Active] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ArticleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Article] ON 

INSERT [dbo].[Article] ([ArticleID], [Name], [Description], [ImageUrl], [CreateDate], [UpdateDate], [Active]) VALUES (1, N'updateting', N'makale açıklaması', N'resimiz', CAST(N'2020-01-19T14:12:00.000' AS DateTime), CAST(N'2000-10-10T00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Article] ([ArticleID], [Name], [Description], [ImageUrl], [CreateDate], [UpdateDate], [Active]) VALUES (2, N'İkinci makalem', N'dldlfl', N'fglglkgk', CAST(N'2020-01-12T12:00:00.000' AS DateTime), CAST(N'2000-01-01T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Article] ([ArticleID], [Name], [Description], [ImageUrl], [CreateDate], [UpdateDate], [Active]) VALUES (3, N'yeni kayıt', N'yeni makalem', N'resimim yok', CAST(N'2020-01-19T14:12:00.000' AS DateTime), CAST(N'2000-10-10T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Article] ([ArticleID], [Name], [Description], [ImageUrl], [CreateDate], [UpdateDate], [Active]) VALUES (4, N'Makale içeriği', N'makaleee', N'resimim yok', CAST(N'2020-01-19T11:31:44.957' AS DateTime), CAST(N'2000-01-01T00:00:00.000' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[Article] OFF
