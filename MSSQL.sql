USE [MSSQL]
GO
/****** Object:  Table [dbo].[Person]    Script Date: 14.09.2021 17:55:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[LastName] [nvarchar](200) NOT NULL,
	[FirstName] [nvarchar](200) NOT NULL,
	[MiddleName] [nvarchar](200) NULL,
	[BirthDate] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Person] ON 

INSERT [dbo].[Person] ([Id], [LastName], [FirstName], [MiddleName], [BirthDate]) VALUES (4, N'Назирмадов', N'Абубакр', NULL, CAST(N'1990-01-01 00:00:00.000' AS DateTime))
INSERT [dbo].[Person] ([Id], [LastName], [FirstName], [MiddleName], [BirthDate]) VALUES (5, N'Бобохуджаев', N'Азиз', NULL, CAST(N'1991-02-01 00:00:00.000' AS DateTime))
INSERT [dbo].[Person] ([Id], [LastName], [FirstName], [MiddleName], [BirthDate]) VALUES (6, N'Ибрагимов', N'Амир', NULL, CAST(N'1992-03-01 00:00:00.000' AS DateTime))
INSERT [dbo].[Person] ([Id], [LastName], [FirstName], [MiddleName], [BirthDate]) VALUES (7, N'Амирбек', N'Махмуди', NULL, CAST(N'1993-04-01 00:00:00.000' AS DateTime))
INSERT [dbo].[Person] ([Id], [LastName], [FirstName], [MiddleName], [BirthDate]) VALUES (8, N'Хасанов', N'Асадулло', NULL, CAST(N'1994-05-01 00:00:00.000' AS DateTime))
INSERT [dbo].[Person] ([Id], [LastName], [FirstName], [MiddleName], [BirthDate]) VALUES (9, N'Мухаммеджанов', N'Исматулло', NULL, CAST(N'1995-06-01 00:00:00.000' AS DateTime))
INSERT [dbo].[Person] ([Id], [LastName], [FirstName], [MiddleName], [BirthDate]) VALUES (10, N'Шехов', N'Исмоил', NULL, CAST(N'1996-07-01 00:00:00.000' AS DateTime))
INSERT [dbo].[Person] ([Id], [LastName], [FirstName], [MiddleName], [BirthDate]) VALUES (11, N'Закиров', N'Мусоджон', NULL, CAST(N'1997-08-01 00:00:00.000' AS DateTime))
INSERT [dbo].[Person] ([Id], [LastName], [FirstName], [MiddleName], [BirthDate]) VALUES (12, N'Абдурахимов', N'Назар', NULL, CAST(N'1998-09-01 00:00:00.000' AS DateTime))
INSERT [dbo].[Person] ([Id], [LastName], [FirstName], [MiddleName], [BirthDate]) VALUES (13, N'Каримов', N'Парвиз', NULL, CAST(N'1999-10-01 00:00:00.000' AS DateTime))
INSERT [dbo].[Person] ([Id], [LastName], [FirstName], [MiddleName], [BirthDate]) VALUES (14, N'Абдуллоев', N'Сарвар', NULL, CAST(N'2000-11-01 00:00:00.000' AS DateTime))
INSERT [dbo].[Person] ([Id], [LastName], [FirstName], [MiddleName], [BirthDate]) VALUES (15, N'Сулаймони', N'Саъдии', NULL, CAST(N'2001-12-01 00:00:00.000' AS DateTime))
INSERT [dbo].[Person] ([Id], [LastName], [FirstName], [MiddleName], [BirthDate]) VALUES (16, N'Нозимов', N'Сорбон', NULL, CAST(N'2002-01-02 00:00:00.000' AS DateTime))
INSERT [dbo].[Person] ([Id], [LastName], [FirstName], [MiddleName], [BirthDate]) VALUES (17, N'Рашидов', N'Сорбонбек', NULL, CAST(N'2003-02-03 00:00:00.000' AS DateTime))
INSERT [dbo].[Person] ([Id], [LastName], [FirstName], [MiddleName], [BirthDate]) VALUES (18, N'Зафаров', N'Сулеймон', NULL, CAST(N'2004-03-04 00:00:00.000' AS DateTime))
INSERT [dbo].[Person] ([Id], [LastName], [FirstName], [MiddleName], [BirthDate]) VALUES (19, N'Мавлонова', N'Таманно', NULL, CAST(N'1997-04-05 00:00:00.000' AS DateTime))
INSERT [dbo].[Person] ([Id], [LastName], [FirstName], [MiddleName], [BirthDate]) VALUES (20, N'Худойкулов', N'Фаридун', NULL, CAST(N'1996-02-19 00:00:00.000' AS DateTime))
INSERT [dbo].[Person] ([Id], [LastName], [FirstName], [MiddleName], [BirthDate]) VALUES (21, N'Сорбон', N'Фаридуни', NULL, CAST(N'1998-05-06 00:00:00.000' AS DateTime))
INSERT [dbo].[Person] ([Id], [LastName], [FirstName], [MiddleName], [BirthDate]) VALUES (22, N'Кавраков', N'Шавкат', NULL, CAST(N'1999-06-07 00:00:00.000' AS DateTime))
INSERT [dbo].[Person] ([Id], [LastName], [FirstName], [MiddleName], [BirthDate]) VALUES (23, N'Насриддинзода', N'Дилдора', NULL, CAST(N'2000-07-08 00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Person] OFF
