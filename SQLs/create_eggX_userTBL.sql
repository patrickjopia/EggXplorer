USE [eggX_users]
GO

/****** Object:  Table [dbo].[tbl_eggXuser]    Script Date: 3/10/2022 2:49:24 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_eggXuser](
	[userID] [char](10) NOT NULL,
	[full_name] [varchar](50) NULL,
	[user_role] [char](10) NULL,
	[user_name] [varchar](50) NULL,
	[user_pass] [varchar](50) NULL,
 CONSTRAINT [PK_tbl_eggXuser] PRIMARY KEY CLUSTERED 
(
	[userID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


