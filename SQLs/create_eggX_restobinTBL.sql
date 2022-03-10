USE [eggX_resto]
GO

/****** Object:  Table [dbo].[tbl_eggX_resto_BIN]    Script Date: 3/10/2022 2:48:33 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_eggX_resto_BIN](
	[resto_ID] [nchar](10) NOT NULL,
	[resto_name] [varchar](50) NOT NULL,
	[resto_location] [nvarchar](50) NOT NULL,
	[resto_branch] [nvarchar](50) NOT NULL,
	[resto_rating] [float] NULL,
	[resto_trashed_by] [varchar](50) NOT NULL,
	[resto_trashed_date] [varchar](50) NOT NULL,
	[resto_trashed_countdown] [varchar](50) NOT NULL,
	[resto_trashed_deadline] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_eggX_resto_BIN] PRIMARY KEY CLUSTERED 
(
	[resto_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


