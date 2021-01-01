USE [BDMS]
GO

/****** Object:  Table [dbo].[Employee]    Script Date: 12/4/2018 8:14:34 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Employee](
	[E_id] [int] IDENTITY(4350,1) NOT NULL,
	[E_Name] [nvarchar](50) NULL,
	[E_Username] [nvarchar](50) NULL,
	[E_Password] [nvarchar](50) NULL,
	[Gender] [nvarchar](50) NULL,
	[ContactNo] [nvarchar](50) NULL,
	[Blood_Group] [nvarchar](50) NULL,
	[DOB] [nvarchar](50) NULL,
	[CNIC] [nvarchar](50) NULL,
	[Type] [nvarchar](50) NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[E_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Blood] FOREIGN KEY([Blood_Group])
REFERENCES [dbo].[Blood] ([Blood_Type])
GO

ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Blood]
GO


