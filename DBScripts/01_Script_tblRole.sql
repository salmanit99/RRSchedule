 SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tblRole](
	[Id] [bigint] IDENTITY(1,1),
	[Name] [varchar](250) NULL,
	[CreateBy] [varchar](250) NULL,
	[CreateDateTime] [datetime] NULL,
	[UpdatedBy] [varchar](250) NULL,
    [UpdatedDateTime] [datetime] NULL,
 CONSTRAINT [PK_tblRole] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

---------------------------------------------------

----Inserted new record---
--Insert into tblRole values ('BasicUser','Shaikh Ateeque',GETDATE(),Null,Null)
--Insert into tblRole values ('Admin','Shaikh Ateeque',GETDATE(),Null,Null)
--Insert into tblRole values ('SuperAdmin','Shaikh Ateeque',GETDATE(),Null,Null)

---Selected new record----
--Select * from tblRole

