USE [BDMS]
GO

/****** Object:  Table [dbo].[Donor]    Script Date: 12/4/2018 8:12:51 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Donor](
	[D_id] [int] IDENTITY(1000,1) NOT NULL,
	[D_Name] [nvarchar](50) NULL,
	[D_Father_Name] [nvarchar](50) NULL,
	[DOB] [nvarchar](50) NULL,
	[CNIC] [nvarchar](50) NULL,
	[PhoneNo] [nvarchar](50) NULL,
	[Gender] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
	[Height] [int] NULL,
	[Disease] [nvarchar](50) NULL,
	[Blood_Group] [nvarchar](50) NULL,
	[Donated_Before] [nvarchar](50) NULL,
	[Previous_D_Date] [nvarchar](50) NULL,
 CONSTRAINT [PK_Donor] PRIMARY KEY CLUSTERED 
(
	[D_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Donor]  WITH CHECK ADD  CONSTRAINT [FK_Donor_Blood] FOREIGN KEY([Blood_Group])
REFERENCES [dbo].[Blood] ([Blood_Type])
GO

ALTER TABLE [dbo].[Donor] CHECK CONSTRAINT [FK_Donor_Blood]
GO


