USE [BDMS]
GO

/****** Object:  Table [dbo].[Donor_Donation]    Script Date: 12/4/2018 8:14:18 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Donor_Donation](
	[Donor_id] [int] NULL,
	[Name] [nvarchar](50) NULL,
	[Blood_Group] [nvarchar](50) NULL,
	[Bottles] [int] NULL,
	[Date] [nvarchar](50) NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Donor_Donation]  WITH CHECK ADD  CONSTRAINT [FK_Donor_Donation_Blood] FOREIGN KEY([Blood_Group])
REFERENCES [dbo].[Blood] ([Blood_Type])
GO

ALTER TABLE [dbo].[Donor_Donation] CHECK CONSTRAINT [FK_Donor_Donation_Blood]
GO

ALTER TABLE [dbo].[Donor_Donation]  WITH CHECK ADD  CONSTRAINT [FK_Donor_Donation_Donor] FOREIGN KEY([Donor_id])
REFERENCES [dbo].[Donor] ([D_id])
GO

ALTER TABLE [dbo].[Donor_Donation] CHECK CONSTRAINT [FK_Donor_Donation_Donor]
GO


