SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tblUsers](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
    [Email] [varchar](250) UNIQUE,
	[Password] [nvarchar](500) NULL,
    [Firstname] [varchar](250) NULL,
	[Lastname] [varchar](250) NULL,
	[Gender] [varchar](250) NULL,
	[IsActive] [bit] NOT NULL,
	[UserImage] [nvarchar](max) NULL,
	[RuleId] [bigint] constraint RuleId_Fk foreign key (RuleId) references tblRole (Id)
 CONSTRAINT [PK_tblUsers] PRIMARY KEY CLUSTERED 
([ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

---------------------------------------------------------\
--insert into [tblUsers] values ('ateequeit@gmail.com','Zohan@123','Shaikh','Ateeque','Male',1,Null,1)
--insert into [tblUsers] values ('aasifit@gmail.com','Zohan@123','Khan','Aasif','Female',1,Null,2)
--insert into [tblUsers] values ('tausifit@gmail.com','Zohan@123','Syyad','Zuber','Male',1,Null,3)
--insert into [tblUsers] values ('danish.shaikh@gmail.com','Zohan@123','Tausif','Qureshi','Male',1,Null,1)
--insert into [tblUsers] values ('salman.itk77@gmail.com','Zohan@123','Salman','Khan','Male',1,Null,1)
