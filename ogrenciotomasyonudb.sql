USE [TestDevexpresOgrenciOtomasyon]
GO
/****** Object:  Table [dbo].[TBL_KULUPLER]    Script Date: 27.06.2019 15:02:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_KULUPLER](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[KULUPAD] [nvarchar](20) NULL,
 CONSTRAINT [PK_TBL_KULÜPLER] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_OGRENCİLER]    Script Date: 27.06.2019 15:02:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_OGRENCİLER](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AD] [nvarchar](50) NULL,
	[SOYAD] [nvarchar](50) NULL,
	[NUMARA] [nvarchar](50) NULL,
	[FOTOGRAF] [nvarchar](200) NULL,
	[KULUP] [int] NULL,
	[ORTALAMA] [int] NULL,
 CONSTRAINT [PK_TBL_OGRENCİLER] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_TELEFONREHBERİ]    Script Date: 27.06.2019 15:02:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_TELEFONREHBERİ](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ADINIZ] [nvarchar](50) NULL,
	[SOYADINIZ] [nvarchar](50) NULL,
	[EVTEL] [nvarchar](50) NULL,
	[CEPTEL] [nvarchar](50) NULL,
	[ADRES] [nvarchar](100) NULL,
	[RESİM] [nvarchar](50) NULL,
 CONSTRAINT [PK_TBL_TELEFONREHBERİ] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[TBL_OGRENCİLER]  WITH CHECK ADD  CONSTRAINT [FK_TBL_OGRENCİLER_TBL_KULÜPLER] FOREIGN KEY([KULUP])
REFERENCES [dbo].[TBL_KULUPLER] ([ID])
GO
ALTER TABLE [dbo].[TBL_OGRENCİLER] CHECK CONSTRAINT [FK_TBL_OGRENCİLER_TBL_KULÜPLER]
GO
