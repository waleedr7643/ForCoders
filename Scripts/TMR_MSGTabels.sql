use [WST]
GO
/****** Object:  Table [dbo].[TMRDOCTYPE]    Script Date: 11/04/2019 9:56:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TMRDOCTYPE](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[DOCTYPE] [smallint] NOT NULL,
	[SERIES] [char](21) NOT NULL,
	[DESCRIPTION] [text] NOT NULL,
	[Message] [text] NOT NULL,
 CONSTRAINT [PK_TMRDOCTYPE] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TMRMESSAGETABLE]    Script Date: 11/04/2019 9:56:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TMRMESSAGETABLE](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[DOCNUMBR] [char](21) NOT NULL,
	[VENDORID] [char](15) NOT NULL,
	[CUSTNMBR] [char](15) NOT NULL,
	[DOCTYPE] [smallint] NOT NULL,
	[DOCDATE] [datetime] NOT NULL,
	[DUEDATE] [datetime] NOT NULL,
	[DOCAMNT] [numeric](19, 5) NOT NULL,
	[VCHRNMBR] [char](21) NOT NULL,
	[SERIES] [char](21) NOT NULL,
	[Status] [int] NULL CONSTRAINT [DF_TMRMESSAGETABLE_Status]  DEFAULT ((3)),
	[ErrorMsg] [varchar](1000) NULL CONSTRAINT [DF_TMRMESSAGETABLE_ErrorMsg]  DEFAULT (''),
	[PhoneNo1] [varchar](50) NULL CONSTRAINT [DF_TMRMESSAGETABLE_PhoneNo]  DEFAULT (''),
	[PhoneNo2] [varchar](50) NULL,
	[PhoneNo3] [varchar](50) NULL,
	[AttemptDate] [datetime] NULL CONSTRAINT [DF_TMRMESSAGETABLE_AttemptDate]  DEFAULT (((1)/(1))/(1900)),
 CONSTRAINT [PK_TMRMESSAGETABLE] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[TMRDOCTYPE] ON 

INSERT [dbo].[TMRDOCTYPE] ([id], [DOCTYPE], [SERIES], [DESCRIPTION], [Message]) VALUES (1, 1, N'pm                   ', N'Invoice', N'Dear Waseem Steel Vendor,
Invoice # <DOCNUMBR> of RS. <DOCAMNT> has been generated against your account on <DOCDATE>. 
Thank you.
Billing Department')
INSERT [dbo].[TMRDOCTYPE] ([id], [DOCTYPE], [SERIES], [DESCRIPTION], [Message]) VALUES (4, 2, N'pm                   ', N'Finance Charge', N'Dear Waseem Steel Vendor,
Finance Charge# <DOCNUMBR> of RS. <DOCAMNT> has been generated against your account on <DOCDATE>. 
Thank you.
Billing Department')
INSERT [dbo].[TMRDOCTYPE] ([id], [DOCTYPE], [SERIES], [DESCRIPTION], [Message]) VALUES (5, 3, N'pm                   ', N'Misc Charge', N'Dear Waseem Steel Vendor,
Invoice # <DOCNUMBR> of RS. <DOCAMNT> has been generated against your account on <DOCDATE>. 
Thank you.
Billing Department')
INSERT [dbo].[TMRDOCTYPE] ([id], [DOCTYPE], [SERIES], [DESCRIPTION], [Message]) VALUES (6, 4, N'pm                   ', N'Return', N'Dear Waseem Steel Vendor,
Return# <DOCNUMBR> of RS. <DOCAMNT> has been generated against your account on <DOCDATE>. 
Thank you.
Billing Department')
INSERT [dbo].[TMRDOCTYPE] ([id], [DOCTYPE], [SERIES], [DESCRIPTION], [Message]) VALUES (7, 5, N'pm                   ', N'Credit Memo', N'Dear Waseem Steel Vendor,
Credit Memo# <DOCNUMBR> of RS. <DOCAMNT> has been generated against your account on <DOCDATE>. 
Thank you.
Billing Department')
INSERT [dbo].[TMRDOCTYPE] ([id], [DOCTYPE], [SERIES], [DESCRIPTION], [Message]) VALUES (8, 6, N'pm                   ', N'Payment', N'Dear Waseem Steel Vendor,
Payment # <DOCNUMBR> of RS. <DOCAMNT> has been deposited against your account on <DOCDATE>. . 
Thank you.
Billing Department')
INSERT [dbo].[TMRDOCTYPE] ([id], [DOCTYPE], [SERIES], [DESCRIPTION], [Message]) VALUES (10, 0, N'rm                   ', N'Reserved for balance carried forward records', N'Dear Waseem Steel Customer,
Reserved for balance carried forward records# <DOCNUMBR> of RS. <DOCAMNT> has been generated against your account and will be due on <DUEDATE>. 
Thank you.
Billing Department')
INSERT [dbo].[TMRDOCTYPE] ([id], [DOCTYPE], [SERIES], [DESCRIPTION], [Message]) VALUES (11, 1, N'rm                   ', N'Sale / Invoice', N'Dear Waseem Steel Customer,
Invoice # <DOCNUMBR> of RS. <DOCAMNT> has been generated against your account and will be due on <DUEDATE>. 
Thank you.
Billing Department')
INSERT [dbo].[TMRDOCTYPE] ([id], [DOCTYPE], [SERIES], [DESCRIPTION], [Message]) VALUES (12, 2, N'rm                   ', N'Reserved for scheduled payments', N'Dear Waseem Steel Customer,
Reserved for scheduled payments# <DOCNUMBR> of RS. <DOCAMNT> has been generated against your account and will be due on <DUEDATE>. 
Thank you.
Billing Department')
INSERT [dbo].[TMRDOCTYPE] ([id], [DOCTYPE], [SERIES], [DESCRIPTION], [Message]) VALUES (13, 3, N'rm                   ', N'Debit Memo', N'Dear Waseem Steel Customer,
Debit Memo# <DOCNUMBR> of RS. <DOCAMNT> has been generated against your account and will be due on <DUEDATE>. 
Thank you.
Billing Department')
INSERT [dbo].[TMRDOCTYPE] ([id], [DOCTYPE], [SERIES], [DESCRIPTION], [Message]) VALUES (14, 4, N'rm                   ', N'Finance Charge', N'Dear Waseem Steel Customer,
Finance Charge# <DOCNUMBR> of RS. <DOCAMNT> has been generated against your account and will be due on <DUEDATE>. 
Thank you.
Billing Department')
INSERT [dbo].[TMRDOCTYPE] ([id], [DOCTYPE], [SERIES], [DESCRIPTION], [Message]) VALUES (15, 5, N'rm                   ', N'Service / Repair', N'Dear Waseem Steel Customer,
Service / Repair# <DOCNUMBR> of RS. <DOCAMNT> has been generated against your account and will be due on <DUEDATE>. 
Thank you.
Billing Department')
INSERT [dbo].[TMRDOCTYPE] ([id], [DOCTYPE], [SERIES], [DESCRIPTION], [Message]) VALUES (16, 6, N'rm                   ', N'Warranty', N'Dear Waseem Steel Customer,
Warranty# <DOCNUMBR> of RS. <DOCAMNT> has been generated against your account and will be due on <DUEDATE>. 
Thank you.
Billing Department')
INSERT [dbo].[TMRDOCTYPE] ([id], [DOCTYPE], [SERIES], [DESCRIPTION], [Message]) VALUES (17, 7, N'rm                   ', N'Credit Memo', N'Dear Waseem Steel Customer,
Credit Memo# <DOCNUMBR> of RS. <DOCAMNT> has been generated against your account and will be due on <DUEDATE>. 
Thank you.
Billing Department')
INSERT [dbo].[TMRDOCTYPE] ([id], [DOCTYPE], [SERIES], [DESCRIPTION], [Message]) VALUES (18, 8, N'rm                   ', N'Return', N'Dear Waseem Steel Customer,
Return# <DOCNUMBR> of RS. <DOCAMNT> has been generated against your account and will be due on <DUEDATE>. 
Thank you.
Billing Department')
INSERT [dbo].[TMRDOCTYPE] ([id], [DOCTYPE], [SERIES], [DESCRIPTION], [Message]) VALUES (19, 9, N'rm                   ', N'Payment', N'Payment
Dear Waseem Steel Customer,
Thank you for the payment # <DOCNUMBR> of Rs. <DOCAMNT>. 
For any clarification, call our helpline 051-4863900.
Thank you.
Billing Department')
SET IDENTITY_INSERT [dbo].[TMRDOCTYPE] OFF
SET IDENTITY_INSERT [dbo].[TMRMESSAGETABLE] ON 

INSERT [dbo].[TMRMESSAGETABLE] ([id], [DOCNUMBR], [VENDORID], [CUSTNMBR], [DOCTYPE], [DOCDATE], [DUEDATE], [DOCAMNT], [VCHRNMBR], [SERIES], [Status], [ErrorMsg], [PhoneNo1], [PhoneNo2], [PhoneNo3], [AttemptDate]) VALUES (4, N'SALES00000001025     ', N'               ', N'AARONFIT0001   ', 1, CAST(N'2027-04-12 00:00:00.000' AS DateTime), CAST(N'2027-05-12 00:00:00.000' AS DateTime), CAST(53500.00000 AS Numeric(19, 5)), N'                     ', N'rm                   ', 2, N'Send Successfully', N'03475154304                    ', NULL, NULL, CAST(N'1900-01-01 00:00:00.000' AS DateTime))
INSERT [dbo].[TMRMESSAGETABLE] ([id], [DOCNUMBR], [VENDORID], [CUSTNMBR], [DOCTYPE], [DOCDATE], [DUEDATE], [DOCAMNT], [VCHRNMBR], [SERIES], [Status], [ErrorMsg], [PhoneNo1], [PhoneNo2], [PhoneNo3], [AttemptDate]) VALUES (5, N'469                  ', N'ACETRAVE0001   ', N'               ', 1, CAST(N'2027-04-12 00:00:00.000' AS DateTime), CAST(N'2027-05-12 00:00:00.000' AS DateTime), CAST(9000.00000 AS Numeric(19, 5)), N'00000000000000469    ', N'pm                   ', 2, N'Send Successfully', N'03335521350         ', NULL, NULL, CAST(N'1900-01-01 00:00:00.000' AS DateTime))
INSERT [dbo].[TMRMESSAGETABLE] ([id], [DOCNUMBR], [VENDORID], [CUSTNMBR], [DOCTYPE], [DOCDATE], [DUEDATE], [DOCAMNT], [VCHRNMBR], [SERIES], [Status], [ErrorMsg], [PhoneNo1], [PhoneNo2], [PhoneNo3], [AttemptDate]) VALUES (6, N'SALES00000001026     ', N'               ', N'AARONFIT0001   ', 1, CAST(N'2027-04-12 00:00:00.000' AS DateTime), CAST(N'2027-05-12 00:00:00.000' AS DateTime), CAST(53500.00000 AS Numeric(19, 5)), N'                     ', N'rm                   ', 3, N'', N'42555501010', N'00000000000', N'           ', CAST(N'1900-01-01 00:00:00.000' AS DateTime))
INSERT [dbo].[TMRMESSAGETABLE] ([id], [DOCNUMBR], [VENDORID], [CUSTNMBR], [DOCTYPE], [DOCDATE], [DUEDATE], [DOCAMNT], [VCHRNMBR], [SERIES], [Status], [ErrorMsg], [PhoneNo1], [PhoneNo2], [PhoneNo3], [AttemptDate]) VALUES (7, N'470                  ', N'ACETRAVE0001   ', N'               ', 1, CAST(N'2027-04-12 00:00:00.000' AS DateTime), CAST(N'2027-05-12 00:00:00.000' AS DateTime), CAST(9000.00000 AS Numeric(19, 5)), N'00000000000000470    ', N'pm                   ', 3, N'', NULL, NULL, NULL, CAST(N'1900-01-01 00:00:00.000' AS DateTime))
INSERT [dbo].[TMRMESSAGETABLE] ([id], [DOCNUMBR], [VENDORID], [CUSTNMBR], [DOCTYPE], [DOCDATE], [DUEDATE], [DOCAMNT], [VCHRNMBR], [SERIES], [Status], [ErrorMsg], [PhoneNo1], [PhoneNo2], [PhoneNo3], [AttemptDate]) VALUES (8, N'471                  ', N'ACETRAVE0001   ', N'               ', 1, CAST(N'2027-04-12 00:00:00.000' AS DateTime), CAST(N'2027-05-12 00:00:00.000' AS DateTime), CAST(90000.00000 AS Numeric(19, 5)), N'00000000000000471    ', N'pm                   ', 3, N'', N'29855501010', N'00000000000', N'           ', CAST(N'1900-01-01 00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[TMRMESSAGETABLE] OFF
