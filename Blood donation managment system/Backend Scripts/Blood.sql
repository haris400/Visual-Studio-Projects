USE [BDMS]
GO

/****** Object:  Table [dbo].[Blood]    Script Date: 12/4/2018 8:12:25 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Blood](
	[Blood_Type] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Blood] PRIMARY KEY CLUSTERED 
(
	[Blood_Type] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


