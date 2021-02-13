

CREATE TABLE [Customer].[CustomerDetails](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CustomerName] [varchar](150) NULL,
	[TemporaryAddress] [varchar](150) NULL,
	[PermanentAddress] [varchar](150) NULL,
	[EmailAddress] [varchar](150) NULL,
	[ContactNUmber] [varchar](150) NULL,
	[CreatedDate] [datetime2](7) NULL,
	[CreatedBy] [varchar](150) NULL,
	[ModifiedBy] [varchar](150) NULL,
	[ModifiedDate] [varchar](150) NULL
) ON [PRIMARY]
GO


