USE [BDMS]
GO

/****** Object:  Table [dbo].[Employee_D]    Script Date: 12/4/2018 8:15:03 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Employee_D](
	[E_id] [int] NULL,
	[E_Name] [nvarchar](50) NULL,
	[Bottles] [nvarchar](50) NULL,
	[Date] [nvarchar](50) NULL,
	[BloodGroup] [nvarchar](50) NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Employee_D]  WITH CHECK ADD  CONSTRAINT [FK_Employee_D_Blood] FOREIGN KEY([BloodGroup])
REFERENCES [dbo].[Blood] ([Blood_Type])
GO

ALTER TABLE [dbo].[Employee_D] CHECK CONSTRAINT [FK_Employee_D_Blood]
GO

ALTER TABLE [dbo].[Employee_D]  WITH CHECK ADD  CONSTRAINT [FK_Employee_D_Employee] FOREIGN KEY([E_id])
REFERENCES [dbo].[Employee] ([E_id])
GO

ALTER TABLE [dbo].[Employee_D] CHECK CONSTRAINT [FK_Employee_D_Employee]
GO


