use [WST]
/****** Object:  Trigger [dbo].[InsertTMRMessage]    Script Date: 11/04/2019 9:57:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create TRIGGER [dbo].[InsertTMRMessage] ON [dbo].[RM20101]
AFTER INSERT
AS
BEGIN
 declare @vid char(15);
 declare @custnumber char(15);
 declare @docnumber char(21);
 declare @rmdtypal smallint;
 declare @duedate datetime;
 declare @docdate datetime;
 declare @docamnt numeric(19, 5);
 declare @vnumber char(21);
 declare @countype int;
 declare @series char(21);
 declare @phone1 varchar(50);
 declare @phone2 varchar(50);
 declare @phone3 varchar(50);
 --declare @countnum int;
 --declare @coountsnum int;
 
 
 --select @id = customerlist.id from inserted customerlist;
 select @vid = '' ;
 select @custnumber = CUSTNMBR from inserted ;
 select @docnumber = DOCNUMBR from inserted ;
 select @rmdtypal = RMDTYPAL from inserted ;
 select @duedate = DUEDATE from inserted ;
 select @docdate = DOCDATE from inserted ;
 select @vnumber = '' ;
 select @docamnt = ORTRXAMT from inserted ;
 select @series = 'rm'
 set @phone1 = (select Left(PHONE1,11) from RM00101 where custnmbr = @custnumber)
 set @phone2 = (select Left(PHONE2,11) from RM00101 where custnmbr = @custnumber)
 set @phone3 = (select Left(PHONE3,11) from RM00101 where custnmbr = @custnumber)
 --select @custnumber = customerlist.CUSTNMBR from inserted customerlist;


set @countype = (select  count(DOCNUMBR) from TMRMESSAGETABLE where DOCNUMBR = @docnumber and DOCTYPE = @rmdtypal and CUSTNMBR  = @custnumber)

IF (@countype =  0)
	INSERT INTO TMRMESSAGETABLE(VENDORID,CUSTNMBR,DOCNUMBR,DOCTYPE,DUEDATE,DOCDATE,DOCAMNT,VCHRNMBR,SERIES, PhoneNo1,PhoneNo2,PhoneNo3)
 VALUES(@vid,@custnumber,@docnumber,@rmdtypal,@duedate,@docdate,@docamnt,@vnumber,@series, @phone1,@phone2,@phone3)

  END
