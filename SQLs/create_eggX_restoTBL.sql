USE [eggX_resto]
GO

/****** Object:  Table [dbo].[tbl_eggX_resto]    Script Date: 3/10/2022 2:47:47 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_eggX_resto](
	[resto_ID] [nchar](10) NOT NULL,
	[resto_name] [varchar](50) NULL,
	[resto_location] [nvarchar](50) NULL,
	[resto_branch] [nvarchar](50) NULL,
	[resto_rating] [float] NULL,
	[resto_added_by] [varchar](50) NULL,
	[resto_added_date] [date] NULL,
	[resto_modified_by] [varchar](50) NULL,
	[resto_modified_date] [date] NULL,
	[resto_modified_fields] [varchar](50) NULL,
 CONSTRAINT [PK_tbl_eggX_resto] PRIMARY KEY CLUSTERED 
(
	[resto_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


